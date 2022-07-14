using ProxyPattern;

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your password: ");
string? password = Console.ReadLine();

Console.Write("Enter your amount: ");
double amount = Double.Parse(Console.ReadLine());

IBank bank = new ProxyBank(name,password);


bank.Payment(amount);