﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Messenger_Kings.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        public string Driver_ID { get; set; }

        //[Required(ErrorMessage = "ID number is required")]
        [DisplayName("ID Number")]
        public string Driver_IDNo { get; set; }

        //[Required(ErrorMessage = "First name is required")]
        [DisplayName("First name")]
        public string Driver_Name { get; set; }


        [DisplayName("Image")]
        public byte[] Diver_Image { get; set; }

        //[Required(ErrorMessage = "Last name is required")]
        [DisplayName("Last name ")]
        public string Driver_Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        //[Required(ErrorMessage = "Contact number is required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                  ErrorMessage = "Entered Contact number format is not valid.")]
        public string Driver_CellNo { get; set; }

       // [Required(ErrorMessage = "Residence address is required")]
        [DisplayName("Residence address")]
        public string Driver_Address { get; set; }

        //[Required(ErrorMessage = "Email address is required")]
        [DisplayName("Email address")]
        [EmailAddress]
        public string Driver_Email { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual List<ClientSignature> ClientSignatures { get; set; }

        public virtual List<Waybill> Waybills { get; set; }

        public virtual List<Comment> Comment { get; set; }

        //public string Vehicle_ID { get; set; }//(VIN)
        //public virtual Vehicle Vehicle { get; set; }

        //public virtual List<Document> Documents { get; set;}

        //public virtual List<Bank> Banks { get; set; }

    }
}