using System;

namespace RetrieveStudentsData
{
    class RetrieveStudentsData
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"E:\VS_C#_Programs\Phase1_Assignments\Retrieve_Students_Data\StudentsData.txt");

            // To display the file contents 
            System.Console.WriteLine("\nContents of Students Data Text File:\n{0}", text);
            System.Console.ReadKey();
        }
    }
}
