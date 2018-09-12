using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace Dining
{
    public class RestaurantViewHolder : RecyclerView.ViewHolder
    {
        public RestaurantViewHolder(View itemView, Action<int> clickListener)
            : base(itemView)
        {
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Rating = itemView.FindViewById<RatingBar>(Resource.Id.ratingBar);
            Name = itemView.FindViewById<TextView>(Resource.Id.nameTextView);

            itemView.Click += (s, e) =>
            {
                int position = base.AdapterPosition;
                if (position == RecyclerView.NoPosition)
                    return;
                clickListener(position);
            };
        }

        public ImageView Image { get; private set; }

        public RatingBar Rating { get; private set; }

        public TextView Name { get; private set; }
    }
}

