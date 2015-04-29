using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCoupon { get; set; }
        public string cName { get; set; }
        public string description { get; set; }
        public double original_price { get; set; }
        public double discount_price { get; set; }
        public System.DateTime purchase_deadline { get; set; }
        public System.DateTime period_for_use { get; set; }
        public int rank { get; set; }

        public virtual ICollection<CouponPromotionAlert> CouponPromotionAlerts { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
