using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab22.Models
{
    public class User
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phonenumber;
        private string password;

        public string Firstname
        {
            set { firstname=value; }
            get { return firstname; }
        }
        public string Lastname
        {
            set {  lastname=value; }
            get { return lastname; }
        }
        public string Email
        {
            set { email= value; }
            get { return email; }
        }
        public string Phonenumber
        {
            set { phonenumber= value; }
            get { return phonenumber; }
        }
        public string Password
        {
            set { password =value; }
            get { return password; }
        }
        public User()
        {

        }
        public User(string _firstname, string _lastname,string _email,string _phonenumber,string _password)
        {
            Firstname = _firstname;
            Lastname = _lastname;
            Email = _email;
            Phonenumber = _phonenumber;
            Password = _password;
        }
    }
}