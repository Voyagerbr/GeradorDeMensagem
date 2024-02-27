namespace GeradorDeImagem;

public partial class MainPage : ContentPage
{
  string[] images = nameof string[6];
  Random random = new Random();

	public MainPage()
	{
		InitializeComponent();
		images[0] = "maonalisa.jpg";
		images[1] = "heart.jpg;"
		images[2] = "gato-selfie.jpg;"
		images[3] = "cojura.jpg;"
		images[4] = "butterfly.jpg;"
		images[5] = "arara.jpg;"
		

	}

  void Button_Clicked(System.Object sender, System.EventArgs e)
  {
	int indice = random.Next(0, 5);
	imageMsg.Source = images[indice];
  }
}

