using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewCouponSys
{
    public class CouponContext : DbContext
    {
        
        public DbSet<User> s_Users { get; set; }
        public DbSet<Customer> s_Customers { get; set; }
        public DbSet<SystemAdministrator> s_SA { get; set; }
        public DbSet<StoreOwner> s_owners { get; set; }
        public DbSet<Coupon> s_Coupons { get; set; }
        public DbSet<Store> s_Stores { get; set; }
        public DbSet<City> s_Cities { get; set; }
        public DbSet<CouponPromotionAlert> s_Cpa { get; set; }
        public DbSet<Deal> s_Deals { get; set; }
    }
}
