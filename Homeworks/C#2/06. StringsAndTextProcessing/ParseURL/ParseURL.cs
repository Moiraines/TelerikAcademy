//Task 12
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:
//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("Enter a URL: ");
            string input = Console.ReadLine();
            //string input = "http://telerikacademy.com/Courses/Courses/Details/212";

            StringBuilder protocol = new StringBuilder(); ;
            StringBuilder server = new StringBuilder(); ;
            StringBuilder resource = new StringBuilder(); ;
            bool inProtocol = true;
            bool inServer = false;
            bool inResource = false;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == ':')
                {
                    inProtocol = false;
                }

                if (input[i] == '/' && input[i-1] == '/')
                {
                    inServer = true;
                    continue;
                }
                else if (input[i] == '/' && inServer == true)
                {
                    inServer = false;
                    inResource = true;
                }

               



                if (inProtocol == true)
                {
                    protocol.Append(input[i]);
                }

                if (inServer == true)
                {
                    server.Append(input[i]);
                }

                if (inResource == true)
                {
                    resource.Append(input[i]);
                }
            }

            Console.WriteLine("[protokol]= {0}", protocol);
            Console.WriteLine("[server]= {0}", server);
            Console.WriteLine("[resource]= {0}", resource);

        }
    }
