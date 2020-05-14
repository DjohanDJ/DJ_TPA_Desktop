using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class ConnectionController
    {
        
        private static UnderTheSeaDatabaseEntities myDatabase = null;

        public static UnderTheSeaDatabaseEntities GetInstance()
        {
            if (myDatabase == null)
            {
                myDatabase = new UnderTheSeaDatabaseEntities();
            }
            return myDatabase;
        }

    }

}
