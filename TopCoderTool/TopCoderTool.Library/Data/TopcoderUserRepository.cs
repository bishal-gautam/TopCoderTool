using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public class TopcoderUserRepository : GenericRepository<User>, ITopcoderUserRepository
    {
        private TopCoderContext _context;

        public TopcoderUserRepository(TopCoderContext context)
            : base(context)
        {
            // TODO: Complete member initialization
            _context = context;
        }
        public IEnumerable<User> GetTopUsers()
        {
            return _context.User.Take(50);
        }
    }
}
