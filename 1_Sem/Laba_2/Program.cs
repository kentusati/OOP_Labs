using System;

namespace Laba_2
{
    public class Array_Vector
    {
        //поля
        private int[] Arr = new int[3];
        private string IntArrInfo;
        private readonly int ID;
        private static string IntArrInfoStatic;
        private static int number;
        const int Const = 1;

        // get/set
        public int[] ArrGS
        {
            get
            {
                return Arr;
            }
            set
            {
                Arr = value;
            }
        }
        public string IntArrInfoGS
        {
            set
            {
                IntArrInfo = value;
            }
            get
            {
                return IntArrInfo;
            }
        }
        public int IDGS
        {
            get
            {
                return ID;
            }
        }
        public string IntArrInfoStaticGS
        {
            get
            {
                return IntArrInfoStatic;
            }
            set
            {
                IntArrInfoStatic = value;
            }
        }
        public int ConstGS
        {
            get
            {
                return Const;
            }
        }
        public int NumberGS
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        //конструкторы 
        public Array_Vector()
        {
            Arr = new int[] { 1, 2, 3 };
            IntArrInfo = "конструктор без параметров";
            ID = this.GetHashCode();
            number++;

        }

        public Array_Vector(string str = "конструктор с параметрами по умолчанию", int[] Arr = null)
        {
            IntArrInfo = str;
            ID = this.GetHashCode();
            number++;
        }
        public Array_Vector(int[] a)
        {
            Arr = a;
            IntArrInfo = "конструктор с одним параметром";
            ID = this.GetHashCode();
            number++;
        }
        public Array_Vector(int[] a, string str)
        {
            Arr = a;
            IntArrInfo = str;
            ID = this.GetHashCode();
            number++;
        }
        //статический конструктор
        static Array_Vector()
        {
            IntArrInfoStatic = "статическая строка";
        }

        //индекстаор
        public int this[int index]
        {
            get
            {
                return Arr[index];
            }
            set
            {
                Arr[index] = value;
            }
        }

        //в одном из методов класса для работы с аргументами используйте ref - и out-параметры.(????????????????????????????????????????????????????????????????????)
        //
        //
        //
        //
        //
        //
        //
        //

        //метод получения информации о классе(и его экземпляре)
        public static void GetInfo(int[] Arr, string IntArrInfo, int ID)
        {
            Console.WriteLine("Массив:");
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine('\n' + "Строка" + IntArrInfo);
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("статическая строка:" + IntArrInfoStatic);
            Console.WriteLine("Константное поле:" + Const);
            Console.WriteLine("количество экземпляров:" + number);
        }

        //---------------------------вар24--------------------------
        //метод поэлементоного сложенияи вычитания векторов со сколярным значением
        public double Sum(Array_Vector Vector)
        {
            return Math.Sqrt(Math.Pow(Arr[0] + Vector[0], 2) + Math.Pow(Arr[1] + Vector[1], 2) + Math.Pow(Arr[2] + Vector[2], 2));
        }
        public double Diff(Array_Vector Vector)
        {
            return Math.Sqrt(Math.Pow(Arr[0] - Vector[0], 2) + Math.Pow(Arr[1] - Vector[1], 2) + Math.Pow(Arr[2] - Vector[2], 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //массивы для заполнения
            int[] A2 = {10,15,20};
            int[] A3 = { 31, 53, 27 };
            int[] A4 = { 28, 39, 39 };
            int[] A5 = { 14, 94, 26 };
            
            //создаем и инициализируем массив объектов
            Array_Vector[] ArrOfArr = new Array_Vector[5];
            ArrOfArr[0] = new Array_Vector();
            ArrOfArr[1] = new Array_Vector(A2);
            ArrOfArr[2] = new Array_Vector(A3, "вызван конструктор с двумя параметрами(3 эл)");
            ArrOfArr[3] = new Array_Vector(A4, "вызван конструктор с двумя параметрами(4 эл)");
            ArrOfArr[4] = new Array_Vector(A5, "вызван конструктор с двумя параметрами(5 эл)");

            //
            int sumOld=0;
            int sumNew = 0;
            int IndexOfMax = 0;
            int correspondenceEven = 0; //соответствие четных
            int correspondenceOdd = 0; //соответствие нечетных
            int IndexOfEven = 0;
            int IndexOfOdd = 0;

            for (int i=0; i<ArrOfArr.Length; i++)
            {
                //нахлждение массива с максимальной суммой
                for(int x=0; x<ArrOfArr[i].ArrGS.Length; x++)
                {
                    sumNew += ArrOfArr[i].ArrGS[x];
                    if(ArrOfArr[i].ArrGS[x] % 2==0)
                    {
                        correspondenceEven++;
                    }
                    if (ArrOfArr[i].ArrGS[x] % 2 == 1)
                    {
                        correspondenceOdd++;
                    }
                }
                if (sumNew > sumOld)
                {
                    sumOld = sumNew;
                    IndexOfMax = i;
                }
                if (correspondenceEven== ArrOfArr[i].ArrGS.Length)
                {
                    IndexOfEven = i;
                }
                if (correspondenceOdd == ArrOfArr[i].ArrGS.Length)
                {
                    IndexOfOdd = i;
                }
                correspondenceEven = 0;
                correspondenceOdd = 0;
            }

            Console.WriteLine("\n\n Массив с самой большой суммой имеет индекс ["+IndexOfMax+"]. Этот массив:");
            Array_Vector.GetInfo(ArrOfArr[IndexOfMax].ArrGS, ArrOfArr[IndexOfMax].IntArrInfoGS, ArrOfArr[IndexOfMax].IDGS);
            Console.WriteLine("\n\n Массив с четными элементами имеет индекс [" + IndexOfEven + "]. Этот массив:");
            Array_Vector.GetInfo(ArrOfArr[IndexOfEven].ArrGS, ArrOfArr[IndexOfEven].IntArrInfoGS, ArrOfArr[IndexOfEven].IDGS);
            Console.WriteLine("\n\n Массив с нечетными элементами имеет индекс [" + IndexOfOdd + "]. Этот массив:");
            Array_Vector.GetInfo(ArrOfArr[IndexOfOdd].ArrGS, ArrOfArr[IndexOfOdd].IntArrInfoGS, ArrOfArr[IndexOfOdd].IDGS);

        }
    }
}
