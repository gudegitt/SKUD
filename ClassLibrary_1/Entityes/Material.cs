﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_1.Entityes
{
    public class Material : Page
    {
        public int DirectoryId { get; set; }
        public Directory Directory { get; set; }
    }
}
