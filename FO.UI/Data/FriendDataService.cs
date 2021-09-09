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
            yield return new Friend { Firstname = "1sdfas", Lastname = "asdfasfd" };
            yield return new Friend { Firstname = "2sdfas", Lastname = "asdfasfd" };
            yield return new Friend { Firstname = "3sdfas", Lastname = "asdfasfd" };
            yield return new Friend { Firstname = "4sdfas", Lastname = "asdfasfd" };
            yield return new Friend { Firstname = "5sdfas", Lastname = "asdfasfd" };

        }
    }
}
