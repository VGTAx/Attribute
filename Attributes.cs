using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public sealed class CheckAgeAttribute : Attribute
    {
        public int Age { get; set; }
        public CheckAgeAttribute(int age)
        {
            Age = age;
        }
        public CheckAgeAttribute() { }
    }
   
    public sealed class CheckLengthLoginPasswordAttribute : Attribute
    {
        public int Length { get; set; }
        public CheckLengthLoginPasswordAttribute(int length)
        {
            Length = length;
        }
        public CheckLengthLoginPasswordAttribute() { }
    }
    
    
  
}
