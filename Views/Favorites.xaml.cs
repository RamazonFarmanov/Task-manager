using TextAppMaui.Models;
using TextAppMaui.ViewModels;

namespace TextAppMaui.Views;

public partial class Favorites : ContentPage
{
	public Favorites()
	{
		InitializeComponent();
		BindingContext = MainVM.vm;
	}
    private async void notesCollection_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var note = (Note)e.Item;
        MainVM.vm.ToSaveNote = note;
        await MainVM.vm.ShowNoteItemsPage();
    }
}