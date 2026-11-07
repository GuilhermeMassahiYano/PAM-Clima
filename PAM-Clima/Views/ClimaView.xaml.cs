using PAM_Clima.Models;
using PAM_Clima.ViewModels;

namespace PAM_Clima.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();
		BindingContext = new ClimaViewModels();

	}
}