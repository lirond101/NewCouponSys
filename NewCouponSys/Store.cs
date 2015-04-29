using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class Store
    {
        [Key]
        public string name { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public int store_category { get; set; }
        public int rank { get; set; }
        public int phone_num { get; set; }
        public int store_rank { get; set; }

        public virtual ICollection<City> cities { get; set; }
        public virtual StoreOwner so { get; set; }
        public virtual SystemAdministrator sa { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
