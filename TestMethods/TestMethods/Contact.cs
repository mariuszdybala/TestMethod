using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
        int kolejnosc = -1;
        public int Kolejnosc { get { return kolejnosc; } set { kolejnosc = value;} }

       static public  List<Contact> SampleData()
        {
            return new List<Contact> {
                    new Contact {FirstName = "Bartłomiej", LastName = "Gajewski",      DateOfBirth = new DateTime(1945,10,19), Phone = "885 983 885", Email = "gajewski@aspiring-technology.com", State = "MA" },
                    new Contact {FirstName = "Alfred",     LastName = "Wieczorek",     DateOfBirth = new DateTime(1973,12,09), Phone = "848 553 848", Email = "al1@aspiring-technology.com", State = "WM" },
                    new Contact {FirstName = "Adam",       LastName = "Gadomski",      DateOfBirth = new DateTime(1959,10,03), Phone = "115 999 115", Email = "adamg@aspiring-technology.com", State = "OP" },
                    new Contact {FirstName = "Jan",        LastName = "Detka",         DateOfBirth = new DateTime(1950,12,16), Phone = "677 602 677", Email = "jan.detka@aspiring-technology.com", State = "MA" },
                    new Contact {FirstName = "Cezary",     LastName = "Zbytek",        DateOfBirth = new DateTime(1935,02,10), Phone = "603 303 603", Email = "czbytek@aspiring-technology.com", State = "LU" },
                    new Contact {FirstName = "Stanisław",  LastName = "Kowal",         DateOfBirth = new DateTime(1950,02,20), Phone = "546 607 546", Email = "kowals@aspiring-technology.com", State = "WM" },
                    new Contact {FirstName = "Cyryl",      LastName = "Latos",         DateOfBirth = new DateTime(1951,10,21), Phone = "278 918 278", Email = "latos@aspiring-technology.com", State = "WM" },
                    new Contact {FirstName = "Bernard",    LastName = "Radliński",     DateOfBirth = new DateTime(1946,05,18), Phone = "715 920 715", Email = "bernard@aspiring-technology.com", State = "WP" },
                    new Contact {FirstName = "Maciej",     LastName = "Karaś",         DateOfBirth = new DateTime(1977,09,17), Phone = "364 202 364", Email = "mac.karas@aspiring-technology.com", State = "WP" },
                    new Contact {FirstName = "Adrian",     LastName = "Horwat",        DateOfBirth = new DateTime(1922,05,23), Phone = "165 737 165", Email = "adrianh@aspiring-technology.com", State = "SW" }
                };
        }
    }
}
