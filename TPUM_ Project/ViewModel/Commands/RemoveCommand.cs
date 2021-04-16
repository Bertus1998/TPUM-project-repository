
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace ViewModel.Commands
{
    public class RemoveCommand : BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public override void Execute(object parameter)
        {
            mainWindowViewModel.OnExecuteRemoveStation(parameter);
        }
        public RemoveCommand(MainWindowViewModel mainWindow)
        {
            this.mainWindowViewModel = mainWindow;
        }
    }
}
