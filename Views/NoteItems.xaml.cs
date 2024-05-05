using CommunityToolkit.Maui.Views;
using TextAppMaui.ViewModels;

namespace TextAppMaui.Views;

public partial class NoteItems : Popup
{
	public NoteItems()
	{
		InitializeComponent();
		BindingContext = MainVM.vm;
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}