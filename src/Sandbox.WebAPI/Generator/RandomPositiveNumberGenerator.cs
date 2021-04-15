using System;
using System.Collections.Generic;

namespace Sandbox.WebAPI.Generator
{
    public class RandomPositiveNumberGenerator
    {
        public List<int> Generate(int quantity)
        {
            var values = new List<int>();

            var random = new Random();

            for (int i = 0; i < quantity; i++)
            {
                values.Add(random.Next());
            }

            return values;
        }
    }
}