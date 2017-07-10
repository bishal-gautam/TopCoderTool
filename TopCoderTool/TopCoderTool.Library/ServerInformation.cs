using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Library
{
    public class ServerInformation :Entity
    {
        public string serverName { get; set; }
        public string apiVersion { get; set; }
        public int requestDuration { get; set; }
        public long currentTime { get; set; }
    }

}
