using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class DistancePage : ContentPage
{
    private double KeyValue = 0;
    
        private double dbl_m2f = 3.2808395;
        private double dbl_m2i = 39.37007874;
        private double dbl_m2mi = 0.00062137119;
        private double dbl_m2m = 1;
        private double dbl_m2nm = 0.0005399568034557;
        private double dbl_m2y= 1.093613298;
        private double dbl_m2k= 0.001;
        
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

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = "";
        txtInches.Text = "";
        txtKilometers.Text = "";
        txtMeters.Text = "";
        txtMiles.Text = "";
        txtNautical.Text = "";
        txtYards.Text = "";
    }

    private void TxtMeters_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2m
        double dblNumber;
        var isvalid = double.TryParse(txtMeters.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2m;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtFeet_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2f
        double dblNumber;
        var isvalid = double.TryParse(txtFeet.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2f;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtInches_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2i
        double dblNumber;
        var isvalid = double.TryParse(txtInches.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2i;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtYards_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2y
        double dblNumber;
        var isvalid = double.TryParse(txtYards.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2y;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMiles_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2mi
        double dblNumber;
        var isvalid = double.TryParse(txtMiles.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2mi;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtNautical_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2nm
        double dblNumber;
        var isvalid = double.TryParse(txtNautical.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2nm;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilometers_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2k
        double dblNumber;
        var isvalid = double.TryParse(txtKilometers.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = (KeyValue * dbl_m2f).ToString("g9");//will carry out 9 places past decimal
        txtInches.Text = (KeyValue * dbl_m2i).ToString("g9");
        txtKilometers.Text = (KeyValue * dbl_m2k).ToString("g9");
        txtMeters.Text = (KeyValue * dbl_m2m).ToString("g9");
        txtMiles.Text = (KeyValue * dbl_m2mi).ToString("g9");
        txtNautical.Text = (KeyValue * dbl_m2nm).ToString("g9");
        txtYards.Text = (KeyValue * dbl_m2y).ToString("g9");
    }
}