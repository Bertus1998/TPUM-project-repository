using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    interface IBook 
    {
        bool checkStatus();
        bool changeStatus();
    }
}
