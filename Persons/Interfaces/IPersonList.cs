using System;

namespace Persons.Interfaces
{
    interface IPersonList
    {
        bool AddPerson(Person p);
        bool DeletePerson(Person p);
        bool Exists(Person p);
        Person GetPerson(String driverLicenseNumber);
    }
}
