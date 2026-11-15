using ViewModels;
namespace Views;

public partial class WelcomeMenuPage : ContentPage
{
    public WelcomeMenuPage() : this(new WelcomeMenuViewModel())
    {
    }
    public WelcomeMenuPage(WelcomeMenuViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void NavigateToTemperatureCalculatorPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TemperatureCalculatorPage");
    }

    public async void NavigateToCalcAgePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CalcAgePage");
    }

    public async void NavigateToMathPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CalculatorPage");
    }
}