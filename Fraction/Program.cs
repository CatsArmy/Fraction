using Fractions;

int[] numerator = new int[2];
int[] denomenator = new int[2];
string info = "first";
Fraction[] fraction = new Fraction[2];
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Enter the {info} numerator");//מונה
    numerator[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Enter the {info} denomenator");//מכנה
    denomenator[i] = int.Parse(Console.ReadLine());
    info = "second";
    fraction[i] = new Fraction(numerator[i], denomenator[i]);
    
}
Console.WriteLine($"first fraction {fraction[0]}\n");
Console.WriteLine($"second fraction {fraction[1]}\n");
Fraction combinedFrac = Fraction.AddFractions(fraction[0], fraction[1]);
//Fraction.Add(fraction[0], fraction[1]);
Console.WriteLine($"combined fraction {combinedFrac}");
Fraction simpleFrac = combinedFrac.Simplify();
Console.WriteLine($"combined fraction simplified {simpleFrac}");
