using System;
using System.Collections.Generic;

namespace ListsAndDictionnairies
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Enoncé______________________________________________________
             * 
             * 
Liste d'entiers

    Créer une liste d'entiers
    Ajouter 10 entiers tous différents les uns des autres
    Ecris une méthode renvoyant la somme des éléments d'une liste
    Ecris une méthode renvoyant la moyenne des éléments d'une liste
    Ecris une méthode triant une liste
    Affiche le résultat de tes trois méthodes sur la liste crée au départ

Dictionnaire

    Créer un dictionnaire indexant des valeurs décimales avec des chaînes de caractères
    Met au moins 5 valeurs dans le dictionnaire nouvellement crée
    Ligne par ligne, affiche chaque association clé valeur

Palindromes

Tu vas créer un algorithme repérant les palindromes sur une liste de chaînes de caractères. Les palindromes qui sont exactement les même lorsque les lettres sont inversées:

    pop
    maoam
    ada
    ère
    elle

L'implémentation de l'algorithme contient deux méthodes:

    Retourne vrai si une chaîne de caractères est un palindrome
    Retourne un tableau de booléens indiquant pour chaque élément d'une liste de chaînes de caractères si elle est un palindrome ou non

Moins de mémoire

Nous allons utiliser l'algorithme que tu as écris plus haut, mais nous allons changer l'implémentation d'un de ses comportements.

La méthode retournant un tableau de booléens indiquant pour chaque élément d'une liste de chaînes de caractères si elle est un palindrome ou non va changer de façon de faire. Au lieu d'utiliser une liste tu vas utiliser un dictionnaire. Ce dictionnaire crée une clé qui est la valeur et lui associe un booléen qui indique si le mot est une séquence palindromique ou non.

            */

            /* List<int> IntegerList = new List<int>();

            for (int i=0; i<10; i++)
            {
                IntegerList.Add(i * 5);
            }
            
            foreach (int value in IntegerList)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            SortList(IntegerList);
            foreach (int value in IntegerList)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Somme de la liste: " + CalculateListSum(IntegerList));

            Console.WriteLine("Moyenne de la liste: " + CalculateMeanList(IntegerList)); */

            // dictionnaire
            /*Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
            dictionary["premier decimal"] = 2.33M;
            dictionary["deuxième decimal"] = 3.33M;
            dictionary["troisième decimal"] = 4.33M;
            dictionary["quatrième decimal"] = 5.33M;
            dictionary["cinquième decimal"] = 6.33M;

            foreach(KeyValuePair<string,decimal> kvp in dictionary)
            {
                Console.WriteLine("key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }*/

            /*foreach(KeyValuePair<string, decimal> value in dictionary)
            {
                Console.WriteLine("Insérez une clé de type string: ");
                value.Key = Console.ReadLine();
            }

            // palindrome

            List<string> SentenceList = new List<string>();

            SentenceList.Add("palindrome");
            SentenceList.Add("Rotor");
            SentenceList.Add("Kayak");
            SentenceList.Add("Elle");
            SentenceList.Add("Essai");
            Console.WriteLine("{0}", IsPalindrome("kaytak"));*/
            List<string> StringList = new List<string>();


            string sentence = "Bonjour Monsieur Kayak";

            SplitDictionary(sentence);

                          

        }
        static List<bool> SplitList (string sentence)
        {
            
            string[] word = sentence.Split(" ");
            List<bool> palindromeList = new List<bool>();
          

            foreach(string elements in word)
            {
                palindromeList.Add(IsPalindrome(elements));
            }

            foreach(bool value in palindromeList)
            {
                Console.WriteLine(value);
            }

            return palindromeList;
            

        }

        static Dictionary<string, bool> SplitDictionary (string sentence)
        {
            string[] word = sentence.Split(" ");

            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();

            foreach (string elements in word)
            {
                dictionary[elements] = IsPalindrome(elements);
            }

            foreach (KeyValuePair<string, bool> kvp in dictionary)
            {
                Console.WriteLine("key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
                return dictionary;
        }

        /*static int CalculateListSum(List<int> IntegerList)
        {
            int ListSum = 0;

            foreach (int element in IntegerList)
            {
                ListSum += element;
            }

            return ListSum;
        }

        static double CalculateMeanList(List<int> IntegerList)
        {
            int summ = CalculateListSum(IntegerList);
            int size = IntegerList.Count;
            double mean;
            mean = (double)summ / size;
            return mean;
        }
        static void SortList(List<int> SortedList)
        {
            int count = SortedList.Count;
            int min;
            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < count ; j++)
                {
                    if(SortedList[i] < SortedList[j])
                    {
                        min = SortedList[j];
                        SortedList[j] = SortedList[i];
                        SortedList[i] = min;
                        
                    }
                }
            }
            // return ;
        } */

        static bool IsPalindrome(string Sentence)
        {
            string loweredSentence = Sentence.ToLower();
            int n = loweredSentence.Length - 1;

            for (int i = 0; i <= n; i++)
            {
                if (loweredSentence[i] != loweredSentence[n - i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
