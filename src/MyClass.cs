using System;
using Newtonsoft.Json;
using Amazon.Lambda.Core;


[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace MyNamespace
{
    public class MyClass
    {
    	public object MyFunction()
    	{
    		return new { status = "OK", time = DateTime.UtcNow };
    	}
    }
}
