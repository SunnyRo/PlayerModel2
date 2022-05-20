internal interface IPlayerModel
{
    Guid Id { get; }
    string Name { get; set; }
    string Email { get; set; }
    string Level { get; set; }
    string ModelType { get; set; }
}