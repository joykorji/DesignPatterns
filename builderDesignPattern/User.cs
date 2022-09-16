using System;

namespace BuilderDesignPattern
{
    public class User
    {
        public String Name { get; set; }

        public string Address { get; set; }

        public User(){}

        public User(String name, String address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override String ToString()
        {
            return "name=" + Name + "\naddress=" + Address;
        }
    }
}
