namespace RfidbasedAirportSecurity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<RfidbasedAirportSecurity.Models.RfidbasedAirportSecurityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RfidbasedAirportSecurity.Models.RfidbasedAirportSecurityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.RfidInventories.AddOrUpdate(new RfidInventory[] {
                new RfidInventory() { RFID_ID = "read000", Device_Type = "Reader", Status = "Active"},
                new RfidInventory() { RFID_ID = "read001", Device_Type = "Reader", Status = "Active"},
                new RfidInventory() { RFID_ID = "read002", Device_Type = "Reader", Status = "Active"},
                new RfidInventory() { RFID_ID = "read003", Device_Type = "Reader", Status = "Active" },
                new RfidInventory() { RFID_ID = "read004", Device_Type = "Reader", Status = "Active" },
                new RfidInventory() { RFID_ID = "read005", Device_Type = "Reader", Status = "Active" },
                new RfidInventory() { RFID_ID = "pass001", Device_Type = "Tag", Status = "Active"},
                new RfidInventory() { RFID_ID = "pass002", Device_Type = "Tag", Status = "Active"},
                new RfidInventory() { RFID_ID = "pass003", Device_Type = "Tag", Status = "Active"},
                new RfidInventory() { RFID_ID = "lugg001", Device_Type = "Tag", Status = "Active"},
                new RfidInventory() { RFID_ID = "lugg002", Device_Type = "Tag", Status = "Active"},
                new RfidInventory() { RFID_ID = "lugg003", Device_Type = "Tag", Status = "Active"},
            }
            );

            context.PassengerAreaAccesses.AddOrUpdate(new PassengerAreaAccess[] 
            {
                new PassengerAreaAccess() {ZoneId="D3", RFID_ID="pass001", Role="Passenger"},
                new PassengerAreaAccess() {ZoneId="C1", RFID_ID="pass002", Role="Passenger"},
                new PassengerAreaAccess() {ZoneId="E1", RFID_ID="pass003", Role="Passenger"},
            });

            context.ZoneAccessMetaDatas.AddOrUpdate(new ZoneAccessMetaData[] {
                new ZoneAccessMetaData() {Role="Passenger", ClassType="A",B1= true, C1=true, D3=true, E1=true,F1=false,G1=false},
                new ZoneAccessMetaData() {Role="Passenger", ClassType="B",B1= true, C1=true, D3=false, E1=true,F1=false,G1=false},
                new ZoneAccessMetaData() {Role="Passenger", ClassType="A",B1= true, C1=true, D3=true, E1=true,F1=true,G1=true},
                new ZoneAccessMetaData() {Role="Passenger", ClassType="B",B1= true, C1=true, D3=true, E1=true,F1=true,G1=false},

            });

            context.ZoneInfoMetaDatas.AddOrUpdate(new ZoneInfoMetaData[]
            {
                new ZoneInfoMetaData() {ZoneId="B1", RFID_ID="read000", Lat_Long=""},
                new ZoneInfoMetaData() {ZoneId="C1", RFID_ID="read001", Lat_Long=""},
                new ZoneInfoMetaData() {ZoneId="D3", RFID_ID="read002", Lat_Long=""},
                new ZoneInfoMetaData() {ZoneId="E1", RFID_ID="read003", Lat_Long=""},
                new ZoneInfoMetaData() {ZoneId="F1", RFID_ID="read004", Lat_Long=""},
                new ZoneInfoMetaData() {ZoneId="G1", RFID_ID="read005", Lat_Long=""},
            });

            context.FlightDetails.AddOrUpdate(new FlightDetails[]
            {
                new FlightDetails() {Flight_Id="Alaska12", Source="Seattle", Destination="San Jose", Boarding_Gate="C3", Status = "", Belt_Id= ""},
                new FlightDetails() {Flight_Id="Delta12", Source="Seattle", Destination="Austin", Boarding_Gate="D2", Status = "", Belt_Id= ""},
                new FlightDetails() {Flight_Id="United12", Source="Seattle", Destination="New York", Boarding_Gate="E4", Status = "", Belt_Id= ""},
                new FlightDetails() {Flight_Id="Alaska10", Source="San Jose", Destination="Seattle", Boarding_Gate="", Status = "Arrived", Belt_Id= "J2"},

            });

            context.PassengerDetails.AddOrUpdate(new PassengerDetails[]
            {
                new PassengerDetails() {PassengerId = "stark1234", Name="Tony Stark", PNR = "PNR000", RFID_ID = "pass001", Flight_Id = "Alaska12", Email_id="tony.stark@gmail.com",
                Tracking=false, Rfid_Status = "Active", Status_Reason="", IdProofType="Passport", PassengerType="A"},


                new PassengerDetails() {PassengerId = "banner1234", Name="Bruce Banner", PNR = "PNR001", RFID_ID = "pass002", Flight_Id = "United12", Email_id="bruce.banner@gmail.com",
                Tracking=true, Rfid_Status = "disabled", Status_Reason="Suspicious", IdProofType="Driving License", PassengerType="B"},


                new PassengerDetails() {PassengerId = "diana1234", Name="Princess Diana", PNR = "PNR002", RFID_ID = "pass003", Flight_Id = "United12", Email_id="princess.diana@gmail.com",
                Tracking=false, Rfid_Status = "Active", Status_Reason="", IdProofType="Passport", PassengerType="A"},
            });

            context.Luggages.AddOrUpdate(new Luggage[]
            {
                new Luggage() { Luggage_RFID_Id="lugg001", Passenger_ID="pass001", Flight_Id="Alaska12", Luggage_Location="H2", Luggage_Stage="LoadedOnFlight"},
                new Luggage() { Luggage_RFID_Id="lugg002", Passenger_ID="pass001", Flight_Id="Alaska12", Luggage_Location="H2", Luggage_Stage="LoadedOnFlight"},
                new Luggage() { Luggage_RFID_Id="lugg003", Passenger_ID="pass002", Flight_Id="United12", Luggage_Location="H1", Luggage_Stage="LoadedOnFlight"},
                new Luggage() { Luggage_RFID_Id="lugg004", Passenger_ID="pass003", Flight_Id="United12", Luggage_Location="A3", Luggage_Stage="LoadedOnFlight"},
            });




        }
    }
}
