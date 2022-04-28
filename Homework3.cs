using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework3
{
    class Homework3
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here            
            int rowsHeight = matrixOfIntegers.GetLength(0);
            int colsWidth = matrixOfIntegers.GetLength(1);
           // Console.WriteLine(rowsHeight);
           // Console.WriteLine(colsWidth);

            if (rowsHeight == colsWidth && rowsHeight % 2 == 1)
            {
               Console.WriteLine($"The central element is { matrixOfIntegers[rowsHeight / 2, colsWidth / 2] }");
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }         

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here
            int sumDiagonal1 = 0;
            int sumDiagonal2 = 0;

            int rowsHeight = matrixOfIntegers.GetLength(0);
            int colsWidth = matrixOfIntegers.GetLength(1);
            if (rowsHeight == colsWidth)
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        sumDiagonal1 = i == j ? sumDiagonal1 + matrixOfIntegers[i, j] : sumDiagonal1 + 0 ;
                        sumDiagonal2 = i + j == colsWidth - 1 ? sumDiagonal2 + matrixOfIntegers[i, colsWidth-1-i] : sumDiagonal2 + 0;
                    }
                }
                   Console.WriteLine($"First diagonal: {sumDiagonal1}");
                   Console.WriteLine($"Second diagonal: {sumDiagonal2}");
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonals");
            }
            
        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here
            string result = "";
            for (int i = 1; i <= triangleHight; i++)
            {
                for (int j = 0; j <= (triangleHight - i); j++)
                {
                    Console.Write(" ");                    
                }
                for (int k = 1; k <= i; k++)
                {
                    result = (k == 1 || k == i && i != triangleHight) ? " *" : (i == triangleHight) ? " *" : "  ";
                    Console.Write(result);
                }
                Console.WriteLine();
            }
        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
           
            var unsortedList = new List<int>();
            unsortedList.AddRange(listOfNumbers);
            unsortedList.Sort();
            foreach (var i in unsortedList)
            {
                Console.WriteLine(i);
            }
            
        }
        public void WorkWithCollections()
        {
            //HashSet collection (implicite sort method is not available for hashset)
            ISet<string> students = new HashSet<string>();

            students.Add("Ion Ionescu");
            students.Add("Vasile Vasiliu");
            students.Add("Ana Rusu");
            students.Add("Maria Popescu");
            
            Console.WriteLine();
            Console.WriteLine("Print unsorted hashset");

            foreach (var i in students)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Print sorted hashset");
            foreach (var setorder in students.OrderBy(u => u))
            {
                Console.WriteLine(setorder);
            }

            Console.WriteLine();
            int j = students.Count;
            Console.WriteLine($"Number of elements in collection: {j}");

            Console.WriteLine();
            Console.WriteLine("Print hashset after remove of element Ana Rusu");
            students.Remove("Ana Rusu");
            foreach (var i in students)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Is Maria Popescu a student? {students.Contains("Maria Popescu")}");


            //Dictionary collection
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("chamomile", "white");
            dictionary.Add("tulip", "black");
            dictionary.Add("orchid", "violet");
            dictionary.Add("rose", "red");
            dictionary.Add("lilac", "lila");

            Console.WriteLine();
            Console.WriteLine("Print unsorted dictionary");

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }
            
            //sorting the dictionary
            
            Console.WriteLine();
            Console.WriteLine("Print sorted dictionary descending by value");

            foreach (var order in dictionary.OrderByDescending(u => u.Value))
            {
                Console.WriteLine("key: {0}, value: {1}", order.Key, order.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Print sorted dictionary ascending by key");

            var list = dictionary.Keys.ToList();
            list.Sort();
            
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, dictionary[key]);
            }
            Console.WriteLine();
            Console.WriteLine("Print sorted dictionary after remove of element ROSE");

            dictionary.Remove("rose");
            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }

            //List collection

            IList<int> list1 = new List<int>() { 22, -589, 125, 4, 0, 56, 48, -1 };

            Console.WriteLine();
            Console.WriteLine("Print sorted list");
            foreach (var listorder in list1.OrderBy(u => u))
            {
                Console.WriteLine(listorder);
            }

            Console.WriteLine();
            Console.WriteLine("Remove negative elements");

            
            for (int y = 0; y < list1.Count; y++)
            {
                if (list1[y] < 0) 
                {
                    list1.Remove(list1[y]);
                }
                else
                {                                       
                Console.WriteLine(list1[y]);                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("Remove the last element");

            list1.RemoveAt(list1.Count-1);                 

            foreach (var i in list1)
            {
                Console.WriteLine(i);
            }
        }
    
        public static void Main(String[] args)
        {
            Homework3 homework = new Homework3();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
            Console.WriteLine("Results for exercise with collections:");
            homework.WorkWithCollections();
        }
    }
}