int monsterHealth = 10;
int playerHealth = 10;
Random dice = new Random();

do
{
    int roll = dice.Next(1, 7);
    monsterHealth -= roll;
    Console.WriteLine($"Monster was hit for {roll} and now has {monsterHealth}");

    if (monsterHealth <= 0) continue;

    roll = dice.Next(1, 7);
    playerHealth -= roll;
    Console.WriteLine($"Player was hit for {roll} and now has {playerHealth}");
    Console.WriteLine("Press <enter> to continue");
    Console.ReadLine();

} while (playerHealth > 0 && monsterHealth > 0);

Console.WriteLine(playerHealth > monsterHealth ? "Player wins" : "Monster wins");