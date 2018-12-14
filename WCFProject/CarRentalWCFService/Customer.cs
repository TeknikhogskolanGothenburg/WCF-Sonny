using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalWCFService
{
    [DataContract]
    public class Customer
    {
         [DataMember(Order = 1)]
         public int Id { get; set; }
         [DataMember(Order = 2)]
         public string Firstname { get; set; }
         [DataMember(Order = 3)]
         public string Lastname { get; set; }
         [DataMember(Order = 4)]
         public string Telephone { get; set; }
         [DataMember(Order = 5)]
         public string Email { get; set; }
    }
}
