double CalculateFormula (int a, int b, int c, int d)
{
    int numenator = a*b;
    int denumenator = c+d;
    double result = numenator/denumenator;
    return result;
}
Console.WriteLine(CalculateFormula(2,5,1,1));
