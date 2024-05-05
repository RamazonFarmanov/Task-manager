using TextAppMaui.ViewModels;
using TextAppMaui.Models;
namespace TextAppMaui.Views;

public partial class TestPage : ContentPage
{
	/*NoteMainVM vm;*/
	MainVM mainVM;
	public TestPage(DBController dBController)
	{
		InitializeComponent();
		mainVM = new MainVM(dBController);
		/*vm = new NoteMainVM(dBController);*/
		BindingContext = MainVM.vm;
	}

	private async void notesCollection_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var note = (Note)e.Item;
		MainVM.vm.ToSaveNote = note;
		await MainVM.vm.ShowNoteItemsPage();
	}
}