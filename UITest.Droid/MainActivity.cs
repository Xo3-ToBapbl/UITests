using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace UITest.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            SupportActionBar?.Hide();

            var button = FindViewById<Button>(Resource.Id.button);
            button.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var rootLayout = FindViewById<EditText>(Resource.Id.editor);
            rootLayout.Text = "AFTER";
        }
    }
}