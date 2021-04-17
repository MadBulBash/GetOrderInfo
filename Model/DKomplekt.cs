using System.Collections.Generic;

namespace GetOrderInfo.Model
{
    class Komplekt
    {
        public string data_type { get; set; }
        public int state { get; set; }
        public string wmscode { get; set; }
        public string grpcode { get; set; }
    }
    class DKomplekts
    {
        public List<Komplekt> d { get; set; }
    }
}
