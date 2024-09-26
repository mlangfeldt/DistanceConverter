using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class DistancePage : ContentPage
{
    public DistancePage()
    {
        InitializeComponent();
        Title = "Distance Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate//push or pop a stack, like plate buffet
        {
            Navigation.PushAsync(new AboutPage());
        };
    }
}