﻿/*
Task 1. class_123 in C#

Refactor the following examples to produce code with well-named C# identifiers.

class class_123
{
  const int max_count=6;
  class InClass_class_123
  {
    void Метод_нА_class_InClass_class_123(bool promenliva)
    {
      string promenlivaKatoString=promenliva.ToString();
      Console.WriteLine(promenlivaKatoString);
      }
  }       
  public static void Метод_За_Вход()
  {
    class_123.InClass_class_123 инстанция =
      new class_123.InClass_class_123();
    инстанция.Метод_нА_class_InClass_class_123(true); 
  }
}
 */

namespace BoolToStringPrinter
{
    public class TaskMain
    {
        ////never used in this part of code :)
        private const int MaxCount = 6;
        
        public static void Main()
        {
            BoolToStringPrinter instance = new BoolToStringPrinter();
            instance.BoolToString(true);
        }
    }
}
