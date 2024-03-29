﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

    
        public override string ToString()
        {
            return $"Astronaut: {this.Name}, {this.Age} ({this.Country})";
        }

    }
}
