using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable<Age>
    {
        [...]

    public int CompareTo(Age that)
    }
    {return this.Age.CompareTo(that.Age);
    }}
    
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
        catch ( NotImplementedException )
{
    Console.WriteLine( "" );
}
catch ( Exception )
{
   
   throw;
}
    }
}