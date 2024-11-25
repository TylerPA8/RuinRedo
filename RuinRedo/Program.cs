// See https://aka.ms/new-console-template for more information
using RuinRedo;
using RuinRedo.Enemy.Goblinoids;
using RuinRedo.Player.Player_Classes;
using RuinRedo.Statuses;

var attackLibrary = new AttackLibrary();
attackLibrary.InitializeAttacks();


Phalanx Asher = new("Asher", 10, 5, 25, 25, null, null, null, 1, 0);
Weaver Migan = new("Migan", 6, 2, 15, 15, null, null, null, 1, 0);
Goblin Goblin1 = new("Goblin", 8, 8, 7, 7, null, null, null, 0, 50);
Goblin Goblin2 = new("Goblin", 8, 8, 8, 8, null, null, null, 0, 50);
Block Block1 = new();
Block Block2 = new();

Utilities.DisplayCreature(Asher);
Utilities.DisplayCreature(Migan);
Utilities.DisplayCreature(Goblin1);
Utilities.DisplayCreature(Goblin2);

Creature[] players = { Block2, Block1, Migan, Asher };

Creature[] enemies = { Goblin1, Goblin2, Block1, Block2 };

//foreach (Creature o in players)
//{
//    Console.Write("[ ");
//    if (o is Block)
//        Console.Write($"Block ");
//    else
//        Console.Write($"{ o.Name} ");
//    Console.Write("]");
//}
//Console.Write("\t");
//foreach (Creature o in enemies)
//{
//    Console.Write("[ ");
//    if (o is Block)
//        Console.Write($"Block ");
//    else
//        Console.Write($"{o.Name} ");
//    Console.Write("]");
//}
Console.WriteLine();

//Asher.Move(players);

//foreach (Creature o in players)
//{
//    Console.Write("[ ");
//    if (o is Block)
//        Console.Write($"Block ");
//    else
//        Console.Write($"{o.Name} ");
//    Console.Write("]");
//}
//Console.Write("\t");
//foreach (Creature o in enemies)
//{
//    Console.Write("[ ");
//    if (o is Block)
//        Console.Write($"Block ");
//    else
//        Console.Write($"{o.Name} ");
//    Console.Write("]");
//}
//Console.WriteLine();