using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_3
{
    // Task 3
    public class RandomDataManager
    {
        private List<string> randomStr = new List<string>();

        public void BeforeTransformation()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 107; i++)
            {
                builder.Clear();
                for (int j = 0; j < 4; j++)
                {
                    builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
                }
                randomStr.Add(builder.ToString());
            }
            Console.WriteLine($"Before transformation length = {randomStr.Count}");
        }

        public void AfterTransformation()
        {
            HashSet<string> uniqueStrings = new HashSet<string>(randomStr);
            List<string> uniquesAndWithoutLetterZ = new List<string>();

            foreach (var s in uniqueStrings)
            {
                if (!s.StartsWith("Z"))
                {
                    uniquesAndWithoutLetterZ.Add(s);
                }                
            }

            randomStr = uniquesAndWithoutLetterZ;
            randomStr.Sort();
            randomStr.Reverse();            

            Console.WriteLine($"After transformation length = {randomStr.Count}");
        }

        public void DisplayPage(int pageNumber)
        {
            const int itemsOnPage = 5;
            int numberOfPages = (int)Math.Ceiling((double)randomStr.Count / itemsOnPage);
            if (pageNumber <= 0 || pageNumber > numberOfPages)
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
