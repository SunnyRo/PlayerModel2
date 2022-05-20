public abstract class PlayerModel : IPlayerModel
{
    private readonly Guid _id = Guid.NewGuid();
    public Guid Id { get { return _id; } }
    public abstract string Name { get; set; }
    public abstract string Email { get; set; }
    public abstract string Level { get; set; }
    public abstract string ModelType { get; set; }
}