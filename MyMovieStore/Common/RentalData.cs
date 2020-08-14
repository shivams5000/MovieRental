﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieStore.Common
{
    public class RentalData
    {
        // Rent movie table variables - public properties
        public int RentId { get; set; }
        public int MovieId { get; set; }
        public int CustId { get; set; }
        public DateTime OnRentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int TotalRentAmount { get; set; }
    }
}
