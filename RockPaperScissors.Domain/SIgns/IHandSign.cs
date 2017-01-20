namespace RockPaperScissors.Domain
{
    public interface IHandSign
    {
        GameResult Throw(IHandSign opponent);
    }
}