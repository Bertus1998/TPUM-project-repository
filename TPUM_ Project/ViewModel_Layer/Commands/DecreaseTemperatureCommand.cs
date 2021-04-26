
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using ViewModel;

namespace ViewModel.Commands
{
    public class DecreaseTemperatureCommand : BaseCommand
    {
       
        protected MainWindowViewModel mainWindowViewModel;
      

        public override void  Execute(object parameter)
        {
            mainWindowViewModel.model.decreaseTemp();
        }
        public DecreaseTemperatureCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

    }
}
