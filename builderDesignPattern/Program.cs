using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteUserBuilder();
            var user = Director(builder);
            Console.WriteLine(user);
        }

        private static User Director(IUserBuilder builder)
        {
            return builder
                .withFirstName("leo")
                .withLastName("messi")
                .withAddress(new Address("200", "D'youville", "Sherbrooke", "J2L3JZ", "QC"))
                .build();
        }
    }
}
