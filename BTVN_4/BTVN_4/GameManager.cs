using System;
using System.Collections.Generic;

namespace BTVN_4
{
    public class GameManager : GridManage
    {
        protected bool Turn;

        public GameManager(int xWide, int yHigh, List<Enemy> enemies, Player player, List<Title> titles, bool turn)
            : base(xWide, yHigh, enemies, player, titles)
        {
            Turn = turn;
        }

        public int GetXWide()
        {
            return XWide;
        }

        public void SetXWide(int xWide)
        {
            XWide = xWide;
        }

        public int GetYHigh()
        {
            return YHigh;
        }

        public void SetYHigh(int yHigh)
        {
            YHigh = yHigh;
        }

        public List<Enemy> GetEnemies()
        {
            return Enemies;
        }

        public void SetEnemies(List<Enemy> enemies)
        {
            Enemies = enemies;
        }

        public Player GetPlayer()
        {
            return Player;
        }

        public void SetPlayer(Player player)
        {
            Player = player;
        }

        public bool IsTurn()
        {
            return Turn;
        }

        public void SetTurn(bool turn)
        {
            Turn = turn;
        }

        public void StartBattle(GameManager map)
        {
            Console.WriteLine("Battle has started!");
            // Bắt đầu vòng lặp trận đấu
            while (!CheckWinOrLose())
            {
                if (!Turn)
                {
                    TurnPlayer(map);
                    Turn = true;
                }
                else
                {
                    TurnEnemy(map);
                    Turn = false;
                }

                if (CheckWinOrLose())
                {
                    break;
                }
            }
        }

        public void SpawnEntity(Character entity, int x, int y)
        {
            entity.PosX = x;
            entity.PosY = y;
            if (entity is Enemy)
            {
                Enemies.Add((Enemy)entity);
            }
        }

        public void TurnPlayer(GridManage map)
        {
            Console.WriteLine("It's Player's turn:");
            Player.Move(Player.GetPosX(), Player.GetPosY(), XWide, YHigh);
            map.SetPlayer(Player, Player.GetPosX(), Player.GetPosY());

            foreach (var enemy in Enemies)
            {
                Player.Attack(enemy);
            }

            map.UpdateGrid();
            map.PrintGrid();
        }

        public void TurnEnemy(GridManage map)
        {
            Console.WriteLine("It's Enemy's turn.");
            foreach (var enemy in Enemies)
            {
                enemy.MoveRandom();
                enemy.Attack(Player);
            }

            map.UpdateGrid();
            map.PrintGrid();
        }

        public bool CheckWinOrLose()
        {
            if (Player.HealthPoint <= 0) return true;

            int defeatedEnemies = 0;
            foreach (var enemy in Enemies)
            {
                if (enemy.HealthPoint <= 0) defeatedEnemies++;
            }

            if (Enemies.Count == defeatedEnemies) return true;

            return false;
        }
    }
}
