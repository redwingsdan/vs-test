using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Button newGame = FindViewById<Button>(Resource.Id.button1);
            Button addRole = FindViewById<Button>(Resource.Id.button2);
            Button newPlayer = FindViewById<Button>(Resource.Id.button3);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            newGame.Click += delegate { SetContentView(Resource.Layout.Main); };
            addRole.Click += delegate { SetContentView(Resource.Layout.Role); };
            newPlayer.Click += delegate { SetContentView(Resource.Layout.Player);
                EditText num = FindViewById<EditText>(Resource.Id.numPlayers);
                int number = Int32.Parse(num.EditableText.ToString());
            };
        }
    }
}

