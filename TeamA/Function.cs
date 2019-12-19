using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace TeamA
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input,ILambdaContext context)
        {
            context.Logger.Log("Team A Message received");
            context.Logger.Log("Received body:" + input.Body);
            var request = JsonConvert.DeserializeObject<dynamic>(input.Body);
            decimal calculatedResult = new Calculator().GetResult((string)request.problem);
            Thread.Sleep(60000);
            return new APIGatewayProxyResponse()
            {
                Body = "{\"result\":" + calculatedResult + "}",
                StatusCode = 500
            };


            
        }
    }
}
