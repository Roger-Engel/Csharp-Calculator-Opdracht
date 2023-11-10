using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator.Core
{
    
      public class CalculationResult
      {
          internal decimal Result { get; set; }
          internal bool Succeeded { get; set; }
          internal string ErrorMessage { get; set; }
      }
    
}
