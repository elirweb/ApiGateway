using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Util
{
    public static class ValuePayment
    {
        public static string GenerateOrderNumber(int _length)
        {
            Random number = new Random();
            string words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(
                Enumerable.Repeat(words, _length).
                Select(x => x[number.Next(_length)]).ToArray()
                );
        }
    }
}
