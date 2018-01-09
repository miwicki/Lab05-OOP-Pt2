using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{

    abstract class Courses : CodeFellows
    {
        public byte Code { get; set; }
        public int Cost { get; set; }
        public int Length { get; set; }

    }
}