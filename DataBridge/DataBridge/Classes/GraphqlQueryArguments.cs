using DataBridge.Environment;
using DataBridge.Shared.Classes;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBridge.Classes
{
    public static class GraphQLQuery
    {
        public static MapperObject GetMapperObject(string tableName, IResolveFieldContext<object> context)
        {
            var Page = context.GetArgument<uint>("page", 1);
            var Size = context.GetArgument<uint>("pageSize", 20);
            var Filter = context.GetArgument<IEnumerable<string>>("filter");
            var Order = context.GetArgument<IEnumerable<string>>("order");

            if (Page < 1)
                Page = 1;

            uint offset = (Page - 1) * Size;

            MapperObject map = new MapperObject(tableName).Offset(offset).Take(Size);

            if (Filter != null)
            {
                foreach (string filter in Filter)
                {
                    string key = filter.Substring(0, filter.IndexOf('=')).Trim();
                    string val = filter.Substring(filter.IndexOf('=') + 1).Trim();
                    map.Where(key, val);
                }
            }

            if (Order != null)
            {
                foreach (string order in Order)
                    map.OrderBy(order);
            }

            return map;
        }

        public static QueryArguments ForGraphql()
        {
            return new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "page", Description = "page" },
                    new QueryArgument<IntGraphType> { Name = "pageSize", Description = "pageSize" },
                    new QueryArgument<ListGraphType<StringGraphType>> { Name = "filter", Description = "column and value" },
                    new QueryArgument<ListGraphType<StringGraphType>> { Name = "order", Description = "column and ordertype" }
                );
        }
    }
}
