using DataBridge.Shared.Entities;
using DataBridge.Shared.Utilities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DataBridge.Shared.Classes
{
    public class MapperObject
    {
        public Dictionary<string, string> Parameters = new Dictionary<string, string>();

        private string Table;
        private List<string> SelectedColumns = new List<string>();
        private List<string> OrderedColumns = new List<string>();
        private List<string> GroupedColumns = new List<string>();

        private string SQL;
        private int Amount = -1;
        private int Skip = -1;

        public MapperObject(BaseEntity Entity)
        {
            Table = Entity.GetType().GetAttributeValue((TableAttribute ta) => ta.Name);
        }

        public MapperObject(string TableName)
        {
            Table = TableName;
        }

        public MapperObject For(string table)
        {
            Table = table;
            return this;
        }

        public MapperObject With(string column)
        {
            SelectedColumns.Add(column);
            return this;
        }

        public MapperObject Where(string column, string value)
        {
            Parameters[column] = value;
            return this;
        }

        public MapperObject OrderBy(string column)
        {
            OrderedColumns.Add(column);
            return this;
        }

        public MapperObject GroupBy(string column)
        {
            GroupedColumns.Add(column);
            return this;
        }

        public MapperObject Take(uint amount)
        {
            Amount = (int)amount;
            return this;
        }

        public MapperObject Offset(uint offset)
        {
            Skip = (offset > 0) ? (int)offset : 0;
            return this;
        }

        public string ToSQL()
        {
            SQL = "SELECT";
            
            if (!SelectedColumns.Any()) SQL += " *";
            else
            {
                string columns = string.Join(", ", SelectedColumns.Select(s => "[" + s + "]"));
                SQL += $" {columns}";
            }

            SQL += $"\nFROM {Table} WHERE 1=1";

            bool first = true;
            foreach (KeyValuePair<string, string> kvp in Parameters)
            {
                if (!first) SQL += " AND";
                SQL += $" {kvp.Key} = @{kvp.Key}";
                first = false;
            }

            if (!OrderedColumns.Any()) SQL += "\nORDER BY Id";
            else
            {
                SQL += "\nORDER BY " + string.Join(", ", OrderedColumns);
            }

            if (GroupedColumns.Any())
            {
                SQL += "\nGROUP BY " + string.Join(", ", GroupedColumns);
            }

            if (Skip >= 0) SQL += $"\nOFFSET {Skip} ROWS";

            if (Amount >= 0) SQL += $"\nFETCH NEXT {Amount} ROWS ONLY";

            SQL += ";";

            return SQL;
        }
    }
}
