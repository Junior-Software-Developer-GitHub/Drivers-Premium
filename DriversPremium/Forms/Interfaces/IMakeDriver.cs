using Persons;
using System;
using System.Data;

namespace DriversPremium.Forms.Interfaces
{
    interface IMakeDriver
    {
        String FirstLetterCapital(String s);
        void DeleteDuplicates(Person p);
        bool FieldOccupancy();
        void EnableOrDisableButtons();
        void MakeColumns(DataTable dt);
        abstract void Capture_ImageGrabbed(object sender, EventArgs e);

    }
}
