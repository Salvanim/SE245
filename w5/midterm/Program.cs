using System;
using System.Linq; 

namespace midterm
{
  class Program{
    class Person{
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        
        public Person(){
            Console.WriteLine($"Person Created with no attributes");
        }
        
        public Person(string fN, string mN, string lN, string s1, string s2, string cit, string st, string zp, string ph, string mail){
            firstName = fN;
            middleName = mN;
            lastName = lN;
            street1 = s1;
            street2 = s2;
            city = cit;
            state = st;
            zip = zp;
            phone = ph;
            email = mail;
            Console.WriteLine($"Person Created with attributes: \n FirstName: {firstName}\n MiddleName: {middleName}\n LastName: {lastName}\n Street1: {street1}\n Street 2: {street2}\n City: {city}\n State: {state}\n Zip: {zip}\n Phone: {phone}\n Email: {email}\n");
        }

        public void setFirstName(string fN){
            firstName = fN;
            Console.WriteLine("Attribute Added");
        }

        public void setMiddleName(string mN){
            middleName = mN;
            Console.WriteLine("Attribute Added");
        }

        public void setLastName(string lN){
            lastName = lN;
            Console.WriteLine("Attribute Added");
        }

        public void setStreet1(string s1){
            street1 = s1;
            Console.WriteLine("Attribute Added");
        }

        public void setStreet2(string s2){
            street2 = s2;
            Console.WriteLine("Attribute Added");
        }
        
        public void setCity(string City){
            city = City;
            Console.WriteLine("Attribute Added");
        }

        public void setState(string State){
            state = State;
            Console.WriteLine("Attribute Added");
        }

        public void setZip(string z){
            zip = z;
            Console.WriteLine("Attribute Added");
        }

        public void setPhone(string phoneNumber){
            phone = phoneNumber;
            Console.WriteLine("Attribute Added");
        }

        public void setEmail(string mail){
            email = mail;
            Console.WriteLine("Attribute Added");
        }

        public string GetFirstName(){
            return firstName;
        }

        public string GetMiddleName(){
            return middleName;
        }

        public string GetLastName(){
            return lastName;
        }

        public string GetStreet1(){
            return street1;
        }

        public string GetStreet2(){
            return street2;
        }

        public string GetCity(){
            return city;
        }

        public string GetState(){
            return state;
        }

        public string GetZip(){
            return zip;
        }

        public string GetPhone(){
            return phone;
        }

        public string GetEmail(){
            return email;
        }
    }

    static void Main(string[] args){
        Person basePerson = new Person("Dylan", "James", "Fisher", "New England Tech Blvd", "Wolf Ct", "Richmond", "RI", "02814", "401-954-2143", "djfisher@email.neit.edu");
    }
  }
}