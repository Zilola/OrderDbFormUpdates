using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrderApplicationPage.Models
{
    public class Order
    {
        [Key ]
        public int Number { get; set; }

        [ DisplayName("Order Number"), Range(1000000000, 9999999999, ErrorMessage = "You need to enter a valid Order Number ")]
        public int OrderNumber { get; set; }

        [DisplayName ("First Name" ),Required(ErrorMessage = "You need to give your First Name ")]
        public string ShipToFirstName { get; set; }

        [DisplayName("Address"),Required(ErrorMessage = "You need to give your Address ")]
        public string ShipToAddress1 { get; set; }

        [DisplayName("Zip Code" ),Required(ErrorMessage = "You need to give your Zip Code ")]
        public string ShipToZipCode { get; set; }

        [DisplayName("Country Code"),Required(ErrorMessage = "You need to give your Country Code ")]
        public string ShipToCountryCode { get; set; }

        //Serialization is turning data into a linear "string" of bytes(object converting text)
       // public override string ToString() => JsonSerializer.Serialize<Order>(this);

    }
}
