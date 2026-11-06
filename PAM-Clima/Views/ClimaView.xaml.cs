using PAM_Clima.Models;

namespace PAM_Clima.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();
		ClimaModel climaModel = new ClimaModel();
		climaModel.Data = DateTime.Now;

	}
}