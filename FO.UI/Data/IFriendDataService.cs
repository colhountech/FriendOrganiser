using FO.Model;
using System.Collections.Generic;

namespace FO.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}