using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using ViewModel.Commands;

namespace ViewModel.Commands
{
    class PreviousStationCommand : BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public override void Execute(object parameter)
        {
            this.mainWindowViewModel.model.previousStation();
        }
       public PreviousStationCommand(MainWindowViewModel windowViewModel)
        {
            this.mainWindowViewModel = windowViewModel;
        }
    }
}
