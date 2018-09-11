using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using System;
using System.Collections.Generic;

namespace Dining
{
	public class Restaurant 
	{
		public Restaurant(string name, float rating, Drawable image)
		{
			Name   = name;
			Rating = rating;
            Image =  image;

        }

		public string Name   { get; set; }
		public float  Rating { get; set; }
        public Drawable Image  { get; set; }
	}

	public static class SampleData
	{
		public static List<Restaurant> GetRestaurants(Context context)
		{
			var restaurants = new List<Restaurant>();

            restaurants.Add(new Restaurant("Joe's Coffee Shop",  3.5F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
            restaurants.Add(new Restaurant("Bakehouse Cakes",    2.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Silver Spoon Diner", 2.5F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Pasta Connection",   4.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Main Grill",         1.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Pizza Central",      2.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Taverna on Main",    5.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));
			restaurants.Add(new Restaurant("Cow & Pig",          3.0F, ContextCompat.GetDrawable(context, Resource.Drawable.sample)));

            return restaurants;
		}
	}
}