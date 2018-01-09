using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public abstract class CodeFellows
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
     
        public string CodeOfConduct()
        {
            string phrase = "Be good plz";
            return phrase;
        }
    }
}
