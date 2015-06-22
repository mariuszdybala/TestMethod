using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    class Program
    {
        static List<Contact> contacts;

        static void Main(string[] args)
        {
            SetKolejnosc();
        }

        private static void SetKolejnosc()
        {
            List<Contact> contactUnsorted = new List<Contact>();
            contacts = Contact.SampleData();
            int countContactsSorted = contacts.Count(x => x.Kolejnosc != -1);

            foreach (var contact in contacts)
                if (contact.Kolejnosc == -1)
                {
                    contact.Kolejnosc = countContactsSorted + 1;
                    countContactsSorted ++;
                }



        }
    }
}
