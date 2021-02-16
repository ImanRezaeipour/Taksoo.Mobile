using System.Reflection;

namespace Taksoo.Mobile.Data.Model
{
    public class User : EntityBase
    {
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Language { get; set; }
        public bool IsAuthenticated { get; set; }
       public string UserCode { get; set; }
    }
}
