using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.WeightConverter;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_k2g = 1000;
    private double dbl_k2oz = 35.274;
    private double dbl_k2lb = 2.20462;
    private double dbl_k2k = 1;
    
    
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";
    }


    private void TxtKilo_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double dblNumber;
        var isvalid = double.TryParse(txtKilo.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_k2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double dblNumber;
        var isvalid = double.TryParse(txtGrams.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_k2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtOz_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double dblNumber;
        var isvalid = double.TryParse(txtOz.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_k2oz;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtLbs_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double dblNumber;
        var isvalid = double.TryParse(txtLbs.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_k2lb;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtOz.Text = "";
        txtKilo.Text = "";
        txtGrams.Text = "";
        txtLbs.Text = "";
        
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtKilo.Text = (KeyValue * dbl_k2k).ToString("g9");
        txtGrams.Text = (KeyValue * dbl_k2g).ToString("g9");
        txtOz.Text = (KeyValue * dbl_k2oz).ToString("g9");
        txtLbs.Text = (KeyValue * dbl_k2lb).ToString("g9");
       
    }
}