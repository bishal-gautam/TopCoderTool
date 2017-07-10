using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public class TopCoderUnitOfWork: IDisposable
    {
        private TopCoderContext _context;
        private ITopcoderDataRepository _topcoderDataRepository;
        private ITopcoderUserRepository _topcoderUserRepository;

        public TopCoderUnitOfWork(TopCoderContext context)
        {
            _context = context;
            _topcoderDataRepository = new TopcoderDataRepository(_context);
            _topcoderUserRepository = new TopcoderUserRepository(_context);
        }

        public ITopcoderDataRepository TopcoderDataRepository
        {
            get
            {
                return _topcoderDataRepository;
            }
        }

        public ITopcoderUserRepository TopcoderUserRepository
        {
            get
            {
                return _topcoderUserRepository;
            }
        }

       public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
