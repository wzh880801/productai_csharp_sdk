# .NET SDK for ProductAI
.NET SDK for ProductAI

## ProductAI: 
<br>For more details about ProductAI, view [ProductAI offcial site](https://api-doc.productai.cn/doc/pai.html) [`https://api-doc.productai.cn/doc/pai.html`](https://api-doc.productai.cn/doc/pai.html)

# Usage（用法）:

This SDK depends on SimpleWebRequestHelper, which you could find the source code at [SimpleWebRequestHelper](https://github.com/wzh880801/SimpleWebRequestHelper)[`https://github.com/wzh880801/SimpleWebRequestHelper`](https://github.com/wzh880801/SimpleWebRequestHelper). Or you could add http://nuget.esobing.com/nuget to your package source.

此SDK依赖于SimpleWebRequestHelper，你可以通过访问这个仓库获取它的源代码[SimpleWebRequestHelper](https://github.com/wzh880801/SimpleWebRequestHelper)[`https://github.com/wzh880801/SimpleWebRequestHelper`](https://github.com/wzh880801/SimpleWebRequestHelper). 或者你可以添加如下nuget库来让VS自动解决引用：http://nuget.esobing.com/nuget

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
            //Setup your account profile
            //账户初始化
            
            var profile = new DefaultProfile
            {
                Version = "1",
                AccessKeyId = "XXXXXXXXXXXXXXXXXXXXX",
                SecretKey = "XXXXXXXXXXXXXXXXXXXXXX"
            };
            var client = new DefaultProductAIClient(profile);

            //Build your request and just simple send it out using DefaultProductAIClient
            //你需要做的是初始化request然后通过DefaultProductAIClient发送给ProductAI服务器
            
            var request = new ImageSearchByImageUrlRequest("ffhqzkee")
            {
                Url = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
                Count = 2,
                Threshold = 0.8,
                SearchTags = new List<string> { "上衣", "短袖" }
            };

            //ProductAI Server will process your request and send back the response
            //ProductAI服务器会处理你的请求并返回处理结果
            
            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //You can access the entity directly
                //你可以直接访问返回的实体
                
                foreach(var r in response.Results)
                {
                    Console.WriteLine("{0}\t{1}", r.Url, r.Score);
                }
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

# Support async (支持异步)

```C#
var request = new ImageContentAnalysisByImageUrlRequest
{
    Url = "http://dimg3.s-9in.com/imageadapter/w220h220q80/stimg4.s-9in.com/www9incom/2016/10/25/db18a2d1-bf45-439b-950f-a5b21782b62c.jpg"
};
var response = await client.ExecuteAsync(request);
```

# Examples
# 图像内物体检测与定位
## 3C电器检测与定位(detect_3c_and_electronics)
### * detect_3c_and_electronics by local image file(使用本地图片文件检测3C电器)

```C#
var request = new Detect3CElectronicsByImageFileRequest
{
    ImageFile = new System.IO.FileInfo(@".\phone.jpg")
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```

### * detect_3c_and_electronics by image url(使用图片Url检测3C电器)

```C#
var request = new Detect3CElectronicsByImageUrlRequest
{
    Url = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
    Loc = "0-0-1-1"//optional
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```

## 交通工具检测与定位(detect_vehicle)
### * detect_vehicle by local image file(使用本地图片文件检测交通工具)

```C#
var request = new DetectVehicleByImageFileRequest
{
    ImageFile = new System.IO.FileInfo(@".\phone.jpg"),
    Loc = "0-0-1-1"//optional
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```

### * detect_vehicle by image url(使用图片Url检测交通工具)
```C#
var request = new DetectVehicleByImageUrlRequest
{
    Url = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
    Loc = "0-0-1-1"//optional
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```

## 宠物检测与定位(detect_pet)
### * detect_pet by local image file(使用本地图片文件检测宠物)

```C#
var request = new DetectPetByImageFileRequest
{
    ImageFile = new System.IO.FileInfo(@".\phone.jpg"),
    Loc = "0-0-1-1"//optional
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```
### * detect_pet by image url(使用图片Url检测宠物)

```C#
var request = new DetectPetByImageUrlRequest
{
    Url = "http://www.softsew.com/images/Moved%20from%20Main/More_Clothes.jpg",
    Loc = "0-0-1-1"//optional
};
var response = client.Execute(request);
if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    foreach (var r in response.DetectedBoxes)
    {
        Console.WriteLine("{0}\t{1}", r.Type, r.Score);
    }
}
```
