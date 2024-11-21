using System;
using System.Collections.Generic;

namespace BTVN_4
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();
            List<Title> titles = new List<Title>();

            // Thêm các quái vật vào danh sách enemies
            enemies.Add(new Enemy(2, 8, 5, 3, 100)); // Quái vật 1
            enemies.Add(new Enemy(6, 9, 5, 3, 100)); // Quái vật 2
            enemies.Add(new Enemy(1, 2, 5, 3, 100)); // Quái vật 3

            Weapon weapon = new Weapon("Gun", 50, 2);
            Player player = new Player(0, 9, 10, 1, 1000, weapon);

            // Khởi tạo GameManager với kích thước grid 10x10
            GameManager gameManager = new GameManager(10, 10, enemies, player, titles, false);
            gameManager.InitMap();
            gameManager.SpawnEntity(player, player.PosX, player.PosY);
            gameManager.SetPlayer(player, player.PosX, player.PosY);
            gameManager.UpdateGrid();

            foreach (var enemy in enemies)
            {
                gameManager.UpdateGrid();
            }

            gameManager.PrintGrid();

            // Bắt đầu trận đấu
            gameManager.StartBattle(gameManager);
        }
    }
}