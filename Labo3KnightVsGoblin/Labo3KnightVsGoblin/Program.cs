using System.Diagnostics;

Console.WriteLine("welcome to Knight vs Goblin");
Console.WriteLine("--------------------------");
Console.Write("Enter knight health: ");
string input = Console.ReadLine();

Random randomNumberGenerator = new Random();

int knightHealth;
if (int.TryParse(input, out knightHealth))
{
    if (knightHealth <= 0 || knightHealth > 100)

    {
        //waarde van getal te klein of te groot 
        Console.WriteLine("Invaild number, defult value 100 is used.");
        knightHealth = 100;
    }
}
else
{
    //ongeldig getal ingegeven
    Console.WriteLine("Invaild number, defult value 100 is used.");
    knightHealth = 100;
}
//initialiseer levenspunten van goblin
Console.WriteLine("knight health : " + knightHealth);
int goblinHealth = randomNumberGenerator.Next(1, 101);

Console.WriteLine($"goblin has {goblinHealth} health");



//for (int attemps = 1; attemps <= 4; attemps++)
do
{
    //Console.WriteLine($"Ronde {attemps}");
    int knightAttack = 10;
    int goblinAttack = randomNumberGenerator.Next(5, 16);

    Console.WriteLine("Choose an action");
    Console.WriteLine("1 of A: Attack");
    Console.WriteLine("2 of H: Heal");
    string selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "1":
        case "A":
            goblinHealth -= knightHealth;
            //console.ForegroundColor = ConsoleColor, Yellow;
            Console.WriteLine($"you attacked the goblin for {knightHealth} damage!");
            //Console.resetColor();
            break;
        case "2":
        case "H":
            knightHealth += 10;
            //console.ForegroundColor = ConsoleColor, Blue;
            Console.WriteLine($"you healed yourself for 10 health points!");
            //Console.resetColor();
            break;

        default:
            //console.ForegroundColor = ConsoleColor, Magent;
            Console.WriteLine($"Ibalid move! Please choose a vaild move.");
            //Console.resetColor();
            break;
    }



    if (goblinHealth >= 0)
    {
        knightHealth -= goblinHealth;
        //Console.ForgroundColor = ConsolColor.Yellow:
        Console.WriteLine($"You were attacked by the goblin for {goblinHealth} damage!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
    }
} while (knightHealth > 0 && goblinHealth > 0);
    
    




/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */





/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
