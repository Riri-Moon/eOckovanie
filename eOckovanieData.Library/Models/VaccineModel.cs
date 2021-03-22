using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOckovanieData.Library.Models
{
    public class VaccineModel
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public int EffectiveFor { get; set; }
    }
}
