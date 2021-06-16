using DataBridge.InputTypes;
using DataBridge.Interfaces;
using DataBridge.Shared.Entities;
using GraphQL;
using GraphQL.Types;
using System;

namespace DataBridge.Mutations
{
    public class FactoryMutation : ObjectGraphType
    {
        private IRepository<Factory> _factoryRepo;

        public FactoryMutation(IRepository<Factory> factoryRepo)
        {
            _factoryRepo = factoryRepo;

            FieldAsync<LongGraphType>(
              "createFactory",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<FactoryInputType>> { Name = "factory" }
              ),
              resolve: async context =>
              {
                  var factory = context.GetArgument<Factory>("factory");
                  return await _factoryRepo.Insert(factory);
              });


            FieldAsync<BooleanGraphType>(
              "updateFactory",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<FactoryInputType>> { Name = "factory" }
              ),
              resolve: async context =>
              {
                  var factory = context.GetArgument<Factory>("factory");
                  if (factory.Id == Guid.Empty)
                      return false;

                  return await _factoryRepo.Update(factory);
              });

            FieldAsync<BooleanGraphType>(
              "deleteFactory",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<FactoryInputType>> { Name = "factory" }
              ),
              resolve: async context =>
              {
                  var factory = context.GetArgument<Factory>("factory");
                  if (factory.Id == Guid.Empty)
                      return false;

                  return await _factoryRepo.Delete(factory);
              });
        }
    }


}
