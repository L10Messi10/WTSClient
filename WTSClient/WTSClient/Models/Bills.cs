using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static WTSClient.App;

namespace WTSClient.Models
{
    public class Bills
    {
        public string Account_Number { get; set; }
        public string Fullname { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public async Task<string> MemberLogin(string ac_number)
        {
            try
            {
                var evaluateEmail = (await client
                .Child("Bills")
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

        public async Task<string> GetBills(string ac_number)
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
