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
    public class Reciever : BroadcastReceiver
    {
        private Activity _act;
        private List<BTSearchResult> _results;
        private LOC _location;

        public Reciever(Activity act)
        {
            _act = act;
            _results = new List<BTSearchResult>();
        }

        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
 
 				// When discovery finds a device 
            if (action == BluetoothDevice.ActionFound)
            {
                // Get the BluetoothDevice object from the Intent 
                BluetoothDevice device = (BluetoothDevice)intent.GetParcelableExtra(BluetoothDevice.ExtraDevice);

                Console.WriteLine(String.Format("Bluetooth Device: {0}", device.Name));

                if(_location == null)
                {
                    throw new NullReferenceException("Location in the Reciever is NULL");
                }

                BTSearchResult result = new BTSearchResult(_location);

                //fill out result.

                _results.Add(result);

                // If it's already paired, skip it, because it's been listed already 
                if (device.BondState != Bond.Bonded)
                {

                }
                // When discovery is finished, change the Activity title 
            }
        }

        public void setLocation(LOC location)
        {
            _location = location;
            _location.deepCopy(location);
        }

        public List<BTSearchResult> getResults()
        {
            return _results;
        }
    }
}