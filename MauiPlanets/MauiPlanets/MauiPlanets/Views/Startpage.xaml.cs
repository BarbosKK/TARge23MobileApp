namespace MauiPlanets.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("transitionAnimation"))
		{
			return;
		}

		var parentAnimation = new Animation();

		//PlanetsAnimation
		parentAnimation.Add(0, 0.2, new Animation(v  => imgMercury.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.1, 0.3, new Animation(v => imgVenus.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.3, 0.5, new Animation(v => imgMars.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.4, 0.6, new Animation(v => imgJupiter.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgSaturn.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.6, 0.8, new Animation(v => imgUranus.Opascity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.7, 0.9, new Animation(v => imgNeptune.Opascity = v, 0, 1, Easing.CubicIn));

        //Intro Box
        parentAnimation.Add(0.7, 0.9, new Animation(v => imgIntro.Opascity = v, 0, 1, Easing.CubicIn));
		parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }

	//async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
	//	=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());
}