using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectToMysqlDatabase
{
    class MySQLDatabase
    {
        public MySQLDatabaseInterface getDatabaseInterface()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(false);
            mdi.setConnectionServerData("192.168.0.100", "szoftverf","3306");
            mdi.setConnectionUserData("szoftverf", "szoftverf");
            mdi.makeConnectionToDatabase();        

            return mdi;
        }
    }
}
