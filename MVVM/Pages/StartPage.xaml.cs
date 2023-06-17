using NavigationDemo.MVVM.ViewModes;
using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        BindingContext = new StartPageViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    // Assegna il valore del StartPage a page2
    private void Button_Clicked(object sender, EventArgs e)
    {
        var currentViewMode = ((StartPageViewModel)BindingContext).Name;
		Navigation.PushAsync(new Page2
        {
            BindingContext = new Page2ViewModel
            {
                Name = currentViewMode
            }
        });
        //NavUtilities.DeletedPage(Navigation, "StartPage");
    }
}