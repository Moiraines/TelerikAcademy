namespace Problem_06
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /*
    (*) A text file phones.txt holds information about people, their town and phone number:

        Mimi Shmatkata          | Plovdiv  | 0888 12 34 56
        Kireto                  | Varna    | 052 23 45 67
        Daniela Ivanova Petrova | Karnobat | 0899 999 888
        Bat Gancho              | Sofia    | 02 946 946 946
        Duplicates can occur in people names, towns and phone numbers. Write a program to read the phones file 
        and execute a sequence of commands given in the file commands.txt:
        
        find(name) – display all matching records by given name (first, middle, last or nickname)
        find(name, town) – display all matching records by given name and town
    */
    public class StartUp
    {
        public static void Main()
        {
            var phones = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            using (StreamReader reader = new StreamReader(@"../../phones.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var lineParts = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = lineParts[0].Trim();
                    var town = lineParts[1].Trim();
                    var phone = lineParts[2].Trim();

                    if (phones.ContainsKey(name))
                    {
                        if (phones[name].ContainsKey(town))
                        {
                            phones[name][town].Add(phone);
                        }
                        else
                        {
                            phones[name].Add(town, new HashSet<string>() { phone });
                        }
                    }
                    else
                    {
                        phones.Add(name, new Dictionary<string, HashSet<string>>()
                        {
                            { town, new HashSet<string>() { phone }} 
                        });
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(@"../../commands.txt"))
            {
                var lineCount = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    lineCount++;
                    var start = line.IndexOf("(");
                    var end = line.IndexOf(")");
                    var commandParameters = line.Substring(start + 1, end - start - 1);
                    var parameters = commandParameters.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parameters.Length == 1)
                    {
                        var name = parameters[0].Trim();
                        if (phones.ContainsKey(name))
                        {
                            foreach (var item in phones[name])
                            {
                                foreach (var phone in item.Value)
                                {
                                    Console.WriteLine("Name: {0}, City: {1}, Phone: {2};", name, item.Key, phone);
                                }
                            }
                        }
                    }
                    else if (parameters.Length == 2)
                    {
                        var name = parameters[0].Trim();
                        var city = parameters[1].Trim();

                        if (phones.ContainsKey(name))
                        {
                            if (phones[name].ContainsKey(city))
                            {
                                foreach (var phone in phones[name][city])
                                {
                                    Console.WriteLine("Name: {0}, City: {1}, Phone: {2};", name, city, phone);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number of paramaters on line {0}", lineCount);
                    }

                    line = reader.ReadLine();
                }

            }
        }
    }
}
