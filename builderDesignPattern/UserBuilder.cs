using System;

namespace BuilderDesignPattern
{
    public interface IUserBuilder
    {
        IUserBuilder withFirstName(String firstName);

        IUserBuilder withLastName(String lastName);

        IUserBuilder withAddress(Address address);

        void Reset();

        User build();

        User getUser();
    }
}
