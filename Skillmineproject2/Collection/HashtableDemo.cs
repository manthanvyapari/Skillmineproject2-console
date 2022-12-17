using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "USA");
            hashtable.Add(2, "UK");
            hashtable.Add(91, "IND");
            hashtable.Add(4, "AUS");
            hashtable.Add(7, "KANADA");
            hashtable.Add("Test", 200);

            hashtable.Remove("Test");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("--------------------------------");

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "USA");
            sortedList.Add(2, "UK");
            sortedList.Add(91, "IND");
            sortedList.Add(4, "AUS");
            sortedList.Add(7, "KANADA");


            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }

    }
}
