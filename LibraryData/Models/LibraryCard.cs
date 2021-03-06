﻿using System;
using System.Collections.Generic;

namespace LibraryData.Models {

    public class LibraryCard {

        public int Id { get; set; }

        public decimal Fees { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual IEnumerable<Checkout> Checkouts { get; set; }

    }

}