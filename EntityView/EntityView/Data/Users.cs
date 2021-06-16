using System;

namespace EntityView.Data
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public Guid CompanyId { get; set; }
        public Guid FactoryId { get; set; }
        public string Company { get; set; }
        public  string Factory { get; set; }

    }
}
