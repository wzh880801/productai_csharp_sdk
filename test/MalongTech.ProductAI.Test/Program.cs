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
                AccessKeyId = "XXXXXXXXXXXXXXXXXXXXXXX",
                SecretKey = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
            };
            var client = new DefaultProductAIClient(profile);

            //var request = new Detect3CElectronicsByImageFileRequest
            //{
            //    ImageFile = new System.IO.FileInfo(@".\phone.jpg")
            //};

            //var request = new ImageSearchByImageUrlRequest("ffhqzkee")
            //{
            //    Url = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
            //    Count = 2,
            //    Threshold = 0.8,
            //    SearchTags = new List<string> { "上衣", "短袖" }
            //};

            var request = new ImageSearchByImageFileRequest("ffhqzkee")
            {
                ImageFile = new System.IO.FileInfo(@".\phone.jpg"),
                Count = 2,
                Threshold = 0.8,
                SearchTags = new List<string> { "上衣", "短袖" }
            };

            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach(var r in response.Results)
                {
                    Console.WriteLine("{0}\t{1}", r.Url, r.Score);
                }
            }
            else
            {
                Console.WriteLine("Request failed! " + response.ErrorMsg);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}