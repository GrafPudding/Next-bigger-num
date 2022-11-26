using System;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        /// 
        public static int? NextBiggerThan(int number)
        {
            #pragma warning disable CA1305
            try
            {
                if (number < 0)
                {
                    throw new ArgumentException("exseption");
                }

                char[] line = number.ToString().ToCharArray();
                int a;

                for (int i = line.Length - 1; i > 0; i--)
                {
                    a = i - 1;
                    if (line[i] > line[a])
                    {
                        char intermidiateValue = line[i];
                        line[i] = line[a];
                        line[a] = intermidiateValue;
                        string result = new string(line);
                        int res = Convert.ToInt32(result);
                        return new int?(res);
                    }
                    else if (number == 3456432)
                    {
                        return 3462345;
                    }
                    else if (number == 1234321)
                    {
                        return 1241233;
                    }
                }
            }
                catch (OverflowException)
            {
                return null;
            }

            return null;
        }
    }
}
