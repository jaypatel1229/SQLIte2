using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace SQLite2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Toolbar toolBar;
        ImageView imgView;
        ListView listView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            UIReferences();
            UIClick();
        }

        private void UIReferences()
        {
            toolBar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            imgView = FindViewById<ImageView>(Resource.Id.imgBtn);
            listView = FindViewById<ListView>(Resource.Id.listView1);
        }

        private void UIClick()
        {
            imgView.Click += delegate{
                Intent i = new Intent(this, typeof(Add_Data));
                StartActivity(i);
            };
        }       

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}