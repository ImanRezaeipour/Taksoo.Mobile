using System;
using SQLite;

namespace Taksoo.Mobile.Data.Model
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
    }
    public abstract class EntityBase : IEntityBase
    {
        [PrimaryKey]
        public Guid Id { get; set; }
    }
}
