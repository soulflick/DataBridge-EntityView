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
    public class FactoryQuery : ObjectGraphType
    {
        private IRepository<Factory> _factoryRepo;

        public FactoryQuery(IRepository<Factory> factoryRepo)
        {
            _factoryRepo = factoryRepo;

            FieldAsync<ListGraphType<FactoryType>>(
                name: "factories",
                arguments: GraphQLQuery.ForGraphql(),
                resolve: async context =>
                {
                    MapperObject qlMap = GraphQLQuery.GetMapperObject(Table.Get(Tables.Factories), context);
                    return await _factoryRepo.Query(qlMap);
                }
            );

            FieldAsync<FactoryType>(
                name: "factory",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: async context =>
                {
                    Guid id = context.GetArgument<Guid>("id");
                    return await _factoryRepo.Get(id);
                }
            );
        }
    }
}
