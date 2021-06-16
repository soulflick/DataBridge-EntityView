using GraphQL.Types;

namespace DataBridge.InputTypes
{
    public class FactoryInputType : InputObjectGraphType
    {
        public FactoryInputType()
        {
            Name = "FactoryInput";

            Field<IdGraphType>("Id");
            Field<IdGraphType>("Creator");
            Field<IdGraphType>("Modifier");
            Field<StringGraphType>("Created");
            Field<StringGraphType>("Modified");
            Field<NonNullGraphType<StringGraphType>>("FactoryName");
            Field<NonNullGraphType<StringGraphType>>("Location");
            Field<IdGraphType>("CompanyId");

        }
    }
}
