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
using BT_Android.Bluetooth_Search;

namespace BT_Android.Interfaces
{
    public interface IScanner
    {
        void scan(bool connectCheck);

        List<BTSearchResult> getResultList();

        LOC getCurrentLocation();


    }
}