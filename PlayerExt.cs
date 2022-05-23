public static class PlayerExt
{
    public static void printInfo(this PlayerModel player)
    {
        Console.WriteLine($"Level:{player.ModelType}");
        Console.WriteLine($"Id:{player.Id}");
        Console.WriteLine($"Name:{player.Name}");
        Console.WriteLine($"Email:{player.Email}");
        Console.WriteLine($"Level:{player.Level}");
    }

}