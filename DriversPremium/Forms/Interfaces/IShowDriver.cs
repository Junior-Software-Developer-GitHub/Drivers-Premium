using Persons;
using System;

namespace DriversPremium.Forms.Interfaces
{
    interface IShowDriver
    {
        int Sort(string s);
        void LockDeleteButton();
        void LoadData(Person p);
        String GetLicense();
    }
}
