using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARF.Models
{
   public class Country
    {
      public string id { get; set; }
      public string alpha2Code { get; set; }    //used as Country Code     
      public string name { get; set; }
      public string language { get; set; }
      public string currency { get; set; }

    }
}
