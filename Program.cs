
using Chikebi_da_moneta;

Random rnd = new Random();
bool exit = false;
var game = new Game();

try
{

    while (!exit)
    {
        Console.WriteLine("");
        Console.WriteLine("chikebis raodenoba: minimaluri 3");

        game.glasses = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", ""));

        if (game.glasses < 3)
            game.glasses = 3;


        Console.WriteLine("cdebis raodenoba: min 1 max 20");
        game.steps = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", ""));

        if(game.steps > 20)
            game.steps = 20;

        game.randdomSelections = new int[game.steps];

        for (int i = 0; i < game.steps; i++)
        {
            game.randdomSelections[i] = rnd.Next(1, game.glasses + 1);
        }

        Console.WriteLine("kovel cdaze shecvalos tuara archeuli chika boloshi: 1 ki 0 ara");
        game.alwaysChangeSelectedGlassAtEnd = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", "")) == 1;

        Console.WriteLine("yovel cdaze random -ad airchios kompma tu ara romeli chiqa unda: 1 ki 0 ara");
        game.randomSelection = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", "")) == 1;

        if (!game.randomSelection)
        {
            Console.WriteLine("romeli chika airchios yovel cdaze? ricxvi 1 dan " + game.glasses + "-mde");
            game.selectedGlass = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", ""));

            if (game.selectedGlass > game.glasses)
            {
                game.selectedGlass = game.glasses;
            }

        }

        game.Play();

        Console.WriteLine("");
        Console.WriteLine("1 Tavidan Cda 0 Gasvla");
        exit = Convert.ToInt32(Console.ReadLine()?.Trim().Replace(" ", "")) != 1;
    }


}
catch
{
   
}
