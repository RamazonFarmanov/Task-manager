using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAppMaui.Models;


namespace TextAppMaui.ViewModels
{
    class MainVM
    {
        public static NoteMainVM vm; 
        public MainVM(DBController dBController) 
        {
            if (vm == null) vm = new NoteMainVM(dBController);
        }
    }
}
