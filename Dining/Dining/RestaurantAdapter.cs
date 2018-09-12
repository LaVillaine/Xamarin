using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using System;

namespace Dining
{
    public class RestaurantAdapter : RecyclerView.Adapter
    {
        List<Restaurant> listOfRestaurants;
        public event EventHandler<int> ItemClick;

        public RestaurantAdapter(List<Restaurant> data)
        {
            listOfRestaurants = data;
        }

        public override int ItemCount
        {
            get { return listOfRestaurants.Count; }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.Restaurant, parent, false);
            return new RestaurantViewHolder(view, OnItemClick);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = (RestaurantViewHolder)holder;
            viewHolder.Image.SetImageDrawable(listOfRestaurants[position].Image);
            viewHolder.Rating.Rating = listOfRestaurants[position].Rating;
            viewHolder.Name.Text = listOfRestaurants[position].Name;
        }

        public void OnItemClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
    }
}

