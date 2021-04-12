using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.View_Model
{
    class MainWindowViewModel
    {
       public MainWindowViewModel()
        {
            this.motherStation = new MotherStation();
        }
        private MotherStation motherStation;
        public MotherStation MotherStation
        {
            get { return motherStation; }
            set { motherStation = value; }
        }
    }
}
