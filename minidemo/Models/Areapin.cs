using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minidemo.Models
{
    class Areapin
    {
        [Key]
        public int Aid { get; set; }
        public string pincode { get; set; }
        public string Aname { get; set; }
        public List<Provider> Providers { get; set; }
        public List<Customer> Customers { get; set; }

        public Areapin()
        {
            Providers = new List<Provider>();
            Customers = new List<Customer>();
        }
        
    }
}
