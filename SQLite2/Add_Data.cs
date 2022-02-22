using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLite2
{
    [Activity(Label = "Add_Data")]
    public class Add_Data : Activity
    {
        EditText txt;
        Button btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Add_Data);

            UIReferences();
            UIClick();
            
        }

        private void UIReferences()
        {
            txt = FindViewById<EditText>(Resource.Id.edtText);
            btn = FindViewById<Button>(Resource.Id.addBtn);
        }

        private void UIClick()
        {
            btn.Click += AddBtn_Click;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(activity_main));
            StartActivity(intent);
        }
    }
}