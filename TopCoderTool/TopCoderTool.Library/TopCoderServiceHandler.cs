using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library
{
    public class TopCoderServiceHandler
    {
        private const string _apiUrl="http://api.topcoder.com/v2/data/srm/statistics/tops?rankType=Competitors";
        public TopcoderData GetTopcoderData()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_apiUrl);
            request.Timeout = 100000;
            request.Method = "GET";
            request.ContentType = "application/json";
            TopcoderData tmp = new TopcoderData();
            try
            {
                using( var res=(HttpWebResponse)request.GetResponse())
                {
                    using( var stream = res.GetResponseStream())
                    {
                        var reader = new StreamReader(stream);
                        var response = reader.ReadToEnd();
                        tmp = JsonConvert.DeserializeObject<TopcoderData>(response);
                        return tmp;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}
