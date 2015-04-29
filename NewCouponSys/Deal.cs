using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class Deal
    {
        [Key]
        public string dealCode { get; set; }
        public System.DateTime order_date { get; set; }
        public int status { get; set; }
        public int user_rank { get; set; }
        public int serial_key { get; set; }
        public System.DateTime expiration_date { get; set; }
        public Nullable<int> Coupon_idCoupon { get; set; }
        public string Customer_user_name { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual User User { get; set; }
    }
}
