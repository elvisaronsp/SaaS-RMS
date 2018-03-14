﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaaS_RMS.Models.Entities.System
{
    public class Restaurant
    {
        #region Model Data

        public long RestaurantId { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        [DisplayName("Company Name")]
        public string Name { get; set; }

        public string Motto { get; set; }

        public string Logo { get; set; }

        public DateTime SubscriprionStartDate { get; set; }

        public DateTime SubscriptonEndDate { get; set; }

        [DisplayName("Subscription Duration")]
        public string SubscriptionDuration { get; set; }

        [Required(ErrorMessage = "Location field is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Contact Email field is required")]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Contact Number field is required")]
        public string ContactNumber { get; set; }

        public string SetUpStatus { get; set; }

        [Required(ErrorMessage = "Access Code field is required")]
        public string AccessCode { get; set; }

        [DisplayName("Registration Number")]
        public string RegistrationNumber { get; set; }

        #endregion

        #region Foriegn Key

        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual State State { get; set; }

        public int LgaId { get; set; }
        [ForeignKey("LgaId")]
        public virtual Lga Lga { get; set; }

        #endregion

        #region Enumerables



        #endregion
    }
}
