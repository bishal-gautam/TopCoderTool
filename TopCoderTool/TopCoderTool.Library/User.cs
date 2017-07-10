using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Library
{
    public class User : Entity
    {
        public int rank { get; set; }
        public string handle { get; set; }
        public int rating { get; set; }
        public string country { get; set; }
    }
}
