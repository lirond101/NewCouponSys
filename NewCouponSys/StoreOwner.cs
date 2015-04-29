using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class StoreOwner : User
    {
        public string email { get; set; }

        public ICollection<Store> stores { get; set; }
    }
}