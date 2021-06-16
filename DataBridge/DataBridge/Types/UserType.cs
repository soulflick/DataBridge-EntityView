using DataBridge.Interfaces;
using DataBridge.Shared.Entities;
using GraphQL.Types;

namespace DataBridge.Types
{
    public class UserType : ObjectGraphType<User>
    {
        private IRepository<Company> _companyRepo;
        private IRepository<Factory> _factoryRepo;
        public UserType(IRepository<Company> companyRepo, IRepository<Factory> factoryRepo)
        {
            _companyRepo = companyRepo;
            _factoryRepo = factoryRepo;

            Field(i => i.Id).Description("Primary key");
            Field(i => i.FactoryId).Description("the factory id");
            Field(i => i.UserName).Description("The users name"); ;
            Field(i => i.Created).Description("Time of creation"); ;
            Field(i => i.Creator).Description("The creator"); ;
            Field(i => i.Modified, nullable: true).Description("Time of modification"); ;
            Field(i => i.Modifier, nullable: true).Description("The modifier");

            FieldAsync<CompanyType>("company", resolve: async context =>
            {
                return await _companyRepo.Get(context.Source.CompanyId);
            });

            FieldAsync<FactoryType>("factory", resolve: async context =>
            {
                return await _factoryRepo.Get(context.Source.FactoryId);
            });
        }
    }
}
