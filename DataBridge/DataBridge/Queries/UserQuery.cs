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
    public class UserQuery : ObjectGraphType
    {
        private IRepository<User> _userRepo;

        public UserQuery(IRepository<User> userRepo)
        {
            _userRepo = userRepo;

            FieldAsync<ListGraphType<UserType>>(
                name: "users",
                arguments: GraphQLQuery.ForGraphql(),
                resolve: async context =>
                {
                    MapperObject qlMap = GraphQLQuery.GetMapperObject(Table.Get(Tables.Users), context);
                    return await _userRepo.Query(qlMap);
                }
            );

            FieldAsync<UserType>(
                name: "user",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: async context =>
                {
                    Guid id = context.GetArgument<Guid>("id");
                    return await _userRepo.Get(id);
                }
            );
        }
    }
}
