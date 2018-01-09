using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    internal class TeacherAssistant : Staff

    {
        public bool Graduate { get; set; }
        public override int Experience => 1;
    }
}