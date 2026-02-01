private double calculate(SIGN sign, double arg1, double arg2)
{
    switch (sign)
    {
        case SIGN.DIVIDE:
            return arg1 / arg2;
        case SIGN.MULTIPLY:
            return arg1 * arg2;
        default:
            return 0d;
    }
}
