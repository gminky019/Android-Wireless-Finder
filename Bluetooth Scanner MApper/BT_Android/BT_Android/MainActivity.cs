using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Bluetooth;
using Android.Views;
using Android.Widget;
using Android.OS;
using BT_Android.Adapter_LIB;
using Robotics.Mobile.Core.Bluetooth.LE;
using System.Collections.Generic;
using BT_Android.Interfaces;
using BT_Android.Bluetooth_Search;

namespace BT_Android
{
    [Activity(Label = "BT_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        public Robotics.Mobile.Core.Bluetooth.LE.IAdapter Main_Adapter;
        public List<IDevice> foundDev;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);



            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Initialize_BT();
            button.Click += delegate {
                button.Text = string.Format("{0} clicks!", count++); };

        }

        public void Initialize_BT()
        {
            foundDev = new List<IDevice>();

            var a = new Robotics.Mobile.Core.Bluetooth.LE.Adapter();
            App.SetAdapter(a);

            Main_Adapter = App.Adapter;

            Main_Adapter.DeviceDiscovered += (object sender, DeviceDiscoveredEventArgs e) =>
            {
                Console.WriteLine(String.Format("Device found {0}", e.Device.Name));
                Console.WriteLine(String.Format("Name: {0} {1} {2} {3}", e.Device.Name, e.Device.State.ToString(), e.Device.ID.ToString(), e.Device.NativeDevice.ToString()));
            };

          /*  Main_Adapter.DeviceDiscovered += (object sender, DeviceDiscoveredEventArgs e) =>
            {
                Console.WriteLine(String.Format("Device found {0}", e.Device.Name));
            };*/
        }       
    }

}

