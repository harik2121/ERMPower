using System;

namespace ERMPower.common.POM
{
    public static class DataHelpers
    {
    private const string DayFormat = "ddd";

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
