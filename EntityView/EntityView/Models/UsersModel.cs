using EntityView.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EntityView.Models
{
    public class UsersModel : PageModel
    {
        public UsersModel()
        {
            _users.Add(new Data.User() { UserName = "admin" });
            _users.Add(new Data.User() { UserName = "user" });
        }

        public List<User> _users = new List<User>();

        public void SortTable(string property)
        {

        }
    }
}
