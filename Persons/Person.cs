using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        /* Attributes */
        String _firstName;
        String _lastName;
        String _placeOfIssue;
        String _gender;
        DateTime _dateOfBirth, _iss, _exp;
        String _driverLicenseNumber;
        List<string> _categories, _prohibition;
        String _picture;
        List<string> _issOfProhibition;
        List<string> _expOfProhibition;

        /* Properties */
        public String FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public String LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }
        public DateTime Iss
        {
            get => _iss;
            set => _iss = value;
        }
        public DateTime Exp
        {
            get => _exp;
            set => _exp = value;
        }
        public List<string> IssOfProhibition
        {
            get => _issOfProhibition;
            set => _issOfProhibition = value;
        }
        public List<string> ExpOfProhibition
        {
            get => _expOfProhibition;
            set => _expOfProhibition = value;
        }
        public String DriverLicenseNumber
        {
            get => _driverLicenseNumber;
            set => _driverLicenseNumber = value;
        }
        public String PlaceOfIssue
        {
            get => _placeOfIssue;
            set => _placeOfIssue = value;
        }
        public String Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public List<string> Categories
        {
            get => _categories;
            set => _categories = value;
        }
        public List<string> Prohibition
        {
            get => _prohibition;
            set => _prohibition = value;
        }
        public String Picture
        {
            get => _picture;
            set => _picture = value;
        }

        /* Constructor */
        public Person(String firstName, String lastName, DateTime dateOfBirth, DateTime iss, DateTime exp
            , String driverLicenseNumber, String placeOfIssue, String gender, List<string> categories,
            List<string> prohibition, List<string> issOfProhibition, List<string> expOfProhibition, String picture)

            => (FirstName, LastName, DateOfBirth, Iss, Exp, DriverLicenseNumber, PlaceOfIssue, Gender, Categories, Prohibition, IssOfProhibition, ExpOfProhibition, Picture)
            = (firstName, lastName, dateOfBirth, iss, exp, driverLicenseNumber, placeOfIssue, gender, categories, prohibition, issOfProhibition, expOfProhibition, picture);

    }
}