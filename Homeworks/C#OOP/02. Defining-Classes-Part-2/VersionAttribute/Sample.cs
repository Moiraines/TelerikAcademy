namespace VersionAttribute
{
    using System;
    [Version("v. 2.10")]
    class Sample
    {
        static void Main()
        {
            Type type = typeof(Sample);
            object[] attr = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
