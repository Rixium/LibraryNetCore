using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models {

    public class Checkout {

        public int Id { get; set; }

        [Required]
        public Asset Asset { get; set; }

        public LibraryCard LibraryCard { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime DueDate { get; set; }

    }

}