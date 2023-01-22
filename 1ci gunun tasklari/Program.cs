
namespace _1ci_gunun_tasklari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sozler = { "salam2", "djs2dk", "5dgd", "hxcjd" };

            //Console.WriteLine(Showcount("This is Azerbaijan"));

            //System.Console.WriteLine(Hasanum(sozler));
            //int[] nums = { 12, 24, -4, 67, 78 };
            //System.Console.WriteLine();
            //System.Console.WriteLine(Goster(" Hello world"));
            //System.Console.WriteLine(Hasanum(sozler));



            //string[] names = { "Anar", "Hasan", "Huseyn" };
            //var name = Hasaname(names, "Anar");
            //Console.WriteLine(name);

            //int[] numbers = { 45, 23, 45, 456, 67, 787, 3, 422, 454, 57, 87 };
            //Console.WriteLine(Hasvalue(numbers,687));

            //int[] array = { 34, 56, 567, 4, 6, 67 };
            //int[] arry2 = { 23, 45, 46, 7, 789 };
            //var result = Shownum(array, arry2);
            //Console.WriteLine(result);

            //Console.WriteLine(IsDigit('a'));
            //var result = Shownum("Salam");
            //Console.WriteLine(result);

            //Console.WriteLine(Shownum("salam23"));

            //Console.WriteLine(FindIndex("salam1", '2'));
            //Console.WriteLine(Substring("Practice", 3));
        }
        #region Task1+ Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        //static string Findfirstword(string word)
        //{
        //    string st = "";
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            st += word[i];
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return st;
        //}
        #endregion

        #region Task2 Verilmiş string dəyərindəki sözlərin sayını tapan metod(boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)

        //static int Showcount(string word)
        //{

        //    int count = 1;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == ' ')
        //        {

        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion

        #region Task3  Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
        // Misalçün verilmiş arraydə {4, -3, 10, -24} dəyərləridirsə methoddan geriyə {4, 10}dəyərli array qayıdır.
        static int[] Createarray(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)

                if (nums[i] > 0)
                {
                    count++;
                }

            int[] newarray = new int [count];
            int count2 = 0;
            for (int i = 0; i < newarray.Length; i++)
            {
                if (newarray[i]>0)
                {
                    newarray[count2] = nums[i];
                    count2++;
                }
            }
            return newarray;
        }
        #endregion

        #region Task4- Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        //static int Hasanum(string[] word)
        //{
        //    int count = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (Shownum(word[i]))
        //        {
        //            count++;
        //        }

        //    }
        //    return count;
        //}
        #endregion

        #region Task5+ Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.
        //static string Shh(string word)
        //{
        //    string bos = "";
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            bos += i;
        //            break;
        //        }
        //    }
        //    return bos;
        //}
        #endregion

        #region Task6 Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod

        //static string Goster(string word)
        //{
        //    string empty = "";
        //    bool hasa = false;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            empty += word[i];
        //            hasa = true;
        //        }
        //        if (word[i]==' '&& hasa==true)
        //        {
        //            empty += word[i];
        //        }
        //    }            
        //    return empty;
        //}

        #endregion

        #region Task 4-un metodu
        static bool Shownum(string word)
        {
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (word[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion


        #region Academy Task1 Layihe ise dusdukdue console-dan email deyeri daxil etmeyimizi istesin,Eger email @ simvolu yoxdursa yeniden daxil etmeyimizi istesin
        //    string email;
        //    char symbol = '@';
        //    bool Hasat = false;
        //    do
        //    {
        //        Console.WriteLine("Emaili daxil edin:");
        //        email = Console.ReadLine();
        //        for (int i = 0; i < email.Length; i++)
        //        {
        //            if (email[i]==symbol)
        //            {
        //                Hasat = true;
        //                break;
        //            }
        //        }


        //    } while (Hasat==false);
        //}
        #endregion

        #region AcademyTask2+ Verilmis adlar siyahisinda verilmis adin olub olmadigini tapan metod
        //static bool Hasaname(string [] arry, string name)
        //{
        //    for (int i = 0; i < arry.Length; i++)
        //    {
        //        if (arry[i]==name)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Academy Task3+ Verilmis ededler siyahisinda verilmis ededin oldub olmaddigini tapan metod
        //static bool Hasvalue(int[] numbers, int num)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        #endregion

        #region Academy Task4+Verilmis ededler siyahisinda verilis diger ededler siyahisindan hansisa ededin olub olmadigini tapan metod
        //static bool Shownum(int[] arry, int[] values)
        //{
        //    for (int i = 0; i < arry.Length; i++)
        //    {
        //        for (int j = 0; j < values.Length; j++)
        //        {
        //            if (arry[i] == values[j])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Academy Task5+Verilmis charin reqem olub olmadigini tapan bir metod
        //static bool IsDigit(char symbol)
        //{
        //    char[] cr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        //    for (int i = 0; i < cr.Length; i++)
        //    {
        //        if (cr[i] == symbol)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        #endregion

        #region Academy Task6- Verilmis yazida reqem olub olmadigini tapan bir metod
        //static bool Shownum(string word)
        //{
        //    char[] reqemler = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; 

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (IsDigit(word[i])) 
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        #endregion

        #region Academy Task7 Verilmis yazinin icerisinde verilmis charin indexini tapan metod

        //static int FindIndex(string word, char cr)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == cr)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Academy Task8 Verimis yazini verilmis indexe qeder kesib qaytaran metod
        //static string Substring(string word, int index)
        //{
        //   string empty = "";
        //   for (int i = 0; i < index; i++)
        //   {
        //    empty += word[i];
        //   }
        //   return empty;
        //}
        #endregion

    }
}




