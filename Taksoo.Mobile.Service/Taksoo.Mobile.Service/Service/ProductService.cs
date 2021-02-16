using ServiceHelper.ServiceHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Taksoo.Mobile.Common.Constant;
using Taksoo.Mobile.Common.MappingExtention;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service.Interface;


namespace Taksoo.Mobile.Service.Service
{
  public  class ProductService:IProductService
    {
        public async Task<ICollection<Products>> GetOfferProduct()
        {
            try
            {

                var result = new HttpClientHelper(UserInfoMapping.MapToUserInfo()).Get<List<Products>>(HttpUrlHelper.Get(AppConstant.RestUrl, "Test", "Index"), null);
            

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(AppConstant.SiteUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //GET Method  
                    HttpResponseMessage response = await client.GetAsync("/api/Test/Index");
                    if (response.IsSuccessStatusCode)
                    {
                        //return await response.Content.ReadAsAsync<List<Products>>();
                    }
                    return null;
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " " + e.InnerException);
            }
        }
    }
}
