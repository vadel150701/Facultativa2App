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
using static Android.Telecom.Call;

namespace AppReme
{
    internal class Global
    {
        public static List<Año> a = new List<Año>()
        {

            new Año(1,2000),
            new Año(2,2001),
            new Año(3,2002),
            new Año(4,2003),
            new Año(5,2004),
            new Año(6,2005),
            new Año(7,2006),
            new Año(8,2007),
            new Año(9,2008),
            new Año(10,2009),
            new Año(11,2010)


        };
        public static List<Detalle> dm = new List<Detalle>()
        {
            new Detalle(1,"Enero", 1,19.8),
            new Detalle(2,"Febrero",1,20.8),
            new Detalle(3,"Marzo",1,23.4),
            new Detalle(4,"Abril",1,23.6),
            new Detalle(5,"Mayo",1, 24.8),
            new Detalle(6,"Junio",1,25.2),
            new Detalle(7,"Julio", 1,26.3),
            new Detalle(8,"Agosto",1,27.5),
            new Detalle(9,"Septiembre",1,29.4),
            new Detalle(10,"Octubre",1,29.9),
            new Detalle(11,"Noviembre",1,29.5),
            new Detalle(12,"Diciembre",1, 39.8),

             new Detalle(13,"Enero", 2,23),
            new Detalle(14,"Febrero",2,22.5),
            new Detalle(15,"Marzo",2,21.2),
            new Detalle(16,"Abril",2,23.2),
            new Detalle(17,"Mayo",2, 23.2),
            new Detalle(18,"Junio",2,34),
            new Detalle(19,"Julio", 2,24),
            new Detalle(20,"Agosto",2,5.5),
            new Detalle(21,"Septiembre",2,21.2),
            new Detalle(22,"Octubre",2,17.8),
            new Detalle(23,"Noviembre",2,23),
            new Detalle(24,"Diciembre",2, 23.2), 
            
            new Detalle(25,"Enero", 3,23),
            new Detalle(26,"Febrero",3,22.5),
            new Detalle(27,"Marzo",3,21.2),
            new Detalle(28,"Abril",3,23.2),
            new Detalle(29,"Mayo",3, 23.2),
            new Detalle(30,"Junio",3,34),
            new Detalle(31,"Julio", 3,24),
            new Detalle(32,"Agosto",3,5.5),
            new Detalle(33,"Septiembre",3,21.2),
            new Detalle(34,"Octubre",3,17.8),
            new Detalle(35,"Noviembre",3,23),
            new Detalle(36,"Diciembre",3, 23.2),


         };
        public class Detalle
        {
            int id;
            string mes;
            int idannio;
            double remesa;

            public Detalle(int id, string mes, int idannio, double remesa)
            {
                this.Id = id;
                this.Mes = mes;
                this.Idannio = idannio;
                this.Remesa = remesa;
            }

            public int Id { get => id; set => id = value; }
            public string Mes { get => mes; set => mes = value; }
            public int Idannio { get => idannio; set => idannio = value; }
            public double Remesa { get => remesa; set => remesa = value; }
        }


        public class Año
        {
            int id;
            int an;

            public Año(int id, int an)
            {
                this.Id = id;
                this.An = an;
            }

            public int Id { get => id; set => id = value; }
            public int An { get => an; set => an = value; }
        }

    }
}