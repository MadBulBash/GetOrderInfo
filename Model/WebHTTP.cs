using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace GetOrderInfo.Model
{
    static class WebHTTP
    {
        public static string SendGet(string url)
        {
            WebRequest request;
            string respStr;
            request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            try
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                        respStr = reader.ReadToEnd();
                }
                response.Close();
            }
            catch (WebException webExcp)
            {
                return(webExcp.Message);
            }
            return (respStr);
        }


        public static string getStrOrder(string addr)
        {
            return (@"http://" + addr + @"/api/tss/assembly-order/");
        }

        public static string getStrId(string addr)
        {
            return (@"http://" + addr + @"/api/auth");
        }
        public static string getStrInfoBox(string addr, string id)
        {
            return (@"http://" + addr + id);
        }

    }
}
