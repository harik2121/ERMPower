using System;
using NUnit.Framework;

namespace ERMPower.common.POM
{
    public static class DataHelpers
    {
    private const string DayFormat = "ddd";

        public class DeliveryDetails
        {
            public string Email { get; set; }
            public string Confirmemail { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Phone { get; set; }
            public string Addressline1 { get; set; }
            public string Addressline2 { get; set; }
            public string Suburb { get; set; }
            public string State { get; set; }
            public string Postcode { get; set; }

        }
        public static string RandomPhone
        {
            get
            {
                var random = new Random();
                return String.Format("04{0}{1}", random.Next(1111, 9999), random.Next(1111, 9999));
            }
        }

        public static string RandomEmail
        {
            get
            {
                return string.Format("{0}@gmail.com", Guid.NewGuid().ToString());
            }
        }
        public static string Today
        {
            get { return DateTime.Now.ToString(DayFormat).Substring(0, 3); }
        }
    }
}
