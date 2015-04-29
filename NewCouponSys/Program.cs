using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCouponSys
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CouponContext())
            {

                Console.Write("enter name of new coupon: ");
                Store store = new Store();
                store.name = "danaStore";
                var name5 = Console.ReadLine();
                var coupon = new Coupon { cName = name5, purchase_deadline = DateTime.Now, period_for_use = DateTime.Now  };
                db.s_Coupons.Add(coupon);
                db.SaveChanges();

                var query = from c in db.s_Coupons
                            orderby c.cName
                            select c;

                foreach (var item in query)
                {
                    Console.WriteLine(item.cName);
                    Console.ReadLine();
                }
            }
        }
    }
}
