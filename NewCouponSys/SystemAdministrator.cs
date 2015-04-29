using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCouponSys
{
    public class SystemAdministrator : User
    {
        public string employee_id { get; set; }

        public ICollection<Store> stores { get; set; }
    }
}
