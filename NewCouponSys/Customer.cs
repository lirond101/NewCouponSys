using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class Customer : User
    {
        public string email { get; set; }
        public DateTime date_of_birth { get; set; }
        public CategoryType coupon_perferences { get; set; }

        public virtual City city { get; set; }
        public ICollection<Deal> deals { get; set; }
        public ICollection<CouponPromotionAlert> cpa { get; set; }
    }
}
