using DataBridge.Environment;
using DataBridge.Interfaces;
using DataBridge.Shared.Classes;
using DataBridge.Shared.Entities;
using GraphQL.Types;

namespace DataBridge.Types
{
    public class CompanyType : ObjectGraphType<Company>, IObjectGraphType
    {
        private IRepository<User> _userRepo;
        private IRepository<Factory> _factoryRepo;

        public CompanyType(IRepository<User> userRepo, IRepository<Factory> factoryRepo) : base()
        {
            _userRepo = userRepo;
            _factoryRepo = factoryRepo;

            Field(i => i.Id).Description("Primary key");
            Field(i => i.CompanyName).Description("The company name");
            Field(i => i.Address).Description("The company address");
            Field(i => i.Created).Description("Time of creation"); ;
            Field(i => i.Creator).Description("The creator"); ;
            Field(i => i.Modified, nullable: true).Description("Time of modification"); ;
            Field(i => i.Modifier, nullable: true).Description("The modifier");

            Field<ListGraphType<UserType>>("users", resolve: context =>
            {
                MapperObject map = new MapperObject(Table.Get(Tables.Users));
                map.Where("CompanyId", context.Source.Id.ToString());
                return _userRepo.Query(map).Result;
            });

            FieldAsync<ListGraphType<FactoryType>>("factories", resolve: async context =>
            {
                MapperObject map = new MapperObject(Table.Get(Tables.Factories));
                map.Where("CompanyId", context.Source.Id.ToString());
                return await _factoryRepo.Query(map);
            });

        }
    }
}
