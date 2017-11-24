using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class DataGenerator
    {
        private static readonly Random _random = new Random();

        public static String RandomString(int length)
        {
            const string chars = "ABCDEFGHIJLMNOPQRSTUVYWXZabcdefghijlmnopqrstuvywxz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(e => e[_random.Next(e.Length)]).ToArray());
        }
        public static String RandomString2(int length)
        {
            const string chars = "!@#$%¨&*()_+-={[]}?/;:.>,<|/";
            return new string(Enumerable.Repeat(chars, length).Select(e => e[_random.Next(e.Length)]).ToArray());
        }
    }
}
