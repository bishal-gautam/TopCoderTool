using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Library
{
    public class TopcoderData : Entity
    {
        public int total { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public List<User> data { get; set; }
        public ServerInformation serverInformation { get; set; }
    }
}
