using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoRoux.ContactUs.Domain
{
    class PastDateRangeAttribute : RangeAttribute
    {
        public PastDateRangeAttribute(int minimumPastYears, int maximumPastYears)
               : base(typeof(DateTime),  DateTime.Now.AddYears(-maximumPastYears).ToString(), DateTime.Now.AddYears(-minimumPastYears).ToString()) 
        { }
    }
}
