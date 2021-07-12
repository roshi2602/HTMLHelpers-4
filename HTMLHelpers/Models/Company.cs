using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class Company
    {
        public string Cname { get; set; }
        /// <summary>
        /// taking Department list as property here
        /// </summary>
        public List<Department> Departments
        {
            get
            {
                List<Department> dd = new List<Department>()
            {
                new Department(){did=1, dname="physics"},
                 new Department(){did=2, dname="chemistry"},
                  new Department(){did=3, dname="maths"},
            };
                return dd;
            }
        }
    }
}