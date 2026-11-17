using ViewModels;

namespace Views;

public partial class CurrencyCalculatorPage : ContentPage
{
    public CurrencyCalculatorPage() : this(new CurrencyCalculatorViewModel())
    {
    }

    public CurrencyCalculatorPage(CurrencyCalculatorViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}