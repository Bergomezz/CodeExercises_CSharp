using System;

namespace CodingExercises
{
  public class Exercises
  {
    public static bool ContainsNegative(IEnumerable<int> numbers)
    {
      foreach (var number in numbers)
      {
        if (number < 0)
        {
          return true;
        }
      }
      return false;
    }
  }
}