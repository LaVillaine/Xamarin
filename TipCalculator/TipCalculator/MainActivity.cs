using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText billAmount;
        Button calculate;
        TextView tipVal;
        TextView totalVal;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Assign values
            billAmount = FindViewById<EditText>(Resource.Id.billAmountEdit);
            calculate = FindViewById<Button>(Resource.Id.calculateBtn);
            tipVal = FindViewById<TextView>(Resource.Id.tipValView);
            totalVal = FindViewById<TextView>(Resource.Id.totalValView);

            // Subscribe to click event
            calculate.Click += onCalculateBtnClick;
        }

        void onCalculateBtnClick(object sender, EventArgs e)
        {
            if (billAmount.Text.Length > 0)
            {
                double bill = double.Parse(billAmount.Text);
                if (bill > 0.0)
                {
                    double tip = bill * 15 / 100;
                    double total = bill + tip;

                    tipVal.Text = tip.ToString("N");
                    totalVal.Text = total.ToString("N");
                }
                else
                {
                    tipVal.Text = "0.00";
                    totalVal.Text = "0.00";
                }
            }
            else
            {
                tipVal.Text = "0.00";
                totalVal.Text = "0.00";
            }
        }
    }
}

