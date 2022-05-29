using System;
using System.Linq;
using System.Reflection;

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
        private static void Main(string[] args) 
        {
            while (true)
            {
                var seq = Console.ReadLine();

                if (int.TryParse(seq, out var _))
                {
                    try
                    {
                        typeof(Program).GetMethod($"Question{seq}", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Question1.
        /// </summary>
        private static void Question1()
        {
            Console.WriteLine(Math.Round(7.5));
            Console.WriteLine(Math.Round(22.5));
        }

        /// <summary>
        /// Question2.
        /// </summary>
        private static void Question2()
        {
            var i = new int[0];
            Console.WriteLine(i[0]);
        }

        /// <summary>
        /// Question3.
        /// </summary>
        private static void Question3()
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
        }

        /// <summary>
        /// Question4.
        /// </summary>
        private static void Question4()
        {
            string str1 = "TechBeamers";
            string str2 = "TECHBEAMERS";

            var compareToResult = str1.CompareTo(str2);
            Console.WriteLine(compareToResult);
        }

        /// <summary>
        /// Question5.
        /// </summary>
        private static void Question5()
        {
            char x = 'A';
            int i = 0;
            Console.WriteLine (true  ? x : 0);
            Console.WriteLine(false ? i : x);
        }

        /// <summary>
        /// Question6.
        /// </summary>
        private static void Question6()
        {
            char[] num = { '1', '2', '3' };
            Console.WriteLine(" char array: " + num);
        }

        #region Question7
        /// <summary>
        /// Question7.
        /// </summary>
        private static void Question7()
        {
            Program obj = null;
            Console.WriteLine(Program.SaySomething());
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
        private static void Question8()
        {
            string[] strings = { "abc", "def", "ghi" };

            strings.Select(@string =>
            {
                Console.WriteLine(@string);
                return @string;
            });
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
        private static void Question9()
        {
            StringDelegate str1 = new (Q9.DelegateSample);
            var str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
        } 

        delegate string StringDelegate(string @string);

        private class Q9
        {
            /// <summary>
            /// Delegate sample.
            /// </summary>
            /// <param name="a">The a.</param>
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
        private static void Question10()
        {
            ClassA objectOfClassB = new ClassB();
            Console.WriteLine(objectOfClassB.Print());

            ClassA objectOfClassC = new ClassC();
            Console.WriteLine(objectOfClassC.Print());
        }
 
        private class ClassA
        {
            /// <summary>
            /// Print.
            /// </summary>
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
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 233
        /// B) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 237
        /// C) End.
        /// </remarks>
        private static void Question11()
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
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 258
        /// B) Unhandled exception. System.NotSupportedException: Specified method is not supported.
        ///     at BasicConcept.Program.Question11() in D:\Documents\NLTD\CGI\Team\Interview\RemoteInterview\BasicConcept\src\Program.cs:line 262
        /// C) End.
        /// </remarks>
        private static void Question12()
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
        private static void Question13()
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
        }

        #endregion

        #region Question14
        /// <summary>
        /// Question14.
        /// </summary>
        private static void Question14()
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
        }
        #endregion

        /// <summary>
        /// Question15.
        /// </summary>
        private static void Question15()
        {
            var a = "This is a \"string\"";
            var b = @"This is a ""string""";

            Console.WriteLine(a == b ? "Equal" : "NotEqual");
        }


        /// <summary>
        /// Question16.
        /// </summary>
        /// <remarks>
        /// A) 0a1a2a3a4a5a
        /// B) 0a1a2a3a4a
        /// C) 979899100101
        /// </remarks>
        private static void Question16()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write(x + 'a');
            }
        }

        /// <summary>
        /// Question17.
        /// </summary>
        private static void Question17()
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
        }

        #region Question18
        private enum Color: int
        { 
            Red, Green, Blue = 5, Cyan, Magenta = 10, Yellow 
        }
        /// <summary>
        /// Question18.
        /// </summary>
        private static void Question18()
        {
            Console.WriteLine((int)Color.Green + ", ");
            Console.WriteLine((int)Color.Yellow);
        }
        #endregion

        #region Question19
        /// <summary>
        /// Question19.
        /// </summary>
        private static void Question19()
        {
            Child child = new Child();
            int i = 10;
            child.Say(i);
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

        /// <summary>
        /// Question20.
        /// </summary>
        private static void Question20()
        {
            int[] arr = { 1, 2, 3 };
            int i = 1;
            arr[i++] = arr[i] + 20;
            Console.WriteLine(string.Join(",", arr));
        }

        #region Question21
        private class Q21
        {
            public readonly static Program Current = new Program();
            public Program Instance { get => Current; }
        }

        /// <summary>
        /// Question21.
        /// </summary>
        private static void Question21()
        {
            var a = new Q21();
            var b = new Q21();

            Console.WriteLine(a == b);
            Console.WriteLine(a.Instance == b.Instance);
        }
        #endregion

        #region Question22
        /// <summary>
        /// Question22.
        /// </summary>
        private static void Question22()
        {
            Q22 s = new();
            s.Print();

            IQ22 i = s;
            i.Print();
        }

        private interface IQ22
        {
            void Print(string value = "Interface value");
        }

        private class Q22 : IQ22
        {
            public void Print(string value = "Class value")
            {
                Console.WriteLine(value);
            }
        }
        #endregion

        private static void Question23()
        {
            int[] singleDimensionArray = { 1, 2, 3, 4, 5, 6 };
            int[,] multileDimensionArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] jaggedArray = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };

            Console.WriteLine(singleDimensionArray.Length);
            Console.WriteLine(singleDimensionArray.Rank);
            Console.WriteLine(multileDimensionArray.Length);
            Console.WriteLine(multileDimensionArray.Rank);
            Console.WriteLine(jaggedArray.Length);
            Console.WriteLine(jaggedArray.Rank);
        }

        #region Question25
        public static int Q25 = 0;
        /// <summary>
        /// Question25.
        /// </summary>
        private static void Question25()
        {
            (Q25++).TestQ25();
        }
        #endregion

    }

    internal static class IntExtensions
    {
        /// <summary>
        /// Test Q25.
        /// </summary>
        /// <param name="int">The int.</param>
        public static void TestQ25(this int @int)
        {
            Console.WriteLine(Program.Q25);
            Console.WriteLine(@int);
        }
    }
}
