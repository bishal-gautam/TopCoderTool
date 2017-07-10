using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public class TopcoderDataRepository: GenericRepository<TopcoderData>, ITopcoderDataRepository
    {
        private TopCoderContext _context;

        public TopcoderDataRepository(TopCoderContext context)
            :base(context)
        {
            // TODO: Complete member initialization
            _context = context;
        }
        public IEnumerable<TopcoderData> GetData()
        {
            return _context.TopcoderData.Take(10);
        }
    }
}
