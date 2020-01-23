﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */

        public int groomBookingID { get; set; }
        public DateTime bookingDateTime { get; set; }


        //foreign keys
        public int groomerId { get; set; }
        [ForeignKey("GroomerID")]
        public virtual Groomer Groomer { get; set; }

        public int petId { get; set; }
        [ForeignKey("PetID")]
        public virtual Pet Pet { get; set; }

        public int ownerId { get; set; }
        [ForeignKey("OwnerID")]
        public virtual Owner Owner { get; set; }

        public ICollection<GroomService> groomServices { get; set; }

    }
}