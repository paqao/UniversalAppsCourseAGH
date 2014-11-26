using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClientManager.Annotations;

namespace ClientManager
{
     public  class UserViewModel : INotifyPropertyChanged
    {
         private User _user;
         public event PropertyChangedEventHandler PropertyChanged;

         [NotifyPropertyChangedInvocator]
         protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
         {
             PropertyChangedEventHandler handler = PropertyChanged;
             if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
         }

         public UserViewModel(User user)
         {
             this._user = user;
             MyCommand = new MyCommand(this);
         }

         public string FirstName
         {
             get
             {
                 if (_user == null)
                     return String.Empty;

                 return _user.FirstName;
             }
             set
             {
                 if(_user == null)
                     return;

                 if (value != _user.FirstName)
                 {
                     _user.FirstName = value;
                     OnPropertyChanged("FirstName");
                     OnPropertyChanged("Name");
                 }
             }
         }

         public string LastName
         {
             get
             {
                 if (_user == null)
                     return String.Empty;

                 return _user.LastName;
             }
             set { _user.LastName = value; }
         }

         public string Name
         {
             get { return _user.FirstName + " " + _user.LastName; }
         }

         public ICommand MyCommand { get; set; }
    }
}
