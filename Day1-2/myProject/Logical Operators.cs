class LogicalOperators
{
    public string isDivisible(int n)
    {
        string res = "The number " + n + " is divisible by ";
        if (n % 3 == 0 && n % 5 == 0)
        {
            return res + "both 3 and 5";
        }
        else if (n % 3 == 0 || n % 5 == 0)
        {
            return res + "3 or 5";
        }
        else
        {
            return "The number " + n + " is not divisible by both 3 and 5.";
        }
    }
}