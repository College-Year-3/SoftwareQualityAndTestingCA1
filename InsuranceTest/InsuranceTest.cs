using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2;

using static WebApplication2._Default;

namespace InsuranceTest 
{
    public class InsuranceTest // ColumnFixture
    {
        public static InsuranceService SUT;
        public static int  vehicleValue;
        public static string comp3rd;
        public static DateTime dob;
        public static int penPoin;

        public float premium()
        {
            SUT = new InsuranceService();
            return SUT.CalculateQuote(vehicleValue, comp3rd, dob, penPoin);
        }

    }
}
