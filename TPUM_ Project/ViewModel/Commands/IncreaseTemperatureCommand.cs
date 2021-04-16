
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace ViewModel.Commands
{
    public class IncreaseTemperatureCommand : BaseCommand
    {
        
        MainWindowViewModel mainWindowViewModel;
       

        public override void Execute(object parameter)
        {
            mainWindowViewModel.OnExecuteIncrease(parameter);
        }
       public  IncreaseTemperatureCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }
    }
}
