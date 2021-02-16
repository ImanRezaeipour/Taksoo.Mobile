using System.Collections.Generic;

namespace Taksoo.Mobile.Service.Parameter
{
    public class RegionParam : EntityParamBase
    {
        public string Name { get; set; }
        public List<RegionBorderParam> RegionBorderParams { set; get; }
    }
}
