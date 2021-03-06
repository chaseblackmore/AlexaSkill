using System.Collections.Generic;
using System.Linq;
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
        


        
        public async Task<SkillResponse> FunctionHandler(SkillRequest input, ILambdaContext context)
        { 
          //  SkillResponse x = await FunctionHandler(input, context); FROM the "Usage" part of the error above, still did not help
            var request = input.GetRequestType();
            var output = string.Empty;
            if (request == typeof(IntentRequest))
            {
                var intentRequest = input.Request as IntentRequest;
                var collegeRequested = intentRequest?.Intent?.Slots["college"].Value;
                if (collegeRequested == null)
                {
                    context.Logger.LogLine($"The college requested was not understood");
                    return MakeSkillResponse("IM sorry but i didnt understand which college you asked for. Please try again", false);

                }
                var collegeinfo = await GetCollegeinfo(collegeRequested, context);
                output = $"{collegeinfo.college} the {collegeinfo.mascot} are located in {collegeinfo.collegetown} with {collegeinfo.collegepopulation} students ";

                return MakeSkillResponse(output, true);

                
                
                    
                

            }
            //hey adam
            //The code below is commented out because we did not want to delete it, it might be useful to resolving problems
            //    var intent = input.Request as IntentRequest;
            //    if (intent.Intent.Name.Equals("CollegeIntent"))
            //    {
            //        var collegerequested = intent.Intent.Slots["college"].Value;


            //        if (collegerequested == null)
            //        {
            //            return MakeSkillResponse("I dont understand", false);
            //        }

            //        //var collegeinfo = await GetCollegeinfo(collegerequested,context);'
            //        //var collegeinfo = await GetCollegeinfo(collegerequested, context);

            //        var collegeinfo = await GetCollegeinfo(collegeName, context);
            //        {
            //            // output=$"{}";
            //        }
            //    }
            //}
            //else if(request == typeof(IntentRequest))
            //{
            //}
                //var intent = input.Request as IntentRequest;
                //var collegerequest = intent.Intent.Slots["College"].Value;

                //if (collegerequest == null)
                //{
                //    context.Logger.LogLine($"The college request was not understood");
                //    return MakeSkillResponse("Im sorry, but i didnt understand the college you asked for", false);
                //}
                //// var collegeinfo = GetCollegeInfo(collegerequest, context); 
                //var collegeinfo = GetCollegeInfo(collegerequest, context);  //get college list instead??
                //{
                //    output = $"{collegeinfo.college} the {collegeinfo.mascot} is located in {collegeinfo.collegetown} with a population of {collegeinfo.collegepopulation} students";
                //}
                // var outputtext = $"{collegeinfo.college} the {collegeinfo.mascot} is located in {collegeinfo.collegetown} with a population of {collegeinfo.collegepopulation} students";

                //return MakeSkillResponse(outputtext, true);
                //if (request == typeof(LaunchRequest))
                //{
                //    return MakeSkillResponse("Welcome, say the name of a college to get started",false);
                //}
                //var collegestuff = await GetCollegeInfo(collegerequest, context);
            

            
            
        }

        private SkillResponse MakeSkillResponse(string output, bool endsession, string prompt = "Just say, tell me about OU to learn more. To exit, say Exit")
        {
            var response = new ResponseBody
            {
                ShouldEndSession = endsession,
                OutputSpeech = new PlainTextOutputSpeech { Text = output }
            };
            if (prompt != null)
            {
                response.Reprompt = new Reprompt() { OutputSpeech = new PlainTextOutputSpeech() { Text = prompt } };
            }
            var skillresponse = new SkillResponse
            {
                Response = response,
                Version = "1.0"
            };
            return skillresponse;
        }
        
        public async Task<collegelist> GetCollegeinfo(string collegeName, ILambdaContext context) //now getting an error here ????? what
        {
            collegeName = collegeName.ToLowerInvariant();
            var colleges = new List<collegelist>();
           // var CollegeName = collegeName.ToLowerInvariant();
           
           collegelist coooo = await GetCollegeinfo(collegeName,context);
            collegelist collist = new collegelist();
            collegelist c1 = new collegelist()
            {
                college = "University of Oklahoma", //change
                collegetown = "Norman, Oklahoma",
                mascot = "Sooners",
                collegepopulation = 28527,
                
            };
            collegelist c2 = new collegelist()
            {
                college = "Baylor Univesity",
                collegetown = "Waco, Texas",
                mascot = "Bears",
                collegepopulation = 17059,

            };
            collegelist c3 = new collegelist()
            {
                college = "Kansas State Univesity",
                collegetown = "Manhattan, Kansas",
                mascot = "Wildcats",
                collegepopulation = 22795,

            };
            collegelist c4 = new collegelist()
            {
                college = "Iowa State University",
                collegetown = "Ames, Iowa",
                mascot = "Cyclones",
                collegepopulation = 36158,

            };
            collegelist c5 = new collegelist()
            {
                college = "Oklahoma State Univesity",
                collegetown = "Stillwater, Oklahoma",
                mascot = "Cowboys",
                collegepopulation = 25295,

            };
            collegelist c6 = new collegelist()
            {
                college = "Texas Christian University",
                collegetown = "Fort Worth, Texas",
                mascot = "Horned Frogs",
                collegepopulation = 10489,

            };
            collegelist c7 = new collegelist()
            {
                college = "Texas Tech University",
                collegetown = "Lubbock, Texas",
                mascot = "Red Raiders",
                collegepopulation = 36996,

            };
            collegelist c8 = new collegelist()
            {
                college = "Unversity of Kansas",
                collegetown = "Lawrence, Kansas",
                mascot = "Jayhawks",
                collegepopulation = 27625,

            };
            collegelist c9 = new collegelist()
            {
                college = "Univesity of Texas",
                collegetown = "Austin, Texas",
                mascot = "Longhorns",
                collegepopulation = 51525,

            };
            collegelist c10 = new collegelist()
            {
                college = "West Virginia University",
                collegetown = "Morgantown, West Virginia",
                mascot = "Mountaineers",
                collegepopulation = 28406,

            };
            List<collegelist> cols = new List<collegelist>();
            
            cols.Add(c1);
            cols.Add(c2);
            cols.Add(c3);
            cols.Add(c4);
            cols.Add(c5);
            cols.Add(c6);
            cols.Add(c7);
            cols.Add(c8);
            cols.Add(c9);
            cols.Add(c10);
            colleges.AddRange(cols);
           // var bestmatch = (from c in colleges where c.college.ToLowerInvariant() == collegeName select c).FirstOrDefault();
            
            
            return bestmatch; //not correct reutrn, just made something 

        }

        static void Main(string[] args)
        {
            //instead of mascot i put the team name, need to fix the population
            //collegelist[] col = new collegelist[9];
            //{
            //    col[0].college = "University of Oklahoma";
            //    col[0].collegetown = "Norman, Oklahoma";
            //    col[0].collegepopulation = 10000000;
            //    col[0].mascot = "Sooners";

            //    col[1].college = "Baylor University";
            //    col[1].collegetown = "Waco, Texas";
            //    col[1].collegepopulation = 10000000;
            //    col[1].mascot = "Bears";

            //    col[2].college = "Iowa State University";
            //    col[2].collegetown = "Ames, Iowa";
            //    col[2].collegepopulation = 10000000;
            //    col[2].mascot = "Cyclones";

            //    col[3].college = "Kansas State University";
            //    col[3].collegetown = "Manhattan, Kansas";
            //    col[3].collegepopulation = 10000000;
            //    col[3].mascot = "Wildcats";

            //    col[4].college = "Oklahoma State University";
            //    col[4].collegetown = "Stillwater, Oklahoma";
            //    col[4].collegepopulation = 10000000;
            //    col[4].mascot = "Cowboys";

            //    col[5].college = "Texas Christian University";
            //    col[5].collegetown = "Fort Worth, Texas";
            //    col[5].collegepopulation = 10000000;
            //    col[5].mascot = "Horned Frogs";


            //    col[6].college = "Texas Tech University";
            //    col[6].collegetown = "Lubbock, Texas";
            //    col[6].collegepopulation = 10000000;
            //    col[6].mascot = "Red Raiders";

            //    col[7].college = "University of Kansas";
            //    col[7].collegetown = "Lawrence, Kansas";
            //    col[7].collegepopulation = 10000000;
            //    col[7].mascot = "Jayhawks";

            //    col[8].college = "University of Texas";
            //    col[8].collegetown = "Austin, Texas";
            //    col[8].collegepopulation = 10000000;
            //    col[8].mascot = "Longhorns";

            //    col[9].college = "West Virginia University";
            //    col[9].collegetown = "Morgantown, West Virginia";
            //    col[9].collegepopulation = 10000000;
            //    col[9].mascot = "Mountaineers";
            //}

            //List<collegelist> cols = new List<collegelist>();
            //collegelist c1 = new collegelist()
            //{
            //    college = "OU",
            //    collegetown = "Norman",
            //    mascot = "sooners",
            //    collegepopulation = 1000000,
            //};
            //cols.Add(c1);
        }


        //EXAMPLE stuff
        private collegelist GetCollegelist(string college, string collegetown, string mascot, int collegepop ,ILambdaContext context)
        {
            //return $"{college}, the {mascot} are located in {collegetown} and have a population of {collegepop}";
        }

    }
}
