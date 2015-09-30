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
using BT_Android.Interfaces;
using Android.Bluetooth;

namespace BT_Android.Bluetooth_Search
{
    public class BluetoothSearch : IScanner
    {
        private List<BTSearchResult> _results;
        public List<BTSearchResult> _currentPaired;
        private LOC _location;
        private BluetoothAdapter _bluetooth;
        private Reciever _reciever;
        private Activity _activity;

        public BluetoothSearch(Activity prevActivity)
        {
            _bluetooth = BluetoothAdapter.DefaultAdapter;
            _reciever = new Reciever(prevActivity);
            _activity = prevActivity;
        }
        public void scan(bool connectCheck)
        {

            _location = getCurrentLocation();
            _reciever.setLocation(_location);

            //register for broadcasts when device discovered
            var filter = new IntentFilter(BluetoothDevice.ActionFound);
            _activity.RegisterReceiver(_reciever, filter);

            //register for broadcast when discover has finished
            filter = new IntentFilter(BluetoothAdapter.ActionDiscoveryFinished);
            _activity.RegisterReceiver(_reciever, filter);

            Console.WriteLine("Getting current Paired Bluetooth Devices");
            //get current paired devices
            _currentPaired = getCurrentPairedDevices();


            Console.WriteLine("Discovering Bluetooth Devices.");
            //Discover New Devices
            _bluetooth.StartDiscovery();
        }

        private List<BTSearchResult> getCurrentPairedDevices()
        {
            var currentPairings = _bluetooth.BondedDevices;
            List<BTSearchResult> results = new List<BTSearchResult>();

            foreach(var pairing in currentPairings)
            {
                BTSearchResult result = new BTSearchResult(_location);

                //fillout object here 

                results.Add(result);
            }

            return results;
        }
 
        public LOC getCurrentLocation()
        {
            LOC location = new LOC();
            return location;
        }

        public List<BTSearchResult> getResultList()
        {
            _results = _reciever.getResults();
            
            if(_results == null)
            {
                throw new NullReferenceException("Bluetooth Results is NULL");
            }

            if (_results.Count == 0)
            {
                throw new Exception("Bluetooth results are Empty");
            }

            return _results;
        }
    }
}