class ConditionalStatements
{
    public string checkNumber(int num)
    {
        string res;
        if (num == 0)
        {
            res = "The number " + num + " is zero";
        }
        else if (num > 0)
        {
            res = "The number " + num + " is positive";
        }
        else
        {
            res = "The number " + num + " is negative";
        }
        return res;
    }

}