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
using Android.Bluetooth;

namespace BT_Android.Bluetooth_Search
{
    public class BTSearchResult
    {
        public string _name;
        public string _deviceType;
        public string _bondState;
        public BluetoothClass _btClass;
        public Java.Lang.Class _javaClass;
        public string _address;

        private Bond _bond;
        private BluetoothDeviceType _type;
        private LOC _location;

        public BTSearchResult(LOC location)
        {
            _location.Equals(location);
        }

        public void setBTDeviceType(BluetoothDeviceType type)
        {
            _type = type;
            _deviceType = _type.ToString();
        }

        public void setBondState(Bond bond)
        {
            _bond = bond;

            _bondState = _bond.ToString();
        }  
    }
}