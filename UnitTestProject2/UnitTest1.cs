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
        Customer customer;
        Store store;
        City city;

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
                //deal.Customer_user_name = "eden";
                deal.expiration_date = DateTime.Today;
                deal.order_date = DateTime.Today;

                db.s_Deals.Add(deal);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestCustomer()
        {
            using (var db = new CouponContext())
            {
                customer = new Customer();
                customer.email = "eden101@gmail.com";
                customer.user_name = "eden101";
                customer.first_name = "eden";
                customer.last_name = "yaakobi";
                customer.password = "ey123";
                customer.phone = "0528757474";
                customer.date_of_birth = DateTime.Now;

                db.s_Customers.Add(customer);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestStore()
        {
            using (var db = new CouponContext())
            {
                store = new Store();
                store.name = "safari";
                store.description = "the biggest zoo in meadle east";
                store.phone_num = 4300;
                store.rank = 7;
                //store.so.user_name = "zoomer";

                db.s_Stores.Add(store);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestCity()
        {
            using (var db = new CouponContext())
            {
                city = new City();
                city.name = "Tel Aviv";

                db.s_Cities.Add(city);
                db.SaveChanges();
            }
        }
    }
}
