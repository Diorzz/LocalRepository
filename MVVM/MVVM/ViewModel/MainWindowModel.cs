using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModel
{
    class MainWindowModel:NotificationObject
    {
        public MainWindowModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(this.Add);
        }
        private double value1;
        private double value2;
        private double result;

        public double Value1 
        {
            get { return value1; }
            set 
            {
                value1 = value;
                this.RaisePropertyChanged("Value1");
            }
        }
        public double Value2
        {
            get { return value2; }
            set
            {
                value2 = value;
                this.RaisePropertyChanged("Value2");
            }
        }

        public double Result 
        {
            get { return result; }
            set 
            {
                result = value;
                this.RaisePropertyChanged("Result");
            }
        }



        public DelegateCommand AddCommand{ get; set; }

        private void Add(object parameter) 
        {
            this.Result = this.Value1 + this.Value2;
        }
    }
}
