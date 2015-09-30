using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BT_Android.Adapter_LIB
{
    public class App
    {
        public static Robotics.Mobile.Core.Bluetooth.LE.IAdapter Adapter;

        public App()
        {

        }

        public static void SetAdapter(Robotics.Mobile.Core.Bluetooth.LE.IAdapter adapter)
        {
            Adapter = adapter;
        }

    }
}