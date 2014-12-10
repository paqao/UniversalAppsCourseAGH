using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager
{
    public abstract class ViewModel<T> : INotifyPropertyChanged
    {
        public T InnerObject { get; private set; }

        public ViewModel(T innerObject)
        {
            if (innerObject == null)
                throw new ArgumentNullException();
            InnerObject = innerObject;
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
