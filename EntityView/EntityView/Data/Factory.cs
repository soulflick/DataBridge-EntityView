using System;

namespace EntityView.Data
{
    public partial class Factory 
    {
        public Guid Id { get; set; }
        public string FactoryName { get; set; }
        public string Location { get; set; }
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
