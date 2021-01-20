using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructuresNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            ConManager cm_def = new ConManager();
            cm_def.List();

            ConManager cm_input = new ConManager(30);
            cm_input.List();

            Products pr = new Products() { Id = 1, Name="PC" };  //STANDART KULLANIMDA YAPICI METOD OLMADAN SADECE GETTER SETTER YAPILDIGINDA KULLANIM SEKLİ
            Products pr2 = new Products(2, "TV");

            pr.Name = "Ferhat";
            pr2.Name = "Dilek";

            DatabaseManager DB = new DatabaseManager(new FileLogger());
            DB.Add();

            DatabaseManager DB2 = new DatabaseManager(new DBLogger());
            DB2.Add();

            PersonManager pm = new PersonManager("Managment Dep");
            pm.Add();


            Console.ReadLine();
        }
    }


}
