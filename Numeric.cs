namespace metode_numeris
{
  public static class Numeric
  {
    public static double Sum(double[] nums)
    {
      double total = 0;
      foreach (var num in nums)
      {
        total += num;
      }
      return total;
    }

    public static double Average(double[] nums)
    {
      return (Sum(nums) / nums.Length);
    }

    public static double[] Multiply(double[] X, double[] Y)
    {
      double[] Result = new double[X.Length];
      for (int i = 0; i < X.Length; ++i)
      {
        Result[i] = X[i] * Y[i];
      }
      return Result;
    }

  }
}