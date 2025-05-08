//1

using System.ComponentModel.DataAnnotations;
using System.Text;

for (int i = 1; i < 6; i++)
{
    Console.WriteLine(i);
}

//2
int x = 1;
while (x <= 10)
{
    if (x%2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}

//3
x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}

//4
string a;
while (true)
{
    Console.WriteLine("Enter word:");
    a = Console.ReadLine();
    if (a == "סיום")
    {
        break;
    }

}

//5
for (x = 0; x < 10; x++)
{
    Console.WriteLine("גישה נדחית");
}

//6
for (x = 1; x < 20; x++)
{
    if (x % 3 != 0)
    {
        Console.WriteLine(x);
    }
}

//7
x = 5;
while (x >= 1)
{
    Console.WriteLine(x);
    x--;
}
{
    
}

//8
for (x = 0; x < 10; x++)
{
    if ( x % 2 == 0)
    {
        Console.WriteLine($"{x} is even");
    }
    else
    {
        Console.WriteLine($"{x} is odd");
    }
}

//9
x = Convert.ToInt32(Console.ReadLine());
if (x == 8200)
{
    Console.WriteLine("בטוח");
}

//10
while (true)
{
    Console.WriteLine("Enter word:");
    a = Console.ReadLine();
    if (a == "admin")
    {
        break;
    }

}


//11
int count = 0;
for (x = 1; x <= 100; x++)
{
    count += x % 7 == 0 ? x : 0;
}
Console.WriteLine(count);

//12
a = Console.ReadLine();

Console.WriteLine(a.Length == 8 ? true : false);

//13
a = Console.ReadLine();
foreach (char c in a)
{
    Console.WriteLine(c);
}

//14
while (true)
{
    Console.WriteLine("Enter password");
    a = Console.ReadLine();
    if (a.Length == 8)
    {
        break;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}

//15
x = Convert.ToInt32(Console.ReadLine());
bool prime = true;
for (int i = 2; i <= (x -1); i++)
{
    if (x  % i == 0)
    {   
        prime = false;
        Console.WriteLine("לא ראשוני");
        break;
    }
}
if (prime)
{
    Console.WriteLine("ראשוני");
}

//16
bool entry = false;
for (int i = 0; i < 3; i++)
{
    a = Console.ReadLine();
    if (a == "12345678")
    {
        entry = true;
        Console.WriteLine("נכנסת בהצלחה");
    }
}
if (!entry)
{
    Console.WriteLine("הכניסה נדחית");
}

//17
a =  Console.ReadLine();
count = 0;

foreach (char c in a)
{
    if (char.IsDigit(c))
    {
        count ++;
    }
}
Console.WriteLine(count);

//21
string userName, password;
userName = Console.ReadLine();
password = Console.ReadLine();
Console.WriteLine(userName == "yossi" && password == "12345678" ? true : false);


//22
Random random = new Random();

password = "";

for (int i = 0; i < 6; i++)
{
    password += random.Next(1, 10);
}

Console.WriteLine(password);

//23
password = Console.ReadLine();
bool is_letter = false, is_digit = false;
foreach (char c in password)
{
    if (char.IsDigit(c))
    {
        is_digit = true;
    }
    else if (char.IsLetter(c))
    {
        is_letter = true;
    }
    if (is_letter && is_digit)
    {
        break;
    }
}
Console.WriteLine(is_letter && is_digit);

//24
password = Console.ReadLine();
StringBuilder result = new StringBuilder();
foreach (char c in password)
{
    if (char.IsDigit(c))
    {
        result.Append("מספר") ;
    }else
    {
        result.Append(c);
    }
}

//25
password = Console.ReadLine();
bool check = false;

foreach (char c in password)
{
    if ("8200".Contains(c))
    {
        check = true;
        break;
       
    }
}
Console.WriteLine(check);






