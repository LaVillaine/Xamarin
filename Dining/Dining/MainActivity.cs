﻿using Android.App;
using Android.Support.V7.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;

namespace Dining
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView recyclerView;
        RestaurantAdapter restauAdapter;
        List<Restaurant> listOfRestaurants;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var layoutMan = new GridLayoutManager(this, 2, GridLayoutManager.Vertical, false);
            listOfRestaurants = SampleData.GetRestaurants(this);
            restauAdapter = new RestaurantAdapter(listOfRestaurants);
            restauAdapter.ItemClick += OnItemClick;

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetLayoutManager(layoutMan);
            recyclerView.SetAdapter(restauAdapter);
        }

        void OnItemClick(object sender, int position)
        {
            System.Diagnostics.Debug.WriteLine("Click: " + position);
        }
    }
}

