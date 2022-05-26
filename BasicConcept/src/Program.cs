using System;
using System.Linq;

namespace BasicConcept
{
    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns>An int.</returns>
        private static int Main(string[] args) => args[0] switch
        {
            "1" => Question1(),
            "2" => Question2(),
            "3" => Question3(),
            "4" => Question4(),
            "5" => Question5(),
            "6" => Question6(),
            "7" => Question7(),
            "8" => Question8(),
            "9" => Question9(),
            "10" => Question10(),
            "11" => Question11(),
            "12" => Question12(),
            "13" => Question13(),
            "14" => Question14(),
            "15" => Question15(),
            "16" => Question16(),
            "17" => Question17(),
            "18" => Question18(),
            "19" => Question19(),
            "20" => Question20(),
            _ => throw new NotImplementedException(),
        };

        /// <summary>
        /// Question1.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question1()
        {
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(11.5));
            
            return 1;
        }

        /// <summary>
        /// Question2.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question2()
        {
            var i = new int[0];
            Console.WriteLine(i[0]);

            return 2;
        }

        /// <summary>
        /// Question3.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question3()
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
            
            return 3;
        }

        /// <summary>
        /// Question4.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question4()
        {
            string str1 = "TechBeamers";
            string str2 = "TECHBEAMERS";

            var compareToResult = str1.CompareTo(str2);
            Console.WriteLine(compareToResult);
            
            return 4;
        }

        /// <summary>
        /// Question5.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question5()
        {
            char x = 'A';
            int i = 0;
            Console.WriteLine (true  ? x : 0);
            Console.WriteLine(false ? i : x); 
            
            return 5;
        }

        /// <summary>
        /// Question6.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question6()
        {
            char[] num = { '1', '2', '3' };
            Console.WriteLine(" char array: " + num);
          
            return 6;
        }

        #region Question7
        /// <summary>
        /// Question7.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question7()
        {
            Program obj = null;
            Console.WriteLine(Program.SaySomething());
            
            return 7;
        }
        /// <summary>
        /// Say something.
        /// </summary>
        /// <returns>A string.</returns>
        private static string SaySomething()
        {
            return "Hi, I am a Tech-savvy!!";
        }
        #endregion

        /// <summary>
        /// Question8.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question8()
        {
            string[] strings = { "abc", "def", "ghi" };

            strings.Select(@string =>
            {
                Console.WriteLine(@string);
                return @string;
            });

            return 8;
        }

        #region Question9
        /// <summary>
        /// Question9.
        /// </summary>
        /// <returns>An int.</returns>
        ///
        /// <remarks>
        /// A) Welcome,friends,to,TechBeamers
        /// B) Welcome**friends**to**TechBeamers
        /// C) Welcome*friends*to*TechBeamers
        /// D) Welcome friends to TechBeamers
        /// </remarks>
        private static int Question9()
        {
            StringDelegate str1 = new (Sample.DelegateSample);
            var str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);

            return 9;
        } 

        delegate string StringDelegate(string @string);

        private class Sample
        {
            /// <summary>
            /// Delegate sample.
            /// </summary>
            /// <param name="a">The a.</param>
            /// <returns>A string.</returns>
            public static string DelegateSample(string a)
            {
                return a.Replace(',', '*');
            }
        }
        #endregion

        #region Question10
        /// <summary>
        /// Question10.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question10()
        {
            ClassA objectOfClassB = new ClassB();
            Console.WriteLine(objectOfClassB.Print());

            ClassA objectOfClassC = new ClassC();
            Console.WriteLine(objectOfClassC.Print());

            return 10;
        }
 
        private class ClassA
        {
            /// <summary>
            /// Print.
            /// </summary>
            /// <returns>A string.</returns>
            public virtual string Print()
            {
                return nameof(ClassA);
            }
        }
 
        private class ClassB : ClassA
        {
            /// <summary>
            /// Print.
            /// </summary>
            /// <returns>A string.</returns>
            public override string Print()
            {
                return nameof(ClassB);
            }
        }
 
        private class ClassC : ClassB
        {
            /// <summary>
            /// Print.
            /// </summary>
            /// <returns>A string.</returns>
            public new string Print()
            {
                return nameof(ClassC);
            }
        }
        #endregion

        #region Question11 & Question12 - Exception
        /// <summary>
        /// Question12
        /// What would be the likely output?
        /// </summary>
        /// <remarks>
        /// A) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 267 
        /// B) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 271
        /// C) End.
        /// </remarks>
        /// <returns>An int</returns>
        private static int Question11()
        {
            try
            {
                throw new NotSupportedException();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            Console.WriteLine("End.");
        }

        /// <summary>
        /// Question12
        /// What would be the likely output?
        /// </summary>
        /// <remarks>
        /// A) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 293 
        /// B) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 297
        /// C) End.
        /// </remarks>
        /// <returns>An int</returns>
        private static int Question12()
        {
            try
            {
                throw new NotSupportedException();
            }
            catch (Exception exception)
            {
                throw;
            }
            Console.WriteLine("End.");
        }

        /// <summary>
        /// Question13.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question13()
        {
            try
            {
                Console.WriteLine("Begin Q13");
                throw new NullReferenceException();
                Console.WriteLine("End Q13");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Q13 Catch");
            }
            finally
            {
                Console.WriteLine("Q13 Finally");
            }

            Console.WriteLine("Q13 Done");

            return 13;
        }

        #endregion

        #region Question14
        /// <summary>
        /// Question14.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question14()
        {
            var i = 3;
            var j = 2;

            static void Double(ref int num)
            {
                num = num + num;
            }

            void Square(out int num)
            {
                num = i;
                num = num * num;
            }

            Double(ref i);
            Square(out j);
            Console.WriteLine(i + ", " + j);

            return 14;
        }
        #endregion

        /// <summary>
        /// Question15.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question15()
        {
            var a = "This is a \"string\"";
            var b = @"This is a ""string""";

            Console.WriteLine(a == b ? "Equal" : "NotEqual");

            return 15;
        }


        /// <summary>
        /// Question16.
        /// </summary>
        /// <remarks>
        /// A) 0a1a2a3a4a5a
        /// B) 0a1a2a3a4a
        /// C) 979899100101
        /// </remarks>
        /// <returns>An int.</returns>
        private static int Question16()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write(x + 'a');
            }

            return 16;
        }

        /// <summary>
        /// Question17.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question17()
        {
            float dividend = 56, divisor = 0;
 
            try
            {
                Console.WriteLine(dividend / divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
            }

            return 17;
        }

        #region Question18
        private enum Color: int
        { 
            Red, Green, Blue = 5, Cyan, Magenta = 10, Yellow 
        }
        /// <summary>
        /// Question18.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question18()
        {
            Console.WriteLine((int)Color.Green + ", ");
            Console.WriteLine((int)Color.Yellow);

            return 18;
        }
        #endregion

        #region Question19
        /// <summary>
        /// Question19.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question19()
        {
            Child child = new Child();
            int i = 10;
            child.Say(i);

            return 19;
        } 

        private class Parent
        {
            public virtual void Say(int x)
            {
                Console.WriteLine("Parent.Say(int)");
            }
        }
        private class Child : Parent
        {
            public override void Say(int x)
            {
                Console.WriteLine("Child.Say(int)");
            }
            public void Say(object o)
            {
                Console.WriteLine("Child.Say(object)");
            }
        }
        #endregion

        #region Question20
        public static int Q20 = 0;
        /// <summary>
        /// Question20.
        /// </summary>
        /// <returns>An int.</returns>
        private static int Question20()
        {
            (Q20++).TestQ20();

            return 20;
        }
        #endregion

    }

    internal static class IntExtensions
    {
        /// <summary>
        /// Test q20.
        /// </summary>
        /// <param name="int">The int.</param>
        public static void TestQ20(this int @int)
        {
            Console.WriteLine(Program.Q20);
            Console.WriteLine(@int);
        }
    }
}
