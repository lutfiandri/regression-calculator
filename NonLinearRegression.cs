using System;

namespace regression_calculator
{
  public abstract class NonLinearRegression : Regression
  {
    public double a { get; protected set; }
    public double b { get; protected set; }

    public NonLinearRegression(double[] X, double[] Y) : base(X, Y)
    { }

    override
    protected abstract void Solve();

    // override
    // public abstract double[] CorrelationCoef();
  }
}