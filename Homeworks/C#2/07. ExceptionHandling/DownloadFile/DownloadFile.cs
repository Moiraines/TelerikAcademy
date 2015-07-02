//Task 4
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;   
    class DownloadFile
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"news-img01.png");
                Console.WriteLine("Done"); // image is downloaded in your current directory.
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null");
            }
            catch (WebException)
            {
                Console.WriteLine("File does not exist, its name is null or empty, address is invalid, or an error occurred while downloading data");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
