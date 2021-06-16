using DataBridge.Classes;
using DataBridge.Environment;
using DataBridge.Interfaces;
using DataBridge.Shared.Classes;
using DataBridge.Shared.Entities;
using DataBridge.Types;
using GraphQL;
using GraphQL.Types;
using System;

namespace DataBridge.Queries
{
    public class CompanyQuery : ObjectGraphType, IObjectGraphType
    {
        private IRepository<Company> _companyRepo;

        public CompanyQuery(IRepository<Company> companyRepo)
        {
            _companyRepo = companyRepo;

            FieldAsync<ListGraphType<CompanyType>>(
                name: "companies",
                arguments: GraphQLQuery.ForGraphql(),
                resolve: async context =>
                {
                    MapperObject qlMap = GraphQLQuery.GetMapperObject(Table.Get(Tables.Companies), context);
                    return await _companyRepo.Query(qlMap);
                }
            );

            FieldAsync<CompanyType>(
                name: "company",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: async context =>
                {
                    Guid id = context.GetArgument<Guid>("id");
                    return await _companyRepo.Get(id);
                }
            );

        }
    }
}
