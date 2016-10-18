using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class LINQ
    {
        public void show()
        {
            string connection = "Data Source=JARVIS;Initial Catalog=AccessControldb;User ID=sa;Password=Deathstrok;Pooling=False";

            DataClasses1DataContext db = new DataClasses1DataContext(connection);




        }
    }
}
