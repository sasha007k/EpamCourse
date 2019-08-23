using System;
using System.Collections.Generic;

namespace HomeWork_3
{
    // Task 3
    public class RandomDataManager
    {
        public List<string> randomStr = new List<string>();

        private int CountListLength()
        {
            int length = 0;
            foreach (var w in randomStr)
            {
                length++;
            }

            return length;
        }

        public void BeforeTransformation()
        {
            Random random = new Random();
            string randWord;
            for (int i = 0; i < 77777; i++)
            {
                randWord = "";
                for (int j = 0; j < 4; j++)
                {
                    randWord += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                }
                randomStr.Add(randWord);
            }            

            Console.WriteLine("Before transformation length = " + CountListLength());
        }

        public void AfterTransformation()
        {
            HashSet<string> uniqueStrings = new HashSet<string>(randomStr);
            randomStr = new List<string>(uniqueStrings);

            foreach (var w in randomStr.ToArray())
            {
                if (w.StartsWith("Z"))
                {
                    randomStr.Remove(w);
                }
            }

            randomStr.Sort();
            randomStr.Reverse();            

            Console.WriteLine("After transformation length = " + CountListLength());
        }

        public void DisplayPage(int pageNumber)
        {
            const int itemsOnPage = 5;
            int length = CountListLength() / itemsOnPage;
            if (pageNumber <= 0 || pageNumber > length)
            {
                Console.WriteLine("No such page");
                return;
            }
            int i = (pageNumber - 1) * itemsOnPage;
            for (; i < (pageNumber * itemsOnPage); i++)
            {
                Console.WriteLine(randomStr[i]);
            }
        }
    }
}
