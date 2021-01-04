using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class PersonsList
    {

        readonly List<Person> _personsList;
        private static PersonsList _instance = null;

        public static PersonsList Instance => _instance is null ? _instance = new PersonsList() : _instance;

        private PersonsList() => _personsList = new List<Person>();//Singleton

        public bool AddPerson(Person p)
        {
            if (Exists(p)) return false;
            _personsList.Add(p);
            return true;
        }

        public bool DeletePerson(Person p)
        {
            if (!Exists(p)) return false;
            _personsList.Remove(p);
            return true;
        }

        public bool Exists(Person p) => (from person in _personsList
                                         where person.DriverLicenseNumber == p.DriverLicenseNumber
                                         select person).Any();

        public Person GetPerson(String driverLicenseNumber) => (from person in _personsList
                                                                where person.DriverLicenseNumber == driverLicenseNumber
                                                                select person).ToList().FirstOrDefault();
    }
}