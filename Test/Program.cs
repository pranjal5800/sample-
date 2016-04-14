using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            List<Student> list = new List<Student>
            {
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
                new Student() { Rollno = 1, Name = "tim" ,DOB=DateTime.Now},
                new Student() { Rollno = 2, Name = "bob" ,DOB=DateTime.Now},
            };
            #endregion

            JavaScriptSerializer js = new JavaScriptSerializer();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = js.Serialize(list);
            watch.Stop();
            System.Console.WriteLine(".NET Serialize: " + watch.ElapsedMilliseconds);

            watch = System.Diagnostics.Stopwatch.StartNew();
            List<Student> s1 = js.Deserialize<List<Student>>(result);
            watch.Stop();
            System.Console.WriteLine(".NET Deserialize: " + watch.ElapsedMilliseconds);

            watch = System.Diagnostics.Stopwatch.StartNew();
            string result2 = JsonConvert.SerializeObject(list);
            //   Parallel.Invoke(() => result2 = serialize(list));
            watch.Stop();
            System.Console.WriteLine("Json.Net Serialize: " + watch.ElapsedMilliseconds);

            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            List<Student> s2 = JsonConvert.DeserializeObject<List<Student>>(result);
            //   Parallel.Invoke(() => s2 = JsonConvert.DeserializeObject<List<Student>>(result));
            watch3.Stop();
            System.Console.WriteLine("Json.Net Deserialize: " + watch3.ElapsedMilliseconds);


        }
        public static string serialize(List<Student> list)
        {
            return JsonConvert.SerializeObject(list);
        }
        public static List<Student> Deseriliaze(string result)
        {
            return JsonConvert.DeserializeObject<List<Student>>(result);
        }
    }
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}
