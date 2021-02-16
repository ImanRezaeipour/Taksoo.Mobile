using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Taksoo.CommonPage
{
  public  class CustomToolbarPage:ContentPage
    {
        public CustomToolbarPage()
        {
            Init();
        }

        private void Init()
        {
            this.ToolbarItems.Add(new ToolbarItem() { Text = "مقایسه محصول", Priority = 0, Order = ToolbarItemOrder.Secondary });
            this.ToolbarItems.Add(new ToolbarItem() { Text = "نمودار قیمت", Priority = 0, Order = ToolbarItemOrder.Secondary });
            this.ToolbarItems.Add(new ToolbarItem() { Text = "نقد و بررسی", Priority = 0, Order = ToolbarItemOrder.Secondary });
        }
    }
}
