Console.Write("Enter String: ");
string stringA = Console.ReadLine();
Console.Write("Enter Integer: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowCharacter(stringA, num);

double price = (CalculateRetail());
Console.WriteLine($"Retail Price is ${price}");

for(double i = 80; i < 101;  i++)
{
    Console.WriteLine($"{i}degrees F/{Celsius(i)} degrees C");
}







static void ShowCharacter(string text, int num)
{
    Console.WriteLine($"{text}, {text[num + 1]}");
}

static double CalculateRetail()
{
    Console.Write("Enter Wholesale Cost: ");
    double wholesaleCost = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter Price Markup: ");
    double priceMarkup = Convert.ToDouble(Console.ReadLine());
    if (priceMarkup > 1)
    {
        priceMarkup = priceMarkup/100;
    }
    double retailPrice = wholesaleCost / (priceMarkup + 1);
    return retailPrice;
}

static double Celsius(double F)
{
    double C;
    C = ((F - 32)*(5.0/9.0));
    return C;
}


