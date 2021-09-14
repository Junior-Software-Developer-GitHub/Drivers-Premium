using Persons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persons
{
    public class PersonsList : IPersonList
    {
        /* Attributes */
        private readonly List<Person> _personsList;
        private static PersonsList _instance = null;


        /* Constructor */
        private PersonsList() => _personsList = new List<Person>(); //Singleton

        /* Methods */
        public static PersonsList Instance => _instance is null ? _instance = new PersonsList() : _instance;

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

        //Method syntax:
        public bool Exists(Person p) => _personsList.Where(person => person.DriverLicenseNumber.Equals(p.DriverLicenseNumber)).Any();

        public Person GetPerson(String driverLicenseNumber) => _personsList.FirstOrDefault(x => x.DriverLicenseNumber == driverLicenseNumber);
    }
}