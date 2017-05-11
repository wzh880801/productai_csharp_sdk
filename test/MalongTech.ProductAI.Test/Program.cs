using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalongTech.ProductAI.API;
using MalongTech.ProductAI.API.Entity;

namespace MalongTech.ProductAI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var profile = new DefaultProfile
            {
                Version = "1",
                AccessKeyId = "**************************",
                SecretKey = "**************************"
            };
            var client = new DefaultProductAIClient(profile);
            //var request = new IntelligentFilterByImageUrlRequest
            //{
            //    Url = "http://dimg3.s-9in.com/imageadapter/w220h220q80/stimg4.s-9in.com/www9incom/2016/10/25/db18a2d1-bf45-439b-950f-a5b21782b62c.jpg"
            //};
            var request = new ImageContentAnalysisByImageFileRequest
            {
                ImageFile = new System.IO.FileInfo(@"d:\db18a2d1-bf45-439b-950f-a5b21782b62c.jpg")
            };
            var response = client.Execute(request);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response));
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //System.Diagnostics.Process.Start("chrome.exe", response.Results[0].Category);
                foreach(var r in response.Results)
                {
                    Console.WriteLine("{0}\t{1}", r.Category, r.Score);
                }
            }
            Console.ReadLine();
        }
    }
}