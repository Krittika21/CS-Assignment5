using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_minister_Dictionary
{
    public class Make_dictionary
    {
        Dictionary<int, string> Dict;// = new Dictionary<int, string>();
        public void Listing()
        {
            Dict = new Dictionary<int, string>()
            {
                { 1998 , "Atal Bihari Vajpayee" },
                { 2014 , "Narendra Modi"},
                { 2004 , "Manmohan Singh"}
            };
            Console.WriteLine("The list of Prime Mininsters are:");
            foreach (var item in Dict)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchFor()
        {
            Console.WriteLine("\n1. The Prime Minister of 2004 is: " + Dict[2004]);
        }
        public void CurrentPM()
        {
            Dict.Add(2019, "Narendra Modi");
            Console.WriteLine("\n2. After Adding:");
            foreach (var item in Dict)
            {
                Console.WriteLine(item);
            }
        }
        public void SortByYear()
        {
            Console.WriteLine("\n3. The list after sorting: ");
            {
                var keys_sorted = Dict.Keys.ToList();
                keys_sorted.Sort();

                foreach (var item in keys_sorted)
                {
                    Console.WriteLine("Year:" + item);
                    Console.WriteLine("Name:" + Dict[item]);
                }
            }
        }
    }
}