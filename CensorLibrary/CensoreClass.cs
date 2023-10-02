using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorLibrary
{
    public class CensoreClass
    {
        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. В тексте может быть 0 или более слов "редиска", записанных в различном регистре.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>Возвращается отфильтрованный текст, в котором все слова редиска заменены на звездочки ***</returns>
        public static string Censore(string textString)
        {
            string badwords = "редиска";
            string[] strings = textString.Split(' '); //разделение строки на отдельные слова

            for (int i = 0; i < strings.Length; i++) 
            {
                if (strings[i].ToLower() == badwords)//сравнение слова из массива с запрещенным словом
                {
                    strings[i] = "***"; //замена запрещённго слова на звёздочки
                }
            }
            string censorstring = string.Join(" ", strings);//объединение массива в одну строку

            return censorstring;
        }



    }
}
