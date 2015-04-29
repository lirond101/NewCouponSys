using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewCouponSys;

namespace UnitTestCoupon
{
    [TestClass]
    public class UnitTestCoupon : CouponContext
    {
        Coupon coupon;
        Deal deal;

        [TestInitialize]
        public void TestAddCoupon()
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
            }
        }
}

        [TestMethod]
        public void TestAddDeal()
        {
            using (var db = new CouponContext())
            {
                Customer customer = new Customer();
                customer.user_name = "eden";
                db.s_Customers.Add(customer);

                deal = new Deal();
                deal.dealCode = "123qwe";
                deal.Coupon_idCoupon = 123;
                deal.Customer_user_name = "eden";
                deal.order_date = DateTime.Today;
                deal.status = 1;
                deal.expiration_date = DateTime.Today;
                deal.user_rank = 3;
            }
        }
    }
}
