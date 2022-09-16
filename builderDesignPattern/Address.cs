using System;

namespace BuilderDesignPattern
{
    public class Address
    {
        public String HouseNumber { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String Zipcode { get; set; }

        public String State { get; set; }

        public Address(
            string houseNumber,
            string street,
            string city,
            string zipcode,
            string state)
        {
            this.HouseNumber = houseNumber;
            this.Street = street;
            this.City = city;
            this.Zipcode = zipcode;
            this.State = state;
        }
    }

}
