using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    internal class Students : People
    {
        public String DateOfBirth { get; set; }
        public String[] Hobbies { get; set; }
        

        public string Goals()
        {
            return "I want to be a dev when I grow up";
        }
    }
}
