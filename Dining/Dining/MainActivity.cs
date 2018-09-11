using Android.App;
using Android.Support.V7.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Dining
{
    public class RestaurantViewHolder : RecyclerView.ViewHolder
    {
        public RestaurantViewHolder(View itemView)
            : base(itemView)
        {
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Rating = itemView.FindViewById<RatingBar>(Resource.Id.ratingBar);
            Name = itemView.FindViewById<TextView>(Resource.Id.nameTextView);
        }

        public ImageView Image { get; private set; }

        public RatingBar Rating { get; private set; }

        public TextView Name { get; private set; }
    }

    public class RestaurantAdapter : RecyclerView.Adapter
    {
        List<Restaurant> listOfRestaurants;

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
            return new RestaurantViewHolder(view);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = (RestaurantViewHolder)holder;
            viewHolder.Image.SetImageDrawable(listOfRestaurants[position].Image);
            viewHolder.Rating.Rating = listOfRestaurants[position].Rating;
            viewHolder.Name.Text = listOfRestaurants[position].Name;
        }
    }

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

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetLayoutManager(layoutMan);
            recyclerView.SetAdapter(restauAdapter);
        }
    }
}

