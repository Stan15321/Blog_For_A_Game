﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog1.Models.Comments
{
    public class MainComment :Comment
    {
        public List<SubComment> SubComments { get; set; }
    }
}
