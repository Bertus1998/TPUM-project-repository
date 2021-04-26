using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Commands;

namespace ViewModel.Commands
{
    class NextStationCommand: BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public override void Execute(object parameter)
        {
            this.mainWindowViewModel.model.nextStation();
        }
       public NextStationCommand(MainWindowViewModel windowViewModel)
        {
            this.mainWindowViewModel = windowViewModel;
        }
    }
}
