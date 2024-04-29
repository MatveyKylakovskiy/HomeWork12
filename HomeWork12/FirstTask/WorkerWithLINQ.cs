
using System.Linq;

namespace HomeWork12.FirstTask
{
    public static class WorkerWithLINQ
    {
        /* Метод возвращает первое слово из последовательности слов, содержащее
        только одну букву.*/
        public static string GetFirstOfString(List<string> list)
        {
            return list.Where(l => l.Length == 1).First();
        }

        /* Метод, возвращающий последнее слово, содержащее в себе подстроку «ее».
        Реализовать, используя только 1 метод LINQ.*/
        public static string GetLastContainEE(List<string> list)
        {
            return list.FindLast(l => l.Contains("ee"));
        }

        /* Реализовать метод для возврата последнего слова, соответствующего условию:
        длина слова не меньше min и не больше max.Если нет слов, соответствующих
        условию, метод возвращает null.*/
        public static string GetLastWord(List<string> list, int min, int max)
        {

            return list.Where(l => (l.Length >= min && l.Length <= max)).LastOrDefault();
        }

        /* Напишите метод, который возвращает количество уникальных значений в
        массиве.*/
        public static int GetNumberOfUnique(List<string> list)
        {
            return list.Distinct().Count() - 1;
        }

        /* Напишите метод, который принимает список и извлекает значения от 5
        (включительно) оканчивающееся по значению то, которое содержит цифру "3"*/
        public static string[] GetStartWith5EndWith3(List<string> list)
        {
            return list.Where(l => l.StartsWith("5") && l.EndsWith("3")).ToArray();
        }

        /* Метод возвращает длину самого короткого слова*/
        public static int GetLengthOfSmall(List<string> list)
        {
            return list.Min(l => l.Length);
        }

        /* Напишите метод, который преобразует словарь в список и меняет местами
        каждый ключ и значение*/
        public static List<KeyValuePair<T2, T1>> ReplaseDictionaryByList<T1, T2>(Dictionary<T1, T2> dictionary)
        {
            List<KeyValuePair<T2, T1>> list = new List<KeyValuePair<T2, T1>>();

            foreach(var d in dictionary)
            {
                list.Add(new KeyValuePair<T2, T1>(d.Value, d.Key));
            }
            return list;
        }
    }
}



/*

Реализовать следующие методы:

Метод возвращает первое слово из последовательности слов, содержащее
только одну букву.

метод, возвращающий последнее слово, содержащее в себе подстроку «ее».
Реализовать, используя только 1 метод LINQ.

Реализовать метод для возврата последнего слова, соответствующего условию:
длина слова не меньше min и не больше max. Если нет слов, соответствующих
условию, метод возвращает null.

Напишите метод, который возвращает количество уникальных значений в
массиве.

Напишите метод, который принимает список и извлекает значения от 5
(включительно) оканчивающееся по значению то, которое содержит цифру "3"

Метод возвращает длину самого короткого слова

Напишите метод, который преобразует словарь в список и меняет местами
каждый ключ и значение*/