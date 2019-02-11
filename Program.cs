using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_minister_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Make_dictionary details = new Make_dictionary();
            details.Listing();
            details.SearchFor();
            details.CurrentPM();
            details.SortByYear();
        }
    }
}
