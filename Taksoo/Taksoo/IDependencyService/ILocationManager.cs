using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.IDependencyService
{
    public interface ILocationManager
    {
        event EventHandler<ILocationEventArgs> OnLocationChanged;
    }
    public interface ILocationEventArgs
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}
