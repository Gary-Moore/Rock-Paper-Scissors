namespace RockPaperScissors.Domain.Players
{
    public interface IPlayer
    {
        IHandSign ChooseSign();
    }
}
