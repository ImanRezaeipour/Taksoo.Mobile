using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Service.Parameter;

namespace Taksoo.Mobile.Service.Service.Interface
{
    public interface ISelectedAddressService
    {
        void Insert(SelectedAddressParam model);
        void Update(SelectedAddressParam model);
        List<SelectedAddressParam> GetByMobile(string mobile);
        SelectedAddressParam GetbyId(Guid id);
        void Delete(Guid id);
    }
}
