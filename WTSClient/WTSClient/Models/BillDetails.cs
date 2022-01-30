using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WTSClient.App;

namespace WTSClient.Models
{
    public class BillDetails
    {
        public string Curr_Balance { get; set; }
        public string Curr_Reading { get; set; }
        public string Consumption { get; set; }
        public string Prev_Reading { get; set; }
        public string PreviousBalance { get; set; }
        public string NewReading { get; set; }
        public string Charge { get; set; }
        public string Deposit { get; set; }
        public async Task<string> GetMyBillDetails(string ac_number)
        {
            try
            {
                var evaluateEmail = (await client
                .Child($"Bills/{ memberkey}/BillDetails")
                .OnceAsync<Bills>()).FirstOrDefault
                (a => a.Object.AccountNumber == ac_number);
                if (evaluateEmail != null)
                {
                    return evaluateEmail.Key;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
