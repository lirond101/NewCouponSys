using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewCouponSys;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1 : CouponContext, IDisposable
    {
        Coupon coupon;
        Deal deal;

        [TestMethod]
        public void TestCoupon()
        {
            using (var db = new CouponContext())
            {
                coupon = new Coupon();
                coupon.cName = "zoo";
                coupon.idCoupon = 123;
                coupon.description = "40% discount for safari";
                coupon.discount_price = 60;
                coupon.original_price = 100;
                coupon.period_for_use = DateTime.Today;
                coupon.purchase_deadline = DateTime.Today;
                coupon.rank = 5;

                db.s_Coupons.Add(coupon);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestDeal()
        {
            using (var db = new CouponContext())
            {
                deal = new Deal();
                deal.dealCode = "123ewq";
                deal.Customer_user_name = "eden";
                deal.expiration_date = DateTime.Today;
                deal.order_date = DateTime.Today;

                db.s_Deals.Add(deal);
                db.SaveChanges();
            }
        }
    }
}
