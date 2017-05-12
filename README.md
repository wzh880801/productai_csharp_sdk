# .NET SDK for ProductAI
.NET SDK for ProductAI

`ProductAI`: 
<br>For more details about ProductAI, view [ProductAI offcial site](https://api-doc.productai.cn/doc/pai.html) [`https://api-doc.productai.cn/doc/pai.html`](https://api-doc.productai.cn/doc/pai.html)

# Usage:

```C#
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
                AccessKeyId = "XXXXXXXXXXXXXXXXXXXXX",
                SecretKey = "XXXXXXXXXXXXXXXXXXXXXX"
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

            //var request = new ImageSearchByImageFileRequest("ffhqzkee")
            //{
            //    ImageFile = new System.IO.FileInfo(@".\phone.jpg"),
            //    Count = 2,
            //    Threshold = 0.8,
            //    SearchTags = new List<string> { "上衣", "短袖" }
            //};

            //Single Add
            //var request = new DataSetSingleAddByImageUrlRequest("bd7nvc27")
            //{
            //    ImageUrl = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
            //    SearchTags = new List<string> { "上衣" }
            //};

            //Batch Add
            var request = new DataSetBatchAddRequest("bd7nvc27")
            {
                CsvFile = new System.IO.FileInfo(@".\example.csv")
            };

            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //foreach(var r in response.Results)
                //{
                //    Console.WriteLine("{0}\t{1}", r.Url, r.Score);
                //}

                Console.WriteLine(response.LastModifiedTime);
            }
            else
            {
                Console.WriteLine("Request failed! " + response.Message);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
```

# Support async...

```C#
var request = new ImageContentAnalysisByImageUrlRequest
{
    Url = "http://dimg3.s-9in.com/imageadapter/w220h220q80/stimg4.s-9in.com/www9incom/2016/10/25/db18a2d1-bf45-439b-950f-a5b21782b62c.jpg"
};
var response = await client.ExecuteAsync(request);
```
