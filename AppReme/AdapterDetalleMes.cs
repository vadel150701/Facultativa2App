using Android.App;
using Android.Content;
using Android.OS;
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
    internal class AdapterDetalleMes : BaseAdapter
    {
        Activity Context;
        List<Detalle> lista;

        public AdapterDetalleMes(Activity context, List<Detalle> lista)
        {
            Context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = Context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleExpandableListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Mes;
           


            return view;
        }
    }
}