// See https://aka.ms/new-console-template for more information
using RuinRedo;
using RuinRedo.Enemy.Goblinoids;
using RuinRedo.Player.Player_Classes;

var attackLibrary = new AttackLibrary();
attackLibrary.InitializeAttacks();


Phalanx Asher = new("Asher", 10, 5, 25, 25, null, null, 1, 0);
Weaver Migan = new("Migan", 6, 2, 15, 15, null, null, 1, 0);
Goblin Goblin1 = new("Goblin", 8, 8, 7, 7, null, null, 0, 50);
Goblin Goblin2 = new("Goblin", 8, 8, 8, 8, null, null, 0, 50);

Utilities.DisplayCreature(Asher);
Utilities.DisplayCreature(Migan);
Utilities.DisplayCreature(Goblin1);
Utilities.DisplayCreature(Goblin2);