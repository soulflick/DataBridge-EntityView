using DataBridge.Environment;
using DataBridge.Interfaces;
using DataBridge.Shared.Classes;
using DataBridge.Shared.Entities;
using GraphQL.Types;
using System.Collections.Generic;

namespace DataBridge.Types
{
    public class FactoryType : ObjectGraphType<Factory>
    {
        private IRepository<User> _userRepo;
        private IRepository<Company> _companyRepo;

        public FactoryType(IRepository<User> userRepo, IRepository<Company> companyRepo)
        {
            _userRepo = userRepo;
            _companyRepo = companyRepo;

            Field(i => i.Id).Description("Primary key");
            Field(i => i.CompanyId).Description("Id of the company");
            Field(i => i.FactoryName).Description("The factory name");
            Field(i => i.Location).Description("The factory location");
            Field(i => i.Created).Description("Time of creation"); ;
            Field(i => i.Creator).Description("The creator"); ;
            Field(i => i.Modified, nullable: true).Description("Time of modification"); ;
            Field(i => i.Modifier, nullable: true).Description("The modifier");

            FieldAsync<CompanyType>("company", resolve: async context =>
            {
                return await _companyRepo.Get(context.Source.CompanyId);
            });

            FieldAsync<ListGraphType<UserType>>("users", resolve: async context =>
            {
                MapperObject map = new MapperObject(Table.Get(Tables.Users));
                map.Where("CompanyId", context.Source.CompanyId.ToString());
                return await _userRepo.Query(map);
            });
        }
    }
}
