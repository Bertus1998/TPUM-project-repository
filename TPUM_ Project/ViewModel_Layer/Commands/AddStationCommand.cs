
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace ViewModel.Commands
{
     public class AddStationCommand : BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public AddStationCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }
        public override void Execute(object parameter)
        {
            mainWindowViewModel.model.addStation((String)parameter);
        }

       
    }
}
