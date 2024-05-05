using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAppMaui.ViewModels
{
    internal class RemoveNoteVM
    {
        public int Index { get; set; }
        public string Title { get; set; } = "";
        public string Detail { get; set; } = "";
    }
}
