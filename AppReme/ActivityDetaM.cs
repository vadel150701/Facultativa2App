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
using static Android.Content.ClipData;
using static AppReme.Global;

namespace AppReme
{
    [Activity(Label = "ActivityDetaM")]
    public class ActivityDetaM : Activity
    {
      

        Detalle dt;
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detallemes);
            int id = Intent.GetIntExtra("id", 0);
            dt = Global.dm.Where(x => x.Id == id).FirstOrDefault();

            vlista = FindViewById<ListView>(Resource.Id.listView1);
          
            vlista.Adapter = new AdapterDetalleMes(this, Global.dm.Where(x => x.Idannio == dt.Id).ToList());
            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityReme));
            Detalle d = dm[e.Position];
            i.PutExtra("id", d.Id);
            StartActivity(i);
        }

        }
    }
