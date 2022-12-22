using Problems.UserInteraction;

namespace Problems.Problems
{
    public class Romans
    {
        private RomansUserInteraction romansUserInteraction;

        public Romans()
        {
            romansUserInteraction = new RomansUserInteraction();
        }
         
        private readonly int[] Units = 
            new int[] {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};

        public void Run()
        {
            var necessaryUnits = GetNecessaryUnits(romansUserInteraction.OriginalInput);

            var stringForms = ConvertToStringForm(necessaryUnits);

            romansUserInteraction.DisplayResult(stringForms);
        }

        /// <summary>
        /// Takes a list of Units and converts each to it's string representation.
        /// </summary>
        /// <param name="intForm"></param>
        /// <returns></returns>
        private List<string> ConvertToStringForm(List<int> intForms)
        {
            var numeralDictionary = new Dictionary<int, string>
            {
                {1, "I" },
                {4, "IV" },
                {5, "V" },
                {9, "IX" },
                {10, "X" },
                {40, "XL" },
                {50, "L" },
                {90, "XC" },
                {100, "C" },
                {400, "CD" },
                {500, "D" },
                {900, "CM" },
                {1000, "M" },
            };

            var result = new List<string>();

            foreach(var intForm in intForms)
            {
                result.Add(numeralDictionary[intForm]);
            }

            return result;
        }

        private List<int> GetNecessaryUnits(int input)
        {
            var necessaryUnits = new List<int>();

            var remainder = input;

            while(remainder > 0)
            {
                var largestSmallerUnit = GetLargestSmallerUnit(remainder);
                necessaryUnits.Add(largestSmallerUnit);
                remainder -= largestSmallerUnit;
            }

            return necessaryUnits;
        }

        private int GetLargestSmallerUnit(int input)
        {
            var result = 0;
            foreach(var unit in Units)
            {
                if (unit <= input)
                {
                    if (result <= unit) result = unit;
                }
                else break;
            }

            return result;
        }

    }
}
