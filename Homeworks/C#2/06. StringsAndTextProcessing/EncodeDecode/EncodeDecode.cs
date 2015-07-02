//Task 7
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter a cipher:");
            string key = Console.ReadLine();
            Console.WriteLine("Enter a text for crypting: ");
            string text = Console.ReadLine();

            string decryptedtext = EncodingDecoding(text, key);

            string Encryptedtext = EncodingDecoding(decryptedtext, key);

            Console.WriteLine("The input text is Equal to encrypted text -> {0}", text == Encryptedtext);
          

        }

        static string EncodingDecoding(string input, string key)
        {
            StringBuilder cryptedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                cryptedInput.Append((char)(input[i] ^ key[i % key.Length]));
            }
           return cryptedInput.ToString();
        }
    }
