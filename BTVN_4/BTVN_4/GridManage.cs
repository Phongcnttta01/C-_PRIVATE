using System;
using System.Collections.Generic;

namespace BTVN_4
{
    public class GridManage
    {
        protected int XWide, YHigh;
        protected List<Enemy> Enemies;
        protected Player Player;
        protected List<Title> Titles;

        public GridManage(int xWide, int yHigh, List<Enemy> enemies, Player player, List<Title> titles)
        {
            XWide = xWide;
            YHigh = yHigh;
            Enemies = enemies;
            Player = player;
            Titles = titles;
        }

        public void SpawnTile(int x, int y)
        {
            if (x >= 0 && x < XWide && y >= 0 && y < YHigh)
            {
                Title newTile = new Title(x, y);
                Titles.Add(newTile);
            }
        }

        public void InitMap()
        {
            for (int y = 0; y < YHigh; y++)
            {
                for (int x = 0; x < XWide; x++)
                {
                    SpawnTile(x, y);
                }
            }
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < XWide && y >= 0 && y < YHigh;
        }

        public Title GetTileAt(int x, int y)
        {
            foreach (var title in Titles)
            {
                if (title.GetX() == x && title.GetY() == y)
                {
                    return title;
                }
            }
            return null;
        }

        public void SetPlayer(Player player, int x, int y)
        {
            if (player != null && IsValidPosition(x, y))
            {
                Player = player;
                Title tile = GetTileAt(x, y);
                if (tile != null)
                {
                    tile.SetCharacter(player);
                }
            }
        }

        public void AddEnemy(Enemy enemy, int x, int y)
        {
            if (enemy != null && IsValidPosition(x, y))
            {
                Enemies.Add(enemy);
                Title tile = GetTileAt(x, y);
                if (tile != null)
                {
                    tile.SetCharacter(enemy);
                }
            }
        }

        public void UpdateGrid()
        {
            // Clear all characters from tiles
            foreach (var title in Titles)
            {
                title.SetCharacter(null);
            }

            // Update player's position
            if (Player != null)
            {
                Title playerTile = GetTileAt(Player.GetPosX(), Player.GetPosY());
                if (playerTile != null)
                {
                    playerTile.SetCharacter(Player);
                }
            }

            // Remove defeated enemies
            Enemies.RemoveAll(enemy => enemy.HealthPoint <= 0);

            // Update enemies' positions
            foreach (var enemy in Enemies)
            {
                Title enemyTile = GetTileAt(enemy.GetPosX(), enemy.GetPosY());
                if (enemyTile != null)
                {
                    enemyTile.SetCharacter(enemy);
                }
            }
        }

        public void PrintGrid()
        {
            for (int y = 0; y < YHigh; y++)
            {
                for (int x = 0; x < XWide; x++)
                {
                    Title title = GetTileAt(x, y);
                    if (title != null && title.IsOccupied())
                    {
                        Console.Write(title.CheckPlayer() ? " O " : " X "); // Player or enemy
                    }
                    else
                    {
                        Console.Write(" . "); // Empty tile
                    }
                }
                Console.WriteLine();
            }

            if (Player.HealthPoint <= 0)
            {
                Console.WriteLine("Die !!");
            }
            else
            {
                Console.WriteLine("Health player: " + Player.HealthPoint);
            }

            foreach (var enemy in Enemies)
            {
                Console.WriteLine("Health enemy: " + enemy.HealthPoint);
            }
        }
    }
}
