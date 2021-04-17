using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOrderInfo.Model
{
    public class Info
    {
        public int id { get; set; }
        public string data_type { get; set; }
        public string grpcode { get; set; }
        public string wmscode { get; set; }

    }
    public class InfoLevelBox : Info
    {
        public List<string> childes { get; set; }
    }
    public class InfoLevelBoxDetail : Info
    {
          public string child { get; set; }
          public int child_count { get; set; }

        public InfoLevelBoxDetail (int i, string d, string g, string w, string c, int cc)
        {
            id = i;
            data_type = d;
            grpcode = g;
            wmscode = w;
            child = c;
            child_count = cc;
        }
    }
    
    

}
