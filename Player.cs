public class Player : PlayerModel
{
    private string name;
    private string email;
    private string level;
    private string modelType;
    public Player(string name, string email, string level)
    {
        this.name = name;
        this.email = email;
        this.level = level;
        this.modelType = "Player";
    }
    public Player(string name, string email)
    {
        this.name = name;
        this.email = email;
        this.level = "1";
        this.modelType = "Player";
    }
    public override string Name { get => name; set { } }
    public override string Email { get => email; set { } }
    public override string Level { get => level; set { } }
    public override string ModelType { get => modelType; set { } }
}