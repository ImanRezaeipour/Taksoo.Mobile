using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Gms.Maps;

namespace Taksoo.IDependencyService
{
  public  interface IIntent
  {
      void SendSms(string code);
      void SendEmail(string code);
      void SendTelegram(string code);
  }
}
