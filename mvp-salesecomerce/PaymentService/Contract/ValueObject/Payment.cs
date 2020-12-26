using System;
using System.Linq;

namespace PaymentService.Contract.ValueObject
{
    public class Payment
    {
        public static string GenerateOrderNumber(int _length) {
            Random number = new Random();
            string words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(
                Enumerable.Repeat(words, _length).
                Select(x => x[number.Next(_length)]).ToArray()
                );
        }
    }
}