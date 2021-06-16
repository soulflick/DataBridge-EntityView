using System;
using System.Collections.Generic;

namespace DataBridge.Environment
{
    public enum Tables
    {
        Companies,
        Users,
        Factories
    }

    public static class Table
    {
        private static Dictionary<Tables, string> _t = null;
        public static string Get(Tables table)
        {
            if (_t == null)
                init();

            if (!_t.ContainsKey(table))
                throw new NotImplementedException("Environment: did not map table: " + table.ToString());

            return _t[table];
        }

        private static void init()
        {
            _t = new Dictionary<Tables, string>();
            _t[Tables.Companies] = "Companies";
            _t[Tables.Users] = "Users";
            _t[Tables.Factories] = "Factories";
        }
    }

    public static class Options
    {
        public static bool LogDebug = true;
    }
}
