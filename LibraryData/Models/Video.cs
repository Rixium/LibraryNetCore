using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models {

    public class Video : Asset {

        [Required]
        public string Director { get; set; }

    }

}