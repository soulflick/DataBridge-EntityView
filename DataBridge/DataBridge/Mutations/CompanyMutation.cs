using DataBridge.InputTypes;
using DataBridge.Interfaces;
using DataBridge.Shared.Entities;
using GraphQL;
using GraphQL.Types;
using System;

namespace DataBridge.Mutations
{
    public class CompanyMutation : ObjectGraphType, IObjectGraphType
    {
        private IRepository<Company> _companyRepo;

        public CompanyMutation(IRepository<Company> companyRepo)
        {
            _companyRepo = companyRepo;

            FieldAsync<LongGraphType>(
              "createCompany",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<CompanyInputType>> { Name = "companyInput" }
              ),
              resolve: async context =>
              {
                  var company = context.GetArgument<Company>("companyInput");
                  return await _companyRepo.Insert(company);
              });


            FieldAsync<BooleanGraphType>(
              "updateCompany",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<CompanyInputType>> { Name = "companyInput" }
              ),
              resolve: async context =>
              {
                  var company = context.GetArgument<Company>("company");
                  if (company.Id == Guid.Empty)
                      return false;

                  return await _companyRepo.Update(company);
              });

            FieldAsync<BooleanGraphType>(
              "deleteCompany",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<CompanyInputType>> { Name = "companyInput" }
              ),
              resolve: async context =>
              {
                  var company = context.GetArgument<Company>("company");
                  if (company.Id == Guid.Empty)
                      return false;

                  return await _companyRepo.Delete(company);
              });
        }
    }


}
