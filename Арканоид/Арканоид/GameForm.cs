using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Арканоид
{
    public partial class GameForm : Form
    {
        int paddleX, paddleY, ballX, ballY; // координаты PictureBox'ов ракетки и мячика
        double ballShift_x = 6, ballShift_y = 6; // скорость мячика
        double curBallShift_x, curBallShift_y; // меняющаяся скорость мячика

        // вспомогательные переменные окончания игры
        bool end = false;
        bool lose = false;
        bool win = false;

        int accelerationFlag = 0; // флаг ускорения шарика

        // массив блоков
        PictureBox[,] pb = new PictureBox[9,4]; 
        string[] names = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        Random rnd = new Random(); // случайное число для ускорения шарика
        int bricksCount = 72; // число невыбитых блоков

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
        }
        
        private void InitializeGame() // метод, стартующий при запуске игровой формы
        {           
            // присвоение значений координат ракетки
            paddleX = paddle.Location.X;
            paddleY = paddle.Location.Y;

            // присвоение значений координат шарика
            ballX = ball.Location.X;
            ballY = ball.Location.Y;

            // задание направления полета шарика
            curBallShift_x = ballShift_x;
            curBallShift_y = -ballShift_y;
            
            // заполнение игрового поля кирпичами
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    // создание одного кирпича
                    pb[x,y] = new PictureBox();                   
                    pb[x,y].Name = "PictureBox" + x.ToString() + y.ToString();
                    pb[x, y].SizeMode = PictureBoxSizeMode.Zoom;
                    string randomName = names[rnd.Next(names.Length)];
                    pb[x, y].Image = Properties.Resources.ResourceManager.GetObject(randomName) as Bitmap; 
                    pb[x,y].Size = new Size(Convert.ToInt32(170/2.8), Convert.ToInt32(56/2.8)); 
                    pb[x, y].Location = new Point(52 + x * pb[x,y].Width, 15 + y * pb[x, y].Height);  
                    
                    // добавление его на форму
                    Controls.Add(pb[x,y]);
                }
            }
        }

        private void ShiftPaddle(int PaddleShift) // метод движения ракетки
        {
            // координаты левой и правой стороны ракетки
            double pLeftSide = paddleX + PaddleShift;
            double pRightSide = pLeftSide + paddle.Width;

            // остановка ракетки при достижении краев игрового поля
            if (pLeftSide < 0) return;
            if (pRightSide > 651) return;
               
            // движение ракетки
            paddleX += PaddleShift;
            paddle.Location = new Point(paddleX, paddleY);            
        }

        // обработчик событий нажатия клавиш
        private void GameForm_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) ShiftPaddle(-9);
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) ShiftPaddle(9);
        }

        private void ShiftBall() // метод движения шарика
        {
            // координаты шарика
            double bx1, by1,
                   bx2, by2;
            bx1 = ballX;
            bx2 = bx1 + ball.Width;
            by1 = ballY;
            by2 = by1 + ball.Height;

            if (by2 + curBallShift_y > 450) // завершение игры при проигрыше
            {               
                YouLose();
            }

            // отталкивание от стенок
            if (bx1 + curBallShift_x < 0) // от левой
            {
                if (accelerationFlag > 0)
                {
                    curBallShift_x = ballShift_x + 3;
                    accelerationFlag--;
                }
                else curBallShift_x = ballShift_x;
            }
            if (bx2 + curBallShift_x > 651) // от правой
            {
                if (accelerationFlag > 0)
                {
                    curBallShift_x = -ballShift_x - 3;
                    accelerationFlag--;
                }
                else curBallShift_x = -ballShift_x;
            }
            if (by1 + curBallShift_y < 0) curBallShift_y = ballShift_y; // от верхней

            // отталкивание от ракетки
            if (by2 + curBallShift_y > paddleY && !end)
            {
                double bx0, px1, px2;
                bx0 = (bx1 + bx2) / 2;
                px1 = paddleX;
                px2 = px1 + paddle.Width;
                if (px1 <= bx0 && bx0 <= px2) // от верхней части
                    curBallShift_y = -ballShift_y - rnd.Next(0,5);
                else
                if (px1 <= bx2 + (ball.Width) && bx2 + (ball.Width) <= px2) // от правого угла
                {
                    curBallShift_y = -ballShift_y;
                    curBallShift_x = -ballShift_x - 8;
                    accelerationFlag++;
                }
                else
                if (px1 <= bx1 - (ball.Width) && bx1 - (ball.Width) <= px2) // от левого угла
                {
                    curBallShift_y = -ballShift_y;
                    curBallShift_x = ballShift_x + 8;
                    accelerationFlag++;
                }
                else
                {
                    end = true; // переменная конца игры           
                }
            }
            // перемещение мячика
            ballX += Convert.ToInt32(curBallShift_x);
            ballY += Convert.ToInt32(curBallShift_y);
            ball.Location = new Point(ballX, ballY);

            // проверка каждого блока на столкновение с мячиком
            foreach (PictureBox brick in pb)
                CrossBrick(brick);
        }

        private void YouLose() // функция проигрыша
        {
            timer.Enabled = false;
            lose = true;
            Close();            
        }
      
        // таймер, отвечающий за движение мячика
        private void timer_Tick(object sender, EventArgs e) 
        {
            ShiftBall();
        }      

        // функция пересечения мячика с блоком
        private void CrossBrick(PictureBox brick)
        {
            if (!brick.Visible) return;
            double bx1, bx0, bx2,
                   by1, by0, by2;
            double brx1, brx2,
                   bry1, bry2;
            bx1 = ballX;
            bx2 = bx1 + ball.Width;
            bx0 = (bx1 + bx2) / 2;
            by1 = ballY;
            by2 = by1 + ball.Height;
            by0 = (by1 + by2) / 2;
            brx1 = brick.Location.X;
            brx2 = brx1 + brick.Width;
            bry1 = brick.Location.Y;
            bry2 = bry1 + brick.Height;

            // если столкновение произошло с верхней стороной кирпича
            if (brx1 <= bx0 && bx0 <= brx2 &&
                bry1 <= by2 && by2 <= bry2)
            {
                DamageBrick(brick);
                curBallShift_y = -curBallShift_y;
                return;
            }

            // с нижней стороной
            if (brx1 <= bx0 && bx0 <= brx2 &&
                bry1 <= by1 && by1 <= bry2)
            {
                DamageBrick(brick);
                curBallShift_y = -curBallShift_y;
                return;
            }

            // с левой стороной
            if (brx1 <= bx1 && bx1 <= brx2 &&
                bry1 <= by0 && by0 <= bry2)
            {
                DamageBrick(brick);
                curBallShift_x = -curBallShift_x;
                return;
            }

            // с правой стороной
            if (brx1 <= bx2 && bx2 <= brx2 &&
                bry1 <= by0 && by0 <= bry2)
            {
                DamageBrick(brick);
                curBallShift_x = -curBallShift_x;
                return;
            }
        }

        // функция уничтожения кирпича
        private void DamageBrick(PictureBox brick)
        {
            brick.Visible = false;
            bricksCount--;

            if (bricksCount == 0) // завершение игры при победе
            {
                timer.Enabled = false;
                win = true;
                Close();                             
            }
        }

        // обработчик события закрытия формы, происходящего при завершении игры
        private void GameForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            // вывод окна победы
            if (win)
            {
                WinOrLoseForm wol = new WinOrLoseForm();
                wol.LoseWin.Text = "Вы выиграли!";
                wol.ShowDialog();
            }

            // вывод окна проигрыша
            if (lose)
            {
                WinOrLoseForm wol = new WinOrLoseForm();
                wol.LoseWin.Text = "Вы проиграли :-(";
                wol.ShowDialog();
            }
        }
    }
}
