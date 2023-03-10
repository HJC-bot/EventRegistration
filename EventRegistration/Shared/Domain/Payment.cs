using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistration.Shared.Domain
{
    public class Payment :BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Payment type does notmeet length requirements")]
        public string Paymenttype { get; set; }
        public string Totalpayment { get; set; }
        public DateTime Paymentdateout { get; set; }
        public DateTime Paymentdatein { get; set; }
        public int Registrationid { get; set; }
        public virtual Registration Registration { get; set; }

    }
}
