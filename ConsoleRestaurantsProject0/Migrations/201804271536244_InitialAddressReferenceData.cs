using System.Collections.Generic;
using ConsoleRestaurantsProject0.DataModels;

namespace ConsoleRestaurantsProject0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAddressReferenceData : DbMigration
    {
        private readonly List<string> _restaurants = new List<string>()
        {
            "'Taco Bell'",
            "'McDonalds'",
            "'Chic-fil-a'",
            "'Chipotle'",
            "'Subway'",
            "'Jimmy Johns'",
            "'Starbucks'",
            "'Panda Express'",
            "'In-and-Out'",
            "'Dunkin Donuts'",
        };

        private readonly List<Address> _addresses = new List<Address>()
        {
            new Address() { Street = "'12345 123rd ST SW'", City = "'Seattle'", Zip = "'98765'", State = "'WA'" },
            new Address() { Street = "'12346 123rd ST SE'", City = "'Miami'", Zip = "'12351'", State = "'FL'" },
            new Address() { Street = "'12347 123rd ST NW'", City = "'New York City'", Zip = "'26649'", State = "'NY'" },
            new Address() { Street = "'12348 123rd ST NE'", City = "'Los Angeles'", Zip = "'88573'", State = "'CA'" },
            new Address() { Street = "'12349 123rd ST SW'", City = "'Houston'", Zip = "'66091'", State = "'TX'" },
            new Address() { Street = "'12340 123rd ST SE'", City = "'Chicago'", Zip = "'55534'", State = "'IL'" },
            new Address() { Street = "'12341 123rd ST NW'", City = "'Portland'", Zip = "'83700'", State = "'OR'" },
            new Address() { Street = "'12342 123rd ST NE'", City = "'Atlanta'", Zip = "'09812'", State = "'GA'" },
            new Address() { Street = "'12343 123rd ST SE'", City = "'San Francisco'", Zip = "'33537'", State = "'CA'" },
            new Address() { Street = "'12344 123rd ST NW'", City = "'Dallas'", Zip = "'65482'", State = "'TX'" },
        };

        public override void Up()
        {
            int i = 2;
            foreach (var a in _addresses)
            {
                Sql($"INSERT INTO Addresses" +
                    $"(Id, Street, City, Zip, State)" +
                    $"VALUES ({i}, {a.Street}, {a.City}, {a.Zip}, {a.State})");
                i++;
            }
        }
        
        public override void Down()
        {
            foreach (var a in _addresses)
            {
                Sql($"DELETE FROM Addresses WHERE Street == {a.Street}");
            }
        }
    }
}
