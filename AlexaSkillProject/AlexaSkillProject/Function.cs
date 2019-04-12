using System.Net.Http;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using AlexaSkillProject;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LambdaAlexa
{
    public class Function
    {
        
       static void Main(string[] args)
        {
            collegelist[] col = new collegelist[9];
            {
                col[0].college = "University of Oklahoma";
                col[0].collegetown = "Norman";
                col[0].collegepopulation = 10000000;
                col[0].mascot = "Boomer";

                col[1].college = "University of Oklahoma";
                col[1].collegetown = "Norman";
                col[1].collegepopulation = 10000000;
                col[1].mascot = "Boomer";

                col[2].college = "University of Oklahoma";
                col[2].collegetown = "Norman";
                col[2].collegepopulation = 10000000;
                col[2].mascot = "Boomer";

                col[3].college = "University of Oklahoma";
                col[3].collegetown = "Norman";
                col[3].collegepopulation = 10000000;
                col[3].mascot = "Boomer";

                col[4].college = "University of Oklahoma";
                col[4].collegetown = "Norman";
                col[4].collegepopulation = 10000000;
                col[4].mascot = "Boomer";

                col[5].college = "University of Oklahoma";
                col[5].collegetown = "Norman";
                col[5].collegepopulation = 10000000;
                col[5].mascot = "Boomer";
            }
            

        }


        //EXAMPLE stuff
        public string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
            

            
        }
    }
}
