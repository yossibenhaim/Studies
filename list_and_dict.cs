// See https://aka.ms/new-console-template for more information

using System.Text;

List<string> names = new List<string> { "Yossi", "Nachman", "David", "Chim", "Yiask" };

names.Add("Shlomo");
names.Add("Golan");

names.Remove("Yossi");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i}. {names[i]}");
}

//2
Dictionary<string, int> dict = new Dictionary<string, int> {
    {"book",3},
    { "table",4},
    { "computer",4}
};

dict["book"] = 2;

foreach (KeyValuePair<string, int> pair in dict)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}

//3

List<Dictionary<string, string>> listUsers = new List<Dictionary<string, string>>();

for (int i = 0; i <= 1; i++)
{
    Console.WriteLine("send a name");
    string name = Console.ReadLine();
    Console.WriteLine("send a email");
    string email = Console.ReadLine();
    Console.WriteLine("send a status");
    string status = Console.ReadLine();

    listUsers.Add(new Dictionary<string, string>
{
    { "name", name },
    { "email",email },
    { "status", status}
});

}

foreach (Dictionary<string, string> user in listUsers)
{
    Console.Write($"user: {user["name"]} email is : ");
    Console.WriteLine(user["email"]);
}

//4

string[] listNames = new string[] { "Yossi", "Nachman", "David", "Chim", "Yiask" };

Console.WriteLine("send name :");
string name = Console.ReadLine();

int index = Array.IndexOf(listNames,name);
if (index >= 0)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("Username not registed");
}

//5


string[] namesSoldier = { "yossi", "nachman", "chaim", };

//string[] personalEquipment = { "recorder", "map", "notbook" };

List<Dictionary<string, string[]>> listDict = new List<Dictionary<string, string[]>>();

listDict.Add(new Dictionary<string, string[]>
{
    { "yossi", new string[]{"recorder", "map", "notbook" } },
    { "chaim", new string[]{"recorder", "map" } },
    {"nachman", new string[]{"map", "notbook"} }
});

foreach (Dictionary<string, string[]> users in listDict)
{
    { 
        for (int i = 0; i < namesSoldier.Length; i++)
        {
            if (users[namesSoldier[i]].Length > 3)
            {
                Console.WriteLine($"{ namesSoldier[i]} is ready for intel work!");
            }else{
                Console.WriteLine($"{namesSoldier[i]} is missing tools!");

            }
        }
        
        
    }
}





