using EntityView.Data;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityView.Creations
{
    public class SortState
    {
        public string activeSortColumn;
        public bool isSortedAscending;
    }


    public static class NetGrid
    {
        public static string GetHtml(IEnumerable<Company> _companies)
        {
            string html = "<table class=\"table\" cellpadding=\"0\" cellspacing=\"0\"><thead><tr>";
            html += "<th><a class=\"headerLink\" href=\"companies?ordercolumn=companyname\">Company Name</a></th>";
            html += "<th><a class=\"headerLink\" href=\"companies?ordercolumn=internalname\">Internal Name</a></th>";
            html += "<th><a class=\"headerLink\" href=\"companies?ordercolumn=address\">Address</a></th>";
            html += "</tr></thead><tbody>";

            foreach (var company in _companies)
            {
                html += "<tr>";
                html += "<td><a href=\"company/" + company.Id + "\">" + company.CompanyName + "</a></td>";
                html += "<td>" + company.InternalName + "</td>";
                html += "<td>" + company.Address + "</td>";
                html += "</tr>";
            }
            html += "</tbody></table>";
            return html;
        }

        public static void SortTable<T>(this List<T> list, string columnName, SortState states)
        {
            if (columnName != states.activeSortColumn)
            {
                list = list.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                states.isSortedAscending = true;
                states.activeSortColumn = columnName;
            }
            else
            {
                if (states.isSortedAscending)
                {
                    list = list.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                }
                else
                {
                    list = list.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                }
                states.isSortedAscending = !states.isSortedAscending;
            }
        }
    }
}
