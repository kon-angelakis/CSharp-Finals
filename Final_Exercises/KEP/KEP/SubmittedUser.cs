namespace KEP
{
    internal class SubmittedUser
    {
        private string name, ssn, email, phone, address, dob, type;
        public SubmittedUser(string n, string s, string e, string p, string a, string d, string t) 
        {
            name= n;
            ssn= s;
            email= e;
            phone= p;
            address= a;
            dob= d;
            type= t;
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

    }
}
