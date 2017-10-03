using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models.Annotations
{
    [AttributeUsage(AttributeTargets.Property |
  AttributeTargets.Field, AllowMultiple = false)]
    sealed public class LimitNumWords : ValidationAttribute
    {
        public int _n { get; set; }
        public LimitNumWords(int n)
        {
            _n = n;
        }
        public override bool IsValid(object value)
        {
            bool result = true;
            string name = (string)value;
            // Add validation logic here.
            char[] delims = { ' ' };
            if (name.Split(delims).Length > _n)
            {
                ErrorMessage = $"The number of words cannot exceed {_n}";
                return false;
            }
            return result;

    }

    }

    public class CustomAnnotations
    {

    }
}