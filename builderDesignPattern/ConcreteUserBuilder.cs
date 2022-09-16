using System;

namespace BuilderDesignPattern
{
    public class ConcreteUserBuilder : IUserBuilder
    {
        private String FirstName { get; set; }

        private String LastName { get; set; }

        private String Address { get; set; }

        private User User { get; set; }

        public IUserBuilder withFirstName(String firstName)
        {
            FirstName = firstName;
            return this;
        }

        public IUserBuilder withLastName(String lastName)
        {
            LastName = lastName;
            return this;
        }

        public IUserBuilder withAddress(Address address)
        {
            this.Address = address.Street + "\n" + address.City + "\n" + address.State + " " + address.Zipcode;
            return this;
        }

        public User build()
        {
            User = new User(FirstName + LastName, Address);
            return User;
        }

        public User getUser()
        {
            return User;
        }

        public void Reset()
        {
            this.User = new User();
        }
    }
}