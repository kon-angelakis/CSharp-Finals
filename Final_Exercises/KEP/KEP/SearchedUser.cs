using System;
using System.Collections.Generic;
namespace KEP
{
    internal class SearchedUser
    {
        private int ID;
        private string name,ssn,email,phone,address,dob,type, application_time;
        public SearchedUser(int ID, string n, string s, string e, string p, string a, string d, string t, string at)
        {
            this.ID = ID;
            name = n;
            ssn = s;
            email = e;
            phone = p;
            address = a;
            dob = d;
            type = t;
            application_time = at;
        }

        public int getID()
        {
            return ID;
        }
        public string getName()
        {
            return name;
        }

        public string getSsn()
        {
            return ssn;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getAddress()
        {
            return address;
        }

        public string getDate()
        {
            return dob;
        }

        public string getType()
        {
            return type;
        }

        public string getAT()
        {
            return application_time;
        }

        public override string ToString()
        {
            return ("ID: " + ID + " , " +
                "Name: " + name + " , " +
                "SSN: " + ssn + " , " +
                "Email: " + email + " , " +
                "Phone: " + phone + " , " +
                "Address: " + address + " , " +
                "DateOfBirth: " + dob + " , "+
                "Applic_Type: " + type + " , " +
                "Applic_Time: " + application_time + " , ").ToString();
        }
    }
}