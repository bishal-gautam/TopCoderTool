using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Library
{
    public class RequesterInformation :Entity
    {
        public string id { get; set; }
        public string remoteIP { get; set; }
        public ReceivedParams receivedParams { get; set; }
    }
}
