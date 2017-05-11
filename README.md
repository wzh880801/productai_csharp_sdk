# .NET SDK for ProductAI
.NET SDK for ProductAI

`ProductAI`: 
<br>For more details about ProductAI, view [ProductAI offcial site](https://api-doc.productai.cn/doc/pai.html) [`https://api-doc.productai.cn/doc/pai.html`](https://api-doc.productai.cn/doc/pai.html)

# Usage:

```C#
	
	using System;
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
            	var request = new ImageContentAnalysisByImageUrlRequest
            	{
                	Url = "http://dimg3.s-9in.com/imageadapter/w220h220q80/stimg4.s-9in.com/www9incom/2016/10/25/db18a2d1-bf45-439b-950f-a5b21782b62c.jpg"
            	};
            	var response = client.Execute(request);
            	if(response.StatusCode == System.Net.HttpStatusCode.OK)
            	{
                	foreach(var r in response.Results)
                	{
                    	Console.WriteLine("{0}\t{1}", r.Category, r.Score);
                	}
            	}
            	Console.ReadLine();
        	}
    	}
	}
```

#Support async...

```C#

	var request = new ImageContentAnalysisByImageUrlRequest
	{
		Url = "http://dimg3.s-9in.com/imageadapter/w220h220q80/stimg4.s-9in.com/www9incom/2016/10/25/db18a2d1-bf45-439b-950f-a5b21782b62c.jpg"
	};
	var response = await client.ExecuteAsync(request);
```
