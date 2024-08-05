using Day_01_G03;

namespace assignment_1
{

    public class Extensions
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region question 1
            var outOfStock = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).ToList();

            foreach (var item in outOfStock)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region question 2
            var result2 = ListGenerator.ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region question 3

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = Arr.Where(A => A.Length < Array.IndexOf(Arr, A));
            foreach (var item in result)
            {

                Console.WriteLine(item);
            }

            #endregion


            #endregion

            #region LINQ - Ordering Operators

            #region question 4

            var productsList1 = ListGenerator.ProductsList.OrderBy(p => p.ProductName);
            foreach (var item in productsList1)
            {

                Console.WriteLine(item);
            }

            #endregion
            #region question 2

            string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "ClOvEr", "cHeRry", "BlUeBeRrY" };

            var result3 = Arr2.OrderBy(
                a => a.ToLower()
                );

            foreach (string str in result3)
            {
                Console.WriteLine(str);
            }

            #endregion

            #region question 3

            var unitsInStock = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);

            foreach (var unit in unitsInStock)
            {
                Console.WriteLine(unit);
            }


            #endregion

            #region question 4

            
            var result4 = Arr.OrderBy(n=>n.Length).ThenBy(n => n);
            foreach (var unit in result4)
            {
                Console.WriteLine(unit);
            }

            #endregion

            #region question 5

            var result5 = Arr2.OrderBy(a=>a.Length).ThenBy(a => a.ToLower()); 

            foreach (var unit in result5)
            {
                Console.WriteLine(unit);
            }


            #endregion

            #region question 6

            var result6 = ListGenerator.ProductsList.OrderBy(p => p.Category).ThenByDescending(p=>p.UnitPrice);

            foreach (var unit in result6)
            {
                Console.WriteLine(unit);
            }

            #endregion

            #region question7
            var result7 = Arr2.OrderBy(a=>a.Length).ThenByDescending(a=>a.ToLower());
            foreach(var unit in result7)
            {
                Console.WriteLine(unit);
            }
            #endregion
            #region question 8
            var result8 = Arr.Where(n => n.ToLower()[1]=='i').Reverse();
            foreach (var unit in result8)
            {
                Console.WriteLine(unit);
            }

            #endregion

            #endregion

        }
    }
}
