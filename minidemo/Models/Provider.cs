using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minidemo.Models
{
    class Provider
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pmobile { get; set; }
        public int Availquantity { get; set; }
        public Areapin Areapin { get; set; }
    }
}
