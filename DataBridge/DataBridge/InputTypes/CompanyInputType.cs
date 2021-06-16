using GraphQL.Types;

namespace DataBridge.InputTypes
{
    public class CompanyInputType : InputObjectGraphType
    {
        public CompanyInputType()
        {
            Name = "companyInput";

            Field<IdGraphType>("Id");
            Field<IdGraphType>("Creator");
            Field<IdGraphType>("Modifier");
            Field<StringGraphType>("Created");
            Field<StringGraphType>("Modified");
            Field<StringGraphType>("CompanyName");
            Field<StringGraphType>("InternalName");
            Field<StringGraphType>("Address");
        }
    }
}
