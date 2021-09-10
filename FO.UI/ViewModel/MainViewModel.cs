using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FO.Model;
using FO.UI.Data;
using System.Linq;

namespace FO.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        public ObservableCollection<Friend> Friends { get; set; }       

        public MainViewModel(IFriendDataService friendDataService)
        {
            _friendDataService = friendDataService;
            Friends = new ObservableCollection<Friend>();
            Friends.CollectionChanged += Friends_CollectionChanged;         
        }

        private void Friends_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {          
           
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
      
        public Friend SelectedFriend
        {
            get
            {
                return _selectedFriend;
            }
            set
            {
                _selectedFriend = value;            
                OnPropertyChagned();
            }
        }
    }
} 