using System;
using System.Collections.Generic;
using System.Text;

namespace WTSClient.Models
{
    public class Bills
    {
        public string Fullname { get; set; }
        public string Curr_Balance { get; set; }
        public string Curr_Reading { get; set; }
        public string Consumption { get; set; }
        public string Prev_Reading { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
    }
}
