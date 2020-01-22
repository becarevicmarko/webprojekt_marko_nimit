﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webprojekt_marko_nimit.Models
{
    public class Dog
    {
        //properties
        public string Name { get; set; }

        public int Expirience { get; set; }

        public DateTime Birthdate { get; set; }

        public string Informations { get; set; }

        public string Description { get; set; }

        //ctors 
        public Dog() : this("", 0, DateTime.MinValue,"","") { }

        public Dog(string name, int expirience, DateTime birthdate, string informations, string description)
        {
            this.Name = name;
            this.Expirience = expirience;
            this.Birthdate = birthdate;
            this.Informations = informations;
            this.Description = description;
        }
        

    }
}