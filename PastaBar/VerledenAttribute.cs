using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PastaBar
{
    public class VerledenAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (!(value is DateTime))
                return false;
            return ((DateTime)value) < DateTime.Today;
        }
    }
}
