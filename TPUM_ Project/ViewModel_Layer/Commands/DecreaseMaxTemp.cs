
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewModel;

namespace ViewModel.Commands
{
    public class DecreaseMaxTemp : BaseCommand
    {
        MainWindowViewModel mainWindowViewModel;
        public override void Execute(object parameter)
        {
            mainWindowViewModel.OnExecuteDecreaseMax();
        }
       public DecreaseMaxTemp(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }
    }
}
