﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minidemo.Models
{
    class Order
    {
        [Key]
        public int Oid { get; set; }

        public Customer Customer { get; set; }
        
    }
}
