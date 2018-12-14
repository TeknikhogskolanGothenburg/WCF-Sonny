using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWCFService
{
    [DataContract]
    public class Booking
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public int CarId { get; set; }
        [DataMember(Order = 3)]
        public int CustomerId { get; set; }
        [DataMember(Order = 4)]
        public DateTime FromDate { get; set; }
        [DataMember(Order = 5)]
        public DateTime ToDate { get; set; }
        [DataMember(Order = 6)]
        public bool IsReturned { get; set; }
    }
}
