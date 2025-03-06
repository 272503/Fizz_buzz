using System;
namespace C__.NET
{
    public class fizzbuzz
    {
        public fizzbuzz(int n)
        {
            List<string> res = new List<string>();

            for (int i = 1; i <= n; i++)
            {

                string s = "";

                if (i % 5 == 0 && i % 3 == 0) s += "Buzz";

                if (i % 3 == 0) s += "Fizz";

                if (i % 5 == 0) s += "Buzz";

                if (s == "") s += i.ToString();

                res.Add(s);
            }
        }
    }
}
