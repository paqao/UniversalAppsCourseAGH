using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientManager
{
     public  class UserViewModel : ViewModel<User>
     {
         public UserViewModel(User user) : base(user)
         {
             MyCommand = new MyCommand(this);
         }

         public string FirstName
         {
             get
             {
                 if (InnerObject == null)
                     return String.Empty;

                 return InnerObject.FirstName;
             }
             set
             {
                 if(InnerObject == null)
                     return;

                 if (value != InnerObject.FirstName)
                 {
                     InnerObject.FirstName = value;
                     OnPropertyChanged("FirstName");
                     OnPropertyChanged("Name");
                 }
             }
         }

         public string LastName
         {
             get
             {
                 if (InnerObject == null)
                     return String.Empty;

                 return InnerObject.LastName;
             }
             set
             {
                 InnerObject.LastName = value;
                 OnPropertyChanged("LastName");
                 OnPropertyChanged("Name");
             }
         }

         public string Name
         {
             get { return InnerObject.FirstName + " " + InnerObject.LastName; }
         }

         public ICommand MyCommand { get; set; }
    }
}
