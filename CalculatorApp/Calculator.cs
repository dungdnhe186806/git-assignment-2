public enum SIGN
{
    PLUS,
    MINUS,
    MULTIPLY,
    DIVIDE
}

public class Calculator
{
    public double Calculate(SIGN sign, double arg1, double arg2)
    {
        switch (sign)
        {
           case SIGN.DIVIDE:
                return arg2 == 0 ? throw new DivideByZeroException() : arg1 / arg2;


            default:
                return 0;
        }
    }
}
