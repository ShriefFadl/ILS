using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fury.Models
{
    public class Production

    {
        [Required]
        [MaxLength(5)]
        [Key]
        public string FSCM  { get; set; }
        [Required]
        [MaxLength(32)]
        [Display(Name ="Part Number")]
        public string Part_num { get; set; }
        [Required]
        [MaxLength(15)]
        [Display(Name = "Serial Number")]
        public string Serial_Num { get; set; }

        public DateTime Date_submit = DateTime.Now;
        [Required]
        [MaxLength(9)]
        public string NiiN { get; set; }
        //public IEnumerable { get; set; }
        public workshop workshop { get; set; }
        public IEnumerable<workshop> workshops { get; set; }
    }

    public class workshop
    {
        public int ID { get; set; }
        public string name { get; set; }
    }
}