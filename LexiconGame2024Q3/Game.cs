﻿

using LexiconGame2024Q3.Extensions;

internal class Game
{
    private Dictionary<ConsoleKey, Action> actionMenu;
    private Map map = null!;
    private Hero hero = null!;

    internal void Run()
    {
        Initialize();
        Play();
    }

    private void Play()
    {
        bool gameInProgress = true;

        do
        {
            //DrawMap
            DrawMap();

            //GetCommand
            GetCommand();

            //Act

            //DrawMap

            //EnemyAction

            //DrawMap


        } while (gameInProgress);
    }

    private void GetCommand()
    {
        ConsoleKey keyPressed = ConsoleUI.GetKey();

        switch (keyPressed)
        {
            case ConsoleKey.LeftArrow:
                Move(Direction.West);
                break;
            case ConsoleKey.RightArrow:
                Move(Direction.East);
                break;
            case ConsoleKey.UpArrow:
                Move(Direction.North);
                break;
            case ConsoleKey.DownArrow:
                Move(Direction.South);
                break;
                //case ConsoleKey.P:
                //    PickUp(); 
                //    break;
                //case ConsoleKey.I:
                //    Inventory(); 
                //    break;
        }



        if (actionMenu.ContainsKey(keyPressed))
            actionMenu[keyPressed]?.Invoke();
    }

    private void Inventory()
    {
        ConsoleUI.AddMessage(hero.BackPack.Count > 0 ? "Inventory:" : "No items");
        for (int i = 0; i < hero.BackPack.Count; i++)
        {
            ConsoleUI.AddMessage($"{i + 1}: {hero.BackPack[i]}");
        }
    }

    private void PickUp()
    {
        if (hero.BackPack.IsFull)
        {
            ConsoleUI.AddMessage("Backpack is full");
            return;
        }

        List<Item> items = hero.Cell.Items;
        Item? item = hero.Cell.Items.FirstOrDefault();

        if (item is null) return;

        if (hero.BackPack.Add(item))
        {
            ConsoleUI.AddMessage($"Hero picked up {item}");
            items.Remove(item);
        }


    }

    private void Move(Position movement)
    {
        Position newPosition = hero.Cell.Position + movement;
        Cell newCell = map.GetCell(newPosition);
        if (newCell is not null)
        {
            hero.Cell = newCell;

            if (newCell.Items.Any())
                ConsoleUI.AddMessage($"You see {string.Join(",", newCell.Items)}");
        } 
    }

    private void DrawMap()
    {
        ConsoleUI.Clear();
        ConsoleUI.Draw(map);
        ConsoleUI.PrintStats($"Hero's Health: {hero.Health}, Enemies: {map.Creatures.Count - 1}");
        ConsoleUI.PrintLog();
    }

    private void Initialize()
    {
        actionMenu = new Dictionary<ConsoleKey, Action>
        {
            {ConsoleKey.P, PickUp},
            {ConsoleKey.I, Inventory}
        };

        var r = new Random();
        //ToDo: Read from config maybe
        map = new Map(width: 10, height: 10);
        Cell heroCell = map.GetCell(0, 0);
        hero = new Hero(heroCell);
        map.Creatures.Add(hero);

        //map.GetCell(2, 2)!.Items.Add(Item.Coin());
        //map.GetCell(2, 2)!.Items.Add(Item.Coin());
        //map.GetCell(2, 2)!.Items.Add(Item.Coin());
        //map.GetCell(2, 2)!.Items.Add(Item.Stone());

        RCell().Items.Add(Item.Coin());
        RCell().Items.Add(Item.Coin());
        RCell().Items.Add(Item.Stone());
        RCell().Items.Add(Item.Stone());

        map.Place(new Orc(RCell()));
        map.Place(new Troll(RCell()));
        map.Place(new Goblin(RCell()));
        map.Place(new Orc(RCell()));
        map.Place(new Troll(RCell()));
        map.Place(new Troll(map.GetCell(0,5)!));
        map.Place(new Troll(map.GetCell(0,5)!));

        Cell RCell()
        {
            var width = r.Next(0, map.Width);
            var height = r.Next(0, map.Height);

            var cell = map.GetCell(width, height);

            ArgumentNullException.ThrowIfNull(cell, nameof(cell));

            return cell;
        }

    }
}