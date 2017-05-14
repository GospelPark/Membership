using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GospelPark.Membership.Models
{
    public class Organization
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class Family
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
    }

    public class Address
    {
        public Guid Id { get; set; }
        public string Line1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class Person
    {
        public Guid Id { get; set; }
        public Family Family { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string GoesByName { get; set; }

    }
}