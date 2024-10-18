using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace IvrConsole
{
    internal class Program
    {
       public static Random rdn = new Random();
        static void Main(string[] args)
        {
            string constr = @"server=DESKTOP-2KPKJ12;Database=TicariPaket;Trusted_Connection=true;TrustServerCertificate=true";

            List<string> phoneNumber = new List<string>()
            {
                "0850 750 00 00",
                 "0850 750 10 00",
                  "0850 750 20 00",
                   "0850 750 30 00",
                    "0850 750 40 00",
                     "0850 750 50 00",
            };
            
            SqlConnection db = new SqlConnection(constr);
            for (int i = 0; i < 1000; i++)
            {
                var arama = new IvrLog
                {
                    ArayanNo = GenerateNumber(),
                    ArananNo = phoneNumber[rdn.Next(0,6)],
                    StartDate=DateTime.Now.AddDays(-2),
                    EndDate=DateTime.Now.AddDays(-2).AddMinutes(rdn.Next(1, 10)),
                    IvrNo=rdn.Next()
                }; 
                db.Insert<IvrLog>(arama);
            }
            //db.InsertAsync<IvrLog>();
            Console.WriteLine("Hello, World!");
        }
        public static string GenerateNumber()
        {
            return "5" + rdn.Next(0, 9).ToString() + rdn.Next(0, 9).ToString()
                +rdn.Next(0, 9).ToString() + rdn.Next(0, 9).ToString()
                + rdn.Next(0, 9).ToString() + rdn.Next(0, 9).ToString();
        }

    }
}
