using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix.ServicesAPI.Data.Entities
{
    public class Estimate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Answer()
        {
            this.Options = new HashSet<Option>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int RequestsMow { get; set; }
        public int RequestsBlow { get; set; }
        public int RequestsEdge { get; set; }
        public int Estimate { get; set; }
        public int AreaInSquareFeet { get; set; }

    }
}