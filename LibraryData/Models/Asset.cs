﻿using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models {

    public class Asset {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public string ImageUrl { get; set; }

        public int NumberOfCopies { get; set; }

        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

    }

}