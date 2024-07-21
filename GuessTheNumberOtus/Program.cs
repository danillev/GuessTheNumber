using GuessTheNumberOtus;

public class Program
{
    static void Main(string[] args)
    {
        var randomNumberGenerator = new RandomNumberGenerator();
        var ui = new UserInterface();
        var gameSettings = new GameSettings(0, 1000, 10);
        var game = new GameLogic(randomNumberGenerator, gameSettings);

        game.Start(ui);

        
    }
}