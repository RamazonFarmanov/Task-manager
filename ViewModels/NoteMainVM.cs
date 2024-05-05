using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TextAppMaui.Models;
using TextAppMaui.Views;

namespace TextAppMaui.ViewModels
{
    partial class NoteMainVM : ObservableObject
    {
        private DBController _dbController;
        [ObservableProperty]
        private ObservableCollection<Note> allNotes;
        [ObservableProperty]
        private Note toSaveNote = new();
        /*public ICommand SaveCommand { get; set; }
        public ICommand ShowPopupCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public SaveNoteVM Note { get; set; } = new SaveNoteVM();
        public RemoveNoteVM RemoveNote { get; set; } = new RemoveNoteVM();*/
        public NoteMainVM(DBController dBController)
        {
            _dbController = dBController;
            Task.Run(async () => AllNotes = new ObservableCollection<Note>(await _dbController.GetAllUsers()));
            /*SaveCommand = new Command(() =>
            {

                if (RemoveNote.Title != "" && RemoveNote.Detail != "")
                {
                    if (Note.Title == RemoveNote.Title && Note.Detail == RemoveNote.Detail)
                    {
                        return;
                    }
                    else
                    {
                        Notes.RemoveAt(RemoveNote.Index);
                        Notes.Add(new Note(Note.Title, Note.Detail));
                        RemoveNote.Title = "";
                        RemoveNote.Detail = "";
                    }
                }
                else if (Note.Title != "" && Note.Detail != "")
                {
                    Notes.Add(new Note(Note.Title, Note.Detail));
                }
            });
            DeleteCommand = new Command(() =>
            {
                Notes.RemoveAt(RemoveNote.Index);
                RemoveNote.Title = "";
                RemoveNote.Detail = "";
            });
            ShowPopupCommand = new Command(() =>
            {
                ShowPage();
            });*/
        }
        [RelayCommand]
        public async Task ShowEditor()
        {
            var popup = new NoteEditor();
            await Shell.Current.CurrentPage.ShowPopupAsync(popup);
        }
        [RelayCommand]
        public async Task Refresh()
        {
            AllNotes = new ObservableCollection<Note>(await _dbController.GetAllUsers());
        }
        [RelayCommand]
        public async Task SaveNote() 
        {
            if (ToSaveNote.Title != "")
            {
                bool is_exist = false;
                foreach (var note in AllNotes)
                {
                    if (note.Id == ToSaveNote.Id) is_exist = true;
                }
                if (!is_exist) await _dbController.Create(ToSaveNote);
                else await _dbController.Update(ToSaveNote);
                await Refresh();
            }
            /*AllNotes = new ObservableCollection<Note>(await _dbController.GetAllUsers());*/
        }
        [RelayCommand]
        public async Task DeleteNote()
        {
            await _dbController.Delete(ToSaveNote);
            await Refresh();
        }
        public async Task ShowNoteItemsPage()
        {
            var popup = new NoteItems();
            await Shell.Current.CurrentPage.ShowPopupAsync(popup);
        }
    }
}
