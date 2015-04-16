using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommandTest20150416.Pages.CreateCommands
{
    /// <summary>
    /// Interaction logic for Programe.xaml
    /// </summary>
    public partial class Programe : UserControl
    {
        public Programe()
        {
            InitializeComponent();
            InitiallizeCommand();
        }

        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(Code));

        private void InitiallizeCommand()
        {
            this.btn1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            this.btn1.CommandTarget = this.tb;

            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecult);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Execult);

            this.stk1.CommandBindings.Add(cb);
        }

        void cb_CanExecult(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb.Text)) { e.CanExecute = false; }
            else { e.CanExecute = true; e.Handled = true; }
        }

        void cb_Execult(object sender, ExecutedRoutedEventArgs e)
        {
            this.tb.Clear();
            e.Handled = true;
        }
    }
}
