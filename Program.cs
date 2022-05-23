using System.Text.RegularExpressions;
using System.Text.Json;
// Declare variable
string userInput;
string[] userInfo;
string option;
bool run = true;
List<PlayerModel> allModels = new List<PlayerModel>();
JsonSerializerOptions obtion = new() { WriteIndented = true };
// input validation method check if the input is empty or null
static bool isValid(String para)
{
    if (String.IsNullOrEmpty(para))
    {
        Console.WriteLine("Name cannot be null or empty");
        return false;
    }
    return true;
}
// input email validation method 
static bool isEmail(string email)
{
    string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";
    if (!Regex.IsMatch(email, pattern))
    {
        Console.WriteLine("Email is invalid! please try again");
        return false;
    }
    return true;
}
static bool isNumber(string number)
{
    int num;
    if (!Int32.TryParse(number, out num))
    {
        Console.WriteLine("Level must be a number");
        return false;
        if (!(num > 0 && num <= 99))
        {
            Console.WriteLine("Level must be in range 1-99");
            return false;

        }
    }
    return true;
}

try
{
    Console.WriteLine("-------------------------------------Hellow World-------------------------------------");
    while (run)
    {
        Console.WriteLine("--------------------------------Main Menu---------------------------------------------");
        Console.WriteLine("Please choose an option that you want to:");
        Console.WriteLine("Enter 1 Create a player");
        Console.WriteLine("Enter 2 (Cheat) Load a player with a given Level");
        Console.WriteLine("Enter 3 Create a bot");
        Console.WriteLine("Enter 4 Print all the models");
        Console.WriteLine("Enter 5 Write all user data to data.txt and data.json in current folder/directory");
        Console.WriteLine("Enter 6 Stop");
        option = Console.ReadLine();
        Console.WriteLine($"You've entered \"{option}\"!");
        if (option == "1")
        {
            Console.WriteLine("Please enter information of a player in the follow form:\nName,Email");
            userInput = Console.ReadLine();
            userInfo = userInput.Split(",");
            // validate the input before create and add it into a List of Models(both bots and players)
            if (isValid(userInfo[0]))
            {
                if (isEmail(userInfo[1]))
                {
                    allModels.Add(new Player(userInfo[0], userInfo[1]));
                }
            }
        }
        else if (option == "2")
        {
            Console.WriteLine("Aha you want to cheat! nice....\nPlease enter information of a player in the follow form:\nName,Email,Level");
            userInput = Console.ReadLine();
            userInfo = userInput.Split(",");
            // validate the input before create and add it into a List of Models(both bots and players)
            if (isValid(userInfo[0]))
            {
                if (isEmail(userInfo[1]))
                {
                    if (isNumber(userInfo[2]))
                    {
                        allModels.Add(new Player(userInfo[0], userInfo[1], userInfo[2]));

                    }
                }
            }
        }
        else if (option == "3")
        {
            Console.WriteLine("Generating a bot");
            allModels.Add(new Bot());
        }
        else if (option == "4")
        {
            Console.WriteLine("All models:");
            Console.WriteLine(allModels.Count);
            foreach (PlayerModel model in allModels)
            {
                Console.WriteLine("----------------------------------------------");
                model.printInfo();
            }
        }
        else if (option == "5")
        {
            // writting all user data to data.txt and data.json
            using (StreamWriter fw = new StreamWriter("data.txt"))
            {
                foreach (PlayerModel model in allModels)
                {
                    fw.WriteLine(model.ModelType + "," + model.Id + "," + model.Name + "," + model.Email + "," + model.Level);
                }
            }
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(allModels, options);
            File.WriteAllText("data.json", jsonString);

            Console.WriteLine("Done writting to a file.");
        }
        else if (option == "6")
        {
            run = false;
        }
        else
        {
            Console.WriteLine("Invalid input! please enter either 1, 2 or 3!");
        }
        Console.ReadKey();
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Something went wrong!");
}