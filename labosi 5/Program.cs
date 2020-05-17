using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 3
            //Dataset data = new Dataset(@"C:\Users\Mario Matić\source\repos\labosi 5\labosi 5\bin\Debug");
            //DataConsolePrinter.printData(data);

            //IDataset virtualpd = new VirtualProxyDataset(@"C:\Users\Mario Matić\source\repos\labosi 5\labosi 5\bin\Debug");
            //DataConsolePrinter.printData(virtualpd);

            //User user = User.GenerateUser("1.");
            //User usersecond = User.GenerateUser("2.");
            //IDataset protectionproxy = new ProtectionProxyDataset(user);
            //IDataset protectionproxy2 = new ProtectionProxyDataset(usersecond);
            //DataConsolePrinter.printData(protectionproxy);
            //DataConsolePrinter.printData(protectionproxy2);


            //Zadatak 4
            //ITheme theme = new Theme();
            //ReminderNote reminderNote = new ReminderNote("color", theme);
            //reminderNote.Show();

            //Zadatak 5
            //Grupa group = new Grupa("bilješka", theme);
            //group.AddinGroup("Mario");
            //group.AddinGroup("Francisco");
            //group.Show();
            //group.RemovefromGroup("Francisco");
            //group.Show();


            //Zadatak 6
            double[] a = { 10, 7, -2, 35, -12, 3, 5 };
            SortStrategy bubblesort = new BubbleSort();
            SortStrategy combsort = new CombSort();
            SortStrategy seqsort = new SequentialSort();
            NumberSequence number = new NumberSequence(a);
            NumberSequence sequenceSize = new NumberSequence(7);

            number.SetSortStrategy(bubblesort);
            number.Sort();
            number.ToString();
            number.SetSortStrategy(combsort);
            number.Sort();
            number.ToString();
            number.SetSortStrategy(seqsort);
            number.Sort();
            number.ToString();



        }
    }
}
