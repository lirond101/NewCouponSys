using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCouponSys
{
    public class City
    {
        [Key]
        public string name { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
