
namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int count)
        {
            string currentString = strBuilder.ToString();
            StringBuilder result = new StringBuilder(count);

            if (index < 0 || index > currentString.Length - 1)
            {
                throw new IndexOutOfRangeException("Starting index must be in the range [0, string.Length)");
            }

            if (count < 0 || index + count > currentString.Length - 1)
            {
                throw new ArgumentException("Count must be >= 0 and index + count must be < string.Length");
            }

            for (int i = index; i < index + count; i++)
            {
                result.Append(currentString[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder strBuilder, int index)
        {
            string currentString = strBuilder.ToString();
            StringBuilder result = new StringBuilder(currentString.Length - index);

            if (index < 0 || index > currentString.Length - 1)
            {
                throw new IndexOutOfRangeException("Starting index must be in the range [0, string.Length)");
            }

            for (int i = index; i < currentString.Length; i++)
            {
                result.Append(currentString[i]);
            }

            return result;
        }
    }
}
