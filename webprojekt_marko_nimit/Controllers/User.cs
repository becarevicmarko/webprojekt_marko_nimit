using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webprojekt_marko_nimit.Controllers
{
    public enum Gender { m, w, notSpecified}
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        // ...

        public User() : this(0, "", "", Gender.notSpecified, DateTime.MinValue, "", "", "") { }
        public User(int id, string firstname, string lastname, Gender gender, DateTime birthdate, string password, string username, string password2)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.Password = password;
            this.Username = username;
            this.Password2 = password2;
        }

        // ToString

    }
}