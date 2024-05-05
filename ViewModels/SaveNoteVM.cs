using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TextAppMaui.Models;

namespace TextAppMaui.ViewModels
{
    class SaveNoteVM : INotifyPropertyChanged
    {
        Note note = new Note();
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Title
        {
            get => note.Title;
            set
            {
                if(value != note.Title)
                {
                    note.Title = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Detail
        {
            get => note.Detail;
            set
            {
                if (value != note.Detail)
                {
                    note.Detail = value;
                    OnPropertyChanged();
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
