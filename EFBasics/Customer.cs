﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasics
{
    public class Customer
    {
        private string _customerID;
        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value.ToUpper();
            }
        }
        public string CompanyName { get; set; }
        
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }


    }
}
