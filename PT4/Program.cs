namespace PT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Club<Player> club = new Club<Player>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Create new Player");
                Console.WriteLine("2. List all players");
                Console.WriteLine("3. Search player by Name");
                Console.WriteLine("4. Raise Attack Event");
                Console.WriteLine("5. Raise Defense Event");
                Console.WriteLine("6. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreatePlayer(club);
                        break;
                    case 2:
                        ListPlayers(club);
                        break;
                    case 3:
                        SearchPlayer(club);
                        break;
                    case 4:
                        club.RaiseAttackEvent();
                        break;
                    case 5:
                        club.RaiseDefenseEvent();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreatePlayer(Club<Player> club)
        {
            Player player = new Player();

            Console.Write("Enter Name: ");
            player.Name = Console.ReadLine();

            player.Age = GetIntInput("Enter Age: ", 0, 40);
            player.Attack = GetIntInput("Enter Attack: ", 0, 100);
            player.Defense = GetIntInput("Enter Defense: ", 0, 100);
            player.Stamina = GetIntInput("Enter Stamina: ", 0, 100);
            player.Speed = GetIntInput("Enter Speed: ", 0, 100);
            player.Power = GetIntInput("Enter Power: ", 0, 100);

            club.Add(player);
        }

        static int GetIntInput(string prompt, int min, int max)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value > min && value < max)
                {
                    break;
                }
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
            return value;
        }

        static void ListPlayers(Club<Player> club)
        {
            foreach (var player in club)
            {
                player.GetInfor();
            }
        }

        static void SearchPlayer(Club<Player> club)
        {
            Console.Write("Enter Name to search: ");
            string name = Console.ReadLine();

            foreach (var player in club)
            {
                if (player.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    player.GetInfor();
                    return;
                }
            }

            Console.WriteLine("Player not found.");
        }
    }
}
