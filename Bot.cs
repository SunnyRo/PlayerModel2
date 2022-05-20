public class Bot : PlayerModel
{
    private string name;
    private string email;
    private string level;
    private string modelType;
    public Bot()
    {
        string nameGenerator = string.Concat(Id.ToString().Substring(2, 5), "BOT");
        string emailGenerator = string.Concat(Id.ToString().Substring(2, 5), "@Dotnet.com");
        name = nameGenerator;
        email = emailGenerator;
        level = "99";
        modelType = "Bot";

    }
    public override string Name { get => name; set { } }
    public override string Email { get => email; set { } }
    public override string Level { get => level; set { } }
    public override string ModelType { get => modelType; set { } }

}