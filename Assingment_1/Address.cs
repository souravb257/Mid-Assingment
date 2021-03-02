using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment_1
{
    class Address
    {
        private int roadNo;
        private int houseNo;
        private string city;
        private string country;

        public Address(int houseNo, int roadNo, string city, string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
            this.country = country;
        }

        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address:House No-{0}, Road No-{1}, City-{2}, Country-{3}", this.houseNo, this.roadNo, this.city, this.country);
        }
    }
}
