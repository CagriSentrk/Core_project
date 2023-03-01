using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        //Include methodu ile birbirine bağlı iki tablodan aynı ındex üzerinde veri çekebileceğim.
        public List<UserMessage> GettUserMessagesWithUser()
        {
            using (var c=new Context())
            {
                return c.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
