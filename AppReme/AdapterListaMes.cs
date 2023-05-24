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
    internal class AdapterListaMes : BaseAdapter
    {
        Activity Context;
        List<Año> lista;

        public AdapterListaMes(Activity context, List<Año> lista)
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
                view = Context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.An.ToString();
          //  view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = Global.dm.Where(x => x.Idmes == item.Id).Count().ToString();

            return view;
        }
    }
}