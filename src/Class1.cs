using System;
using Newtonsoft.Json;
using Amazon.Lambda.Core;


[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace MyLambda
{
    public class Class1
    {
    	public object MyFunction()
    	{
    		return new { status = "OK" };
    	}
    }
}
