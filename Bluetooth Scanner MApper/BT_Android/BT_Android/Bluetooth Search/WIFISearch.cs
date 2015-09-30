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

namespace BT_Android.Bluetooth_Search
{
    class WIFISearch : IScanner
    {
        public void scan(bool connectCheck)
        {
            throw new NotImplementedException();
        }

        public List<BTSearchResult> getResultList()
        {
            throw new NotImplementedException();
        }

        public LOC getCurrentLocation()
        {
            throw new NotImplementedException();
        }
    }
}