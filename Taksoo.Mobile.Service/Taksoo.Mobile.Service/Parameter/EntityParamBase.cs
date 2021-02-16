using System;

namespace Taksoo.Mobile.Service.Parameter
{
    public interface IEntityParamBase
    {
        Guid Id { get; set; }
    }
    public abstract class EntityParamBase : IEntityParamBase
    {
        public Guid Id { get; set; }
    }
}
