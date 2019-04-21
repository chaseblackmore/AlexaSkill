using System.Net.Http;
using System.Threading.Tasks;
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
            //instead of mascot i put the team name, need to fix the population
            collegelist[] col = new collegelist[9];
            {
                col[0].college = "University of Oklahoma";
                col[0].collegetown = "Norman, Oklahoma";
                col[0].collegepopulation = 10000000;
                col[0].mascot = "Sooners";

                col[1].college = "Baylor University";
                col[1].collegetown = "Waco, Texas";
                col[1].collegepopulation = 10000000;
                col[1].mascot = "Bears";

                col[2].college = "Iowa State University";
                col[2].collegetown = "Ames, Iowa";
                col[2].collegepopulation = 10000000;
                col[2].mascot = "Cyclones";

                col[3].college = "Kansas State University";
                col[3].collegetown = "Manhattan, Kansas";
                col[3].collegepopulation = 10000000;
                col[3].mascot = "Wildcats";

                col[4].college = "Oklahoma State University";
                col[4].collegetown = "Stillwater, Oklahoma";
                col[4].collegepopulation = 10000000;
                col[4].mascot = "Cowboys";

                col[5].college = "Texas Christian University";
                col[5].collegetown = "Fort Worth, Texas";
                col[5].collegepopulation = 10000000;
                col[5].mascot = "Horned Frogs";


                col[6].college = "Texas Tech University";
                col[6].collegetown = "Lubbock, Texas";
                col[6].collegepopulation = 10000000;
                col[6].mascot = "Red Raiders";

                col[7].college = "University of Kansas";
                col[7].collegetown = "Lawrence, Kansas";
                col[7].collegepopulation = 10000000;
                col[7].mascot = "Jayhawks";

                col[8].college = "University of Texas";
                col[8].collegetown = "Austin, Texas";
                col[8].collegepopulation = 10000000;
                col[8].mascot = "Longhorns";

                col[9].college = "West Virginia University";
                col[9].collegetown = "Morgantown, West Virginia";
                col[9].collegepopulation = 10000000;
                col[9].mascot = "Mountaineers";
            }
            

        }


        //EXAMPLE stuff
        private collegelist GetCollegelist(string college, string collegetown, string mascot, int collegepop ,ILambdaContext context)
        {
            //return $"{college}, the {mascot} are located in {collegetown} and have a population of {collegepop}";
        }

    }
}
