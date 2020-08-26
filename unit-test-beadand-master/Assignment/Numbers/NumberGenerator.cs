using System;

namespace Assignment.Numbers
{
    public class NumberGenerator : INumberGenerator
    {
        private Random random = new Random();

        /// <summary>
        /// Generates a random positive even number.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>A random positive even number between [0..limit]</returns>
        public int GenerateEven(int limit)
        {
			if (limit < 0)
				throw new ArgumentOutOfRangeException("Limit cannot be negative");

			return random.Next(limit / 2) * 2;
        }

        /// <summary>
        /// Generates a random positive odd number.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>A random positive odd number between [1..limit]</returns>
        public int GenerateOdd(int limit)
        {
            if (limit < 1)
                throw new ArgumentOutOfRangeException("Limit cannot be less than 1");

            return random.Next(limit / 2) * 2 + 1;
        }
    }
}

