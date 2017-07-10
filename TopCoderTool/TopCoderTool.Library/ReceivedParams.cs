using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Library
{
    public class ReceivedParams: Entity
    {
        public string rankType { get; set; }
        public string pageIndex { get; set; }
        public string pageSize { get; set; }
        public string apiVersion { get; set; }
        public string action { get; set; }
    }
}
