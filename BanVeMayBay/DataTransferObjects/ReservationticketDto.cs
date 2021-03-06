﻿using BanVeMayBay.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanVeMayBay.DataTransferObjects
{
    public class ReservationticketDto : BaseDto
    {
        public string Code { get; set; }
        public DateTime BookDate { get; set; }
        public int NumSeatBook { get; set; }
        public BookStatus Status { get; set; }
        public CustomerDto Customer { get; set; }
        public FlightDto Flight { get; set; }
        public Ticketclass Ticketclass { get; set; }
    }
}