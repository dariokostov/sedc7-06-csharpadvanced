﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Company
    {
        //info part 1
        public string Name { get; set; }
        public string Industry { get; set; }
        public int Founded { get; set; }
        public string Headquarters { get; set; }

        //See this method in Company3.cs
        partial void PrintInfo();
        public void Info()
        {
            PrintInfo();
        }
    }
}
