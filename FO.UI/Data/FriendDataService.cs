using FO.DA;
using FO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FO.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            using (var ctx = new FO_DBContext())
            {
                return ctx.Friends.AsNoTracking().ToList();
            }

        }
    }
}
