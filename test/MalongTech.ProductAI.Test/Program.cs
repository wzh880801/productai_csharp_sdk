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
                AccessKeyId = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                SecretKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };
            var client = new DefaultProductAIClient(profile);
            var request = new Detect3CElectronicsByImageFileRequest
            {
                ImageFile = new System.IO.FileInfo(@".\phone.jpg")
            };
            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach(var r in response.DetectedBoxes)
                {
                    Console.WriteLine("{0}\t{1}", r.Type, r.Score);
                }
            }
            Console.ReadLine();
        }
    }
}