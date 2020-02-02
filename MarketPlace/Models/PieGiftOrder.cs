﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    public class PieGiftOrder
    {
        [BindNever]
        public int PieGiftOrderId { get; set; }
        public Pie Pie { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the address")]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
