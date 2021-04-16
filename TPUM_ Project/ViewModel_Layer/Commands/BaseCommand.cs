
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace ViewModel.Commands
{
    public abstract class BaseCommand : ICommand
    {
        MainWindowViewModel mainWindowViewModel;
        public event EventHandler CanExecuteChanged;
        public  bool CanExecute(object parameter)
        {
            return true;
        }
        public abstract void Execute(object parameter);
        
      
    }
}
