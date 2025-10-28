using Workshop.Models;

var account = new BankAccount("Alice", 1000m);
account.Deposit(200m);
var ok = account.Withdraw(50m);
Console.WriteLine(account);
Console.WriteLine($"Withdrawal success: {ok}");
