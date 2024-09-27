using DistanceConverter.Views;
using DistanceConverter.WeightConverter;

namespace DistanceConverter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var tabbedPage = new TabbedPage
        {
            Title = "Conversion"
        };

        var distancePage = new NavigationPage(new DistancePage())
        {
            Title = "Distance"
        };

        var weightPge = new NavigationPage(new WeightPage())
        {
            Title = "Weight"
        };
        
        tabbedPage.Children.Add(distancePage);
        tabbedPage.Children.Add(weightPge);

        MainPage = tabbedPage;
    }
}