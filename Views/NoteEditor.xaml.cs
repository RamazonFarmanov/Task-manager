using CommunityToolkit.Maui.Views;
using TextAppMaui.Models;
using TextAppMaui.ViewModels;

namespace TextAppMaui.Views;

public partial class NoteEditor : Popup
{
    /*NoteMainVM vm;*/
    public NoteEditor()
	{
		InitializeComponent();
		/*vm = new NoteMainVM(dBController);*/
		BindingContext = MainVM.vm;
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}