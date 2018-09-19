using System;

namespace LibraryData.Models {

    public class Hold {

        public int Id { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime DatePlaced { get; set; }

    }

}