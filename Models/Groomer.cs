﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate
                */
        [Key]
        public int groomerId { get; set; }
        public string firstName { get; set; }
        public double lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int phoneNumber { get; set; }
        public double hourlyRate { get; set; }
        public DateTime hireDate { get; set; }
        /*
            A booking must reference to a groomer
        */
    }
}