using System;
using System.Text;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void firstA()
            {
                int i = 20;
                char c = 'c';
                bool b = true;
                byte by = 255;
                sbyte sb = 127;
                decimal dec = 176.623M;
                double db = 172789.712879;
                float fl = 236123.12378F;
                uint ui = 567;
                long l = 3456789;
                ulong ul = 123456789;
                short s = 1234;
                ushort us = 34561;

                string str = "строка: конец";
                object obj = 20;
                dynamic dyn = "dynamic";
                Console.Write($" int={i} char={c} bool={b} byte={by} sbyte={sb} \n" +
                              $"decimial={dec} double={db} float={fl} uint={ui} long={l} \n" +
                              $"ulong={ul} short={s} ushort={us}\n" +
                              $"object={obj} dynamic={dyn} \n" +
                              $"{str} \n\n");
            }

            static void firstB()
            {
                byte b = 0;
                short s = b;
                int i = s + 4;
                long l = i + 110;
                decimal d = l + 120;
                int ii;
                char c = 'c';
                ii = c;
                Console.WriteLine($"byte({b})=>short({s})=>int({i})=>long({l})=>decimal({d}) \t char({c})=>int({ii})");

                l = (long)d;
                i = (int)l;
                s = (short)i;
                b = (byte)s;
                c = (char)ii;
                Console.WriteLine($"byte({b})<=short({s})<=int({i})<=long({l})<=decimal({d}) \t char({c})<=int({ii})");

                Console.Write("Введите что-то на цифрах: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"хопа, а вот и инт: {age} \n");

            }

            static void firstC()
            {
                int i = 123;
                //boxing (в кучу закидываем)
                object o = i;
                //unboxing (обратно в стек)
                int j = (int)o;
            }

            static void firstD()
            {
                var i = 25;
                Console.WriteLine(i.GetType());
                var c = 'c';
                Console.WriteLine(c.GetType() + "\n");
            }

            static void firstE()
            {
                int? i = null;
                Console.WriteLine($"i.HasValue={i.HasValue}");
                try
                {
                    Console.WriteLine($"i.Value={i.Value}");
                }
                catch
                {
                    Console.WriteLine("если HasValue=false, то не может иметь Value ");
                }
                i = 5;
                Console.WriteLine($"i.HasValue={i.HasValue}");
                Console.WriteLine($"i.Value={i.Value} \n");
            }

            static void secondA()
            {
                string str1 = "str1qwe";
                string str2 = "str1adf";
                int? i;

                Console.WriteLine($"результат сравнения строк={ i = str1.CompareTo(str2)} \n");


            }

            static void secondB()
            {
                string str1 = "one two three";
                string str2 = "three four five";
                string str3 = "five six seven";

                Console.WriteLine($"сцепление: {str1 + str2 + str3}");

                string str4 = null;
                str4 = string.Copy(str1);
                Console.WriteLine($"копирование: {str4}");

                string SubStr1 = "two";
                int IndexOfSubstr1 = str1.IndexOf(SubStr1);
                Console.WriteLine($"позиция подстроки: {IndexOfSubstr1}-{IndexOfSubstr1 + SubStr1.Length - 1}");

                string str5 = "будем делить эту строку";
                string[] words = str5.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in words)
                {
                    Console.WriteLine(s);
                }

                str1 = str1.Insert(7, SubStr1);
                Console.WriteLine(str1);

                string SubStr2 = "four";
                int IndexOfSubstr2 = str2.IndexOf(SubStr2);
                str2 = str2.Remove(IndexOfSubstr2, SubStr2.Length + 1);
                Console.WriteLine(str2 + "\n");

            }

            static void secondC()
            {
                string str1 = null;
                Console.WriteLine($"str1 is null: {string.IsNullOrEmpty(str1)} \n");
            }

            static void secondD()
            {
                StringBuilder sb = new StringBuilder("строкушка строка");
                sb.Remove(8, 3);
                sb.Insert(0, "xxx");
                sb.AppendFormat("xxx");
                Console.WriteLine(sb + "\n");
            }

            static void thirdA()
            {
                int[,] A = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 4, 5, 6, 7 } };
                int rows = A.GetUpperBound(0) + 1;
                int columns = A.Length / rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{A[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }

            static void thirdB()
            {
                string[] StrArr = { "First String", "second String", "third String" };

                Console.WriteLine($" \n Длинна массива строк: {StrArr.Length}");
                for (int i = 0; i < StrArr.Length; i++)
                {
                    Console.WriteLine(StrArr[i]);
                }
                string SubStr = "другая строка";
                Console.WriteLine("какой элемент заменить на \"другую строку\"???");
                int j = Convert.ToInt32(Console.ReadLine());
                StrArr[j - 1] = SubStr;
                for (int i = 0; i < StrArr.Length; i++)
                {
                    Console.WriteLine(StrArr[i]);
                }
            }

            static void thirdD()
            {
                float[][] Arr = new float[3][];
                Arr[0] = new float[2];
                Arr[1] = new float[3];
                Arr[2] = new float[4];

                Console.WriteLine("\n вводите значения массива");
                for (int i = 0; i < 2; ++i)
                {
                    Arr[0][i] = (float)Convert.ToDouble(Console.ReadLine()); ;
                }
                for (int i = 0; i < 3; ++i)
                {
                    Arr[1][i] = (float)Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < 4; ++i)
                {
                    Arr[2][i] = (float)Convert.ToDouble(Console.ReadLine()); ;
                }
                Console.WriteLine();

                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr[i].Length; j++)
                    {
                        Console.Write($"{Arr[i][j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.Write('\n');
            }

            static void thirdE()
            {
                var Arr = new int[] { 1, 2, 3, 4 };
                var Str = new string("dghjsk");

                var x = Arr;
                var Str2 = Str;
            }

            static void fourABCD()
            {
                //----------------------a-----------------------------------------------------
                (int, string, char, string, ulong) Cort1 = (25, "huasc", 'c', "djksfd", 2156378);
                (int, string, char, string, ulong) Cort2 = (25, "huasc", 'z', "djksfd", 2156378);

                //---------------------b-----------------------
                Console.WriteLine(Cort1+"\n");
                
                Console.Write($"{Cort1.Item4} ");
                Console.Write($"{Cort1.Item2} \n");

                var (z, x, c, v, b) = Cort1;

                Console.WriteLine($"{z},{x},{c},{v},{b}");
                Console.WriteLine(Cort1 == Cort2);
            }

            int[] Arr = new int[] { 1, 2, 3, 4, 5, 6, -1 };

            string str = ("zxc");
            static (int, int, int, char) five(int[] Arr, string str)
            {
                int min = 1000, max = -1000, sum = 0;

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (min > Arr[i])
                    {
                        min = Arr[i];
                    }
                    if (max < Arr[i])
                    {
                        max = Arr[i];
                    }
                    sum += Arr[i];
                }

                char c = str[0];

                return (min, max, sum, str[0]);
            }

            void six()
            {
                checked
                {
                    void functionChecked()
                    {
                            //int i = (int)21474283648;
                    }
                    functionChecked();
                }
                unchecked
                {
                    void functionUnChecked()
                    {
                        int i = (int)21474823648;
                        Console.WriteLine("\n"+i);
                    }
                    functionUnChecked();
                }
            }


            firstA();
            firstB();
            firstC();
            firstD();
            firstE();
            secondA();
            secondB();
            secondC();
            secondD();
            thirdA();
            thirdB();
            thirdD();
            thirdE();
            fourABCD();
            five(Arr, str);
            six();
        }
       
    }
}
