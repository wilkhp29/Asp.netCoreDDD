using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Stores
    {
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public Address DrugstoreAddress { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerEmail { get; set; }
    }
}
