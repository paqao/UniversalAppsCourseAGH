using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ClientManager
{
    class MyCommand : ICommand
    {
        private UserViewModel _usr;

        public MyCommand(UserViewModel usr)
        {
            this._usr = usr;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show(_usr.FirstName, _usr.LastName);
        }

        public event EventHandler CanExecuteChanged;
    }
}
