
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewModel;

namespace ViewModel.Commands
{
    public class IncreaseMaxTemp : BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public override void Execute(object parameter)
        {
            mainWindowViewModel.model.increaseMaxTemp();
        }
        public IncreaseMaxTemp(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }
    }
}
