﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class test1
    {
        [Key]
        public int Id { get; set; }
        private string name { get; set; }
    }
}
