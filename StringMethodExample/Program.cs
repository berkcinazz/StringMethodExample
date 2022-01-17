using System;

namespace StringMethodExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Split");

            Console.WriteLine("Lütfen birleştirmek istediğiniz metini aralarında virgül olacak şekilde giriniz.");
            var inputText = Convert.ToString(Console.ReadLine());
            var outputText = SplitExample(inputText);
            Console.WriteLine($"Birleştirilmiş metniniz = {outputText}");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Contains");

            Console.WriteLine("Lütfen kontrol ettirmek istediğiniz metni giriniz.");
            var unCheckedText = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen içerisinde varmı diye kontrol etmek için bir harf giriniz.");
            var characterToText = Convert.ToString(Console.ReadLine());
            bool isContains = ContainsExample(unCheckedText, characterToText);
            Console.WriteLine(isContains ? $"Evet {characterToText} harfi metinin içinde mevcut" : $"Hayır {characterToText} harfi metinin içinde mevcut değil");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Index Of");

            Console.WriteLine("Lütfen seçtiğiniz karakterin sıra numarasını öğrenmek için metninizi giriniz.");
            var textForIndexNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen index numarasını öğrenmek istediğiniz harfi giriniz.");
            var characterForIndexNumber = Convert.ToString(Console.ReadLine());
            var indexNumberOfText = IndexOfExample(textForIndexNumber, characterForIndexNumber);
            Console.WriteLine(indexNumberOfText >= 0 ? $"Metninizin içindeki seçtiğiniz harfin index numarası : {indexNumberOfText}" : "Seçtiğiniz karakter metnin içinde barınmıyor!");

            Console.ReadLine();
        }
        public static string SplitExample(string text)
        {
            //Verilen bir metnin içindeki seçtiğiniz karakteri yine sizin seçeceğiniz karakter ile değiştirir. 
            var mergedText = string.Empty;
            string[] seperateTextList = text.Split(',', ' ');
            foreach (var seperatedText in seperateTextList)
            {
                mergedText += seperatedText;
            }
            return mergedText;
        }

        public static bool ContainsExample(string text, string containsCharacter)
        {
            //Verilen bir metnin içinde aradığımız karakterin içerip içermediğini belirten bir method.
            if (text.Contains(containsCharacter))
            {
                return true;
            }
            return false;
        }
        public static int IndexOfExample(string text, string character)
        {
            //Verilen bir metnin içinde aradığımız karakterin indexini veren veya verilen indexte hangi karakterin olduğunu belirten method.
            int indexOfItem = text.IndexOf(character);
            return indexOfItem;
        }
    }
}
