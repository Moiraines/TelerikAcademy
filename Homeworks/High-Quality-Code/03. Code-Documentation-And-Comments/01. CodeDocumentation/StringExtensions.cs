//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik Academy">
//     Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class perform a string extensions contained several methods:
    /// <list type="bullet">
    /// <item>ToMD5Hash --> <see cref="ToMD5Hash"/></item>
    /// <item>ToBoolean --> <see cref="ToBoolean"/></item>
    /// <item>ToShort --> <see cref="ToShort"/></item>
    /// <item>ToInteger --> <see cref="ToInteger"/></item>
    /// <item>ToLong --> <see cref="ToLong"/></item>
    /// <item>ToDateTime --> <see cref="ToDateTime"/></item>
    /// <item>CapitalizeFirstLetter --> <see cref="CapitalizeFirstLetter"/></item>
    /// <item>GetStringBetween --> <see cref="GetStringBetween"/></item>
    /// <item>ConvertCyrillicToLatinLetters --> <see cref="ConvertCyrillicToLatinLetters"/></item>
    /// <item>ConvertLatinToCyrillicKeyboard --> <see cref="ConvertLatinToCyrillicKeyboard"/></item>
    /// <item>ToValidUsername --> <see cref="ToValidUsername"/></item>
    /// <item>ToValidLatinFileName --> <see cref="ToValidLatinFileName"/></item>
    /// <item>GetFirstCharacters --> <see cref="GetFirstCharacters"/></item>
    /// <item>GetFileExtension --> <see cref="GetFileExtension"/></item>
    /// <item>ToContentType --> <see cref="ToContentType"/></item>
    /// <item>ToByteArray --> <see cref="ToByteArray"/></item>
    /// </list>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Build a MD5Hash to a given string
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>generated MD5Hash</returns>
        public static string ToMD5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// test if a given string is a true-like value
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>a boolean value based if the string contains true-like values or not</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert a given string to a short value
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>the short value of the string</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Convert a given string to a integer value
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>the integer value of the string</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert a given string to a long value
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>the long value of the string</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert a given string to a DateTime
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>return the converted DateTime</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Set the first letter of given string to uppercase
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>the refined string with capital first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Extract a substring between two given strings
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <param name="startString">start of the substring</param>
        /// <param name="endString">end of the substring</param>
        /// <param name="startFrom">the start index of the substring</param>
        /// <returns>the found substring or empty string</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converter from cyrillic to latin letters
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>a transliterated latin word</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converter from latin to cyrillic letters
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>a transliterated cyrillic word</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// validation for a given string to a valid latin username
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>a valid username contained latin letters and digits</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// validation for a given string to a valid latin filename
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <returns>a valid latin filename and digits</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// get first n character of given string 
        /// </summary>
        /// <param name="input">the string which method is called for</param>
        /// <param name="charsCount">n - number of substring length we search for</param>
        /// <returns>substring from the first n characters of the string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// return the extension of a given file
        /// </summary>
        /// <param name="fileName">the file name which method is called for</param>
        /// <returns>return the file extension of the input file</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// return a content type based on the input file extension
        /// </summary>
        /// <param name="fileExtension">the file extension parameter which method is called for</param>
        /// <returns>content type depend on file extension</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert a string to arrays contains a bytes
        /// </summary>
        /// <param name="input">referent value of the string which the method takes when is called</param>
        /// <returns>array of bytes result from convert of every char of the input string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
