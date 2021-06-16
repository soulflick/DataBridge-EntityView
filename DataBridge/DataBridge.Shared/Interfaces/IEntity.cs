using System;

namespace DataBridge.Shared.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Guid Creator { get; set; }
        DateTime Created { get; set; }
        Guid Modifier { get; set; }
        DateTime Modified { get; set; }

    }
}
