using Android.App;
using Android.Content;
using Android.OS;
using Android.Renderscripts;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AppReme.Global;

namespace AppReme
{
    [Activity(Label = "ActivityReme")]
    public class ActivityReme : Activity
    {
        Detalle mesx;
        ListView vlista;
        TextView txtr;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Inicio);
    
            int id = Intent.GetIntExtra("id", 0);

            txtr = FindViewById<TextView>(Resource.Id.textView1);
            mesx = Global.dm.Where(x => x.Id == id).FirstOrDefault();


            txtr.Text = mesx.Remesa.ToString();
            vlista = FindViewById<ListView>(Resource.Id.listView1);
        }
    }
}