using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToMysqlDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>#01 Adatbázis adatok pélányosítása.</summary>
            MySQLDatabase a = new MySQLDatabase();
            ///<summary>#01 MySQLDatabaseInterfece objektum létrehozása az adatábzis kapcsolat adataival.</summary>
            MySQLDatabaseInterface mdi = a.getDatabaseInterface();

            try
            {
                ///<summary>#01 Kapcsolat nyitása az adatbázishoz.</summary>                
                mdi.open();
                Console.WriteLine("Sikeres kapcsolódás az adatbázishoz...");
                ///<summary>#02 Kapcsolat bezárása.</summary>                
                mdi.close();
            }
            catch (Exception e)
            {
                ///<summary>#01 Sikertelen adatbázis művelet esetén kivétel kezelés.</summary>                
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
