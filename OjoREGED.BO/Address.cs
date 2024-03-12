﻿using System;

namespace OjoREGED.BO
{
    public class Address
    {
        public int Address_ID { get; set; }
        public int Customer_ID { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Street_Address { get; set; }
        public string Postal_Code { get; set; }
        public DateTime Modified_Date { get; set; }

        public Customer Customer { get; set; }

    }
}
