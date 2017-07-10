using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public interface ITopcoderUserRepository : IGenericRepository<User>
    {
        IEnumerable<User> GetTopUsers();
    }
}