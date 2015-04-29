using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class CouponPromotionAlert
    {
        [Key]
        public System.DateTime alertTime { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
