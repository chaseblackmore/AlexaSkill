using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AlexaSkillProject
{
    class collegelist
    {

        public string college { get; set; }
        public string collegetown { get; set; }
        public int collegepopulation { get; set; }
        public string mascot { get; set; }

        
        public collegelist()
        {
            college = string.Empty;
            collegetown = string.Empty;
            collegepopulation = 0;
            mascot = string.Empty;

        }

        public collegelist(string Col, string Coltown, int ColPop, string Mascoot)
        {
            Col = college;
            Coltown = collegetown;
            ColPop = collegepopulation;
            mascot = Mascoot;
        }

        public override string ToString()
        {
            var outputtextreturn= $"{college} the {mascot} is located in {collegetown} with a population of {collegepopulation} students";
            return outputtextreturn;
        }







    }
    
}
