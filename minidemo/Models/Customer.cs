using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minidemo.Models
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Caddress { get; set; }
        public string Cphone { get; set; }
        public List<Order> Orders { get; set; }
        public Areapin areapin { get; set; }
       
    }
}
