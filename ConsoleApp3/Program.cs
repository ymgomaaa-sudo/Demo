namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            Console.WriteLine("Hello, World!");

            Student student;
            //allocate 4 bytes in stack =>Null
            //0 byte in heap 
            student = new Student();
            //allocate required types in Heap =8b
            //Intialize Data[Id ,Age]
            //referance  => object , data 
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Age);
            Student S01 = new Student();
            S01.Id = 1;
            S01.Age = 10;
            Student S02 = S01;
            Console.WriteLine(S01.Id);
            S02.Id++;
            Console.WriteLine(S01.Id);
            #endregion
          


           


        }
    }
}
