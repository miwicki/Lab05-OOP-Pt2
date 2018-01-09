using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{

    abstract class People : CodeFellows
    {
        public byte Id { get; set; }
        public string Name { get; set; }
                
        public virtual int Experience { get; set; }
    }
}