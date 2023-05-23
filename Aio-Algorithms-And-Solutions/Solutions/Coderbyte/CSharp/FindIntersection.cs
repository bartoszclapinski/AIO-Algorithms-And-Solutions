namespace Aio_Algorithms_And_Solutions.Solutions.Coderbyte.CSharp;

/*
 * Find Intersection - Coderbyte
 * 
 * Have the function FindIntersection(strArr) read the array of strings stored in strArr
 * which will contain 2 elements: the first element will represent a list of comma-separated
 * numbers sorted in ascending order, the second element will represent a second list
 * of comma-separated numbers (also sorted). Your goal is to return a comma-separated string
 * containing the numbers that occur in elements of strArr in sorted order. If there is no intersection,
 * return the string false. 
 */

public class FindIntersection
{
    public static string FindIntersectionSolution(string[] strArr)
    {
        var list1 = strArr[0].Split(", ").Select(int.Parse).ToList();
        var list2 = strArr[1].Split(", ").Select(int.Parse).ToList();

        var intersection = list1.Intersect(list2);

        var enumerable = intersection.ToList();
        
        if (!enumerable.Any())
        {
            return "false";
        }

        return String.Join(",", enumerable);
    }
}