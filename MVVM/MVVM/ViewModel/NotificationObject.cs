using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVM.ViewModel
{
    class NotificationObject:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname) 
        {
            if (this.PropertyChanged != null) 
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
