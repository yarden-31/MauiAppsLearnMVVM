using ViewModels;

namespace Views;

public partial class TemperatureCalculatorPage : ContentPage
{
    public TemperatureCalculatorPage() : this(new TemperatureCalculatorViewModel())
    {
    }

    // קבלת ה-ViewModel ישירות דרך Dependency Injection וחיבור ה-Binding Context
    public TemperatureCalculatorPage(TemperatureCalculatorViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}