using DataBridge.Mutations;
using DataBridge.Queries;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DataBridge.Schemas
{
    public class CompanySchema : Schema
    {
        public CompanySchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CompanyQuery>();
            Mutation = serviceProvider.GetRequiredService<CompanyMutation>();
        }
    }

    public class UserSchema : Schema
    {
        public UserSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<UserQuery>();
            Mutation = serviceProvider.GetRequiredService<UserMutation>();
        }
    }

    public class FactorySchema : Schema
    {
        public FactorySchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<FactoryQuery>();
            Mutation = serviceProvider.GetRequiredService<FactoryMutation>();
        }
    }
}