using DataBridge.InputTypes;
using DataBridge.Interfaces;
using DataBridge.Shared.Entities;
using GraphQL;
using GraphQL.Types;
using System;

namespace DataBridge.Mutations
{
    public class UserMutation : ObjectGraphType
    {
        private IRepository<User> _userRepo;

        public UserMutation(IRepository<User> userRepo)
        {
            _userRepo = userRepo;

            FieldAsync<LongGraphType>(
              "createUser",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UserInputType>> { Name = "userInput" }
              ),
              resolve: async context =>
              {
                  var user = context.GetArgument<User>("user");
                  return await _userRepo.Insert(user);
              });


            FieldAsync<BooleanGraphType>(
              "updateUser",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UserInputType>> { Name = "userInput" }
              ),
              resolve: async context =>
              {
                  var user = context.GetArgument<User>("user");
                  if (user.Id == Guid.Empty)
                      return false;

                  return await _userRepo.Update(user);
              });

            FieldAsync<BooleanGraphType>(
              "deleteUser",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UserInputType>> { Name = "userInput" }
              ),
              resolve: async context =>
              {
                  var user = context.GetArgument<User>("user");
                  if (user.Id == Guid.Empty)
                      return false;

                  return await _userRepo.Delete(user);
              });
        }
    }


}
