using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models {

    public class CheckoutHistory {

        public int Id { get; set; }

        [Required]
        public Asset Asset { get; set; }

        [Required]
        public LibraryCard LibraryCard { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public DateTime? CheckInDate { get; set; }

    }

}