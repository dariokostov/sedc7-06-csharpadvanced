﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    partial class Company
    {
        //info part 2
        public List<string> Products { get; set; }
        public double Revenue { get; set; }
        public int NumberOfEmploees { get; set; }         
    }
}
