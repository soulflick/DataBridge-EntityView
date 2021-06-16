using GraphQL.Types;

namespace DataBridge.InputTypes
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "UserInput";

            Field<IdGraphType>("Id");
            Field<IdGraphType>("Creator");
            Field<IdGraphType>("Modifier");
            Field<StringGraphType>("Created");
            Field<StringGraphType>("Modified");
            Field<IdGraphType>("CompanyId");
            Field<IdGraphType>("FactoryId");
            Field<NonNullGraphType<StringGraphType>>("Name");

        }
    }
}
