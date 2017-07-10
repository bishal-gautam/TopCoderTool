using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopCoderTool.Library;
using TopCoderTool.Library.Data;

namespace TopCoderTool.Models
{
    public class TopUserViewModel
    {
        private TopCoderUnitOfWork _unitOfWork;
        public TopUserViewModel()
        {
            _unitOfWork = new TopCoderUnitOfWork( new TopCoderContext() );
        }

        public List<User> topUsers;
        public void GetTopUsers()
        {
            topUsers = new List<User>();
            topUsers = _unitOfWork.TopcoderUserRepository.GetAll().ToList();
        }
    }
}