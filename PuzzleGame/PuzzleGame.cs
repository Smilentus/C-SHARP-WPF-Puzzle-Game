using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class PuzzleGame : Form
    {
        private int Stupid = 0;
        private int End;
        private Random rnd = new Random();

        public PuzzleGame()
        { 
            MaximizeBox = false;
            InitializeComponent();
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Functions.LoadPicture(ofd.FileName, puzzleImageBox, this);
            }
        }

        private void SelectMode(object sender, EventArgs e)
        {
            var mode = (ToolStripMenuItem)sender;
            if(mode == VeryVeryEasyMode)
                Functions.targetSize = 400;
            if(mode == VeryEasyMode)
                Functions.targetSize = 300;
            if(mode == EasyMode)
                Functions.targetSize = 200;
            if(mode == MediumMode)
                Functions.targetSize = 100;
            if(mode == HardMode)
                Functions.targetSize = 50;
            if (mode == GiperHardMode)
                Functions.targetSize = 25;
            Functions.StartGame(puzzleImageBox);
        }

        private void puzzleImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (Functions.movingPiece == null) return;
            int dx = e.X - Functions.movingPoint.X;
            int dy = e.Y - Functions.movingPoint.Y;
            Functions.movingPiece.currentlocation.X += dx;
            Functions.movingPiece.currentlocation.Y += dy;
            Functions.movingPoint = e.Location;
            Functions.DrawBoard(puzzleImageBox);
        }

        private void puzzleImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (Functions.movingPiece == null) return;
            if (Functions.movingPiece.IsThePieceCloseToHome())
            {
                Functions.Pieces.Remove(Functions.movingPiece);
                Functions.Pieces.Reverse();
                Functions.Pieces.Add(Functions.movingPiece);
                Functions.Pieces.Reverse();
                Functions.GameOver = true;
                foreach (var piece in Functions.Pieces)
                {
                    if (piece.IsThePieceAtHome()) continue;
                    Functions.GameOver = false;
                    break;
                }
            }
            Functions.movingPiece = null;
            Functions.MakeBackground(puzzleImageBox);
            Functions.DrawBoard(puzzleImageBox);
            if (Functions.GameOver)
            {
                End = rnd.Next(0, 5);
                switch(End)
                {
                    case 0:
                        MessageBox.Show("Вы не глупая биомасса, гордитесь собой! Соберите ещё один пазл.");
                        break;
                    case 1:
                        MessageBox.Show("Я не ожидал от вас такого, продолжайте в том же духе! Соберите ещё один пазл.");
                        break;
                    case 2:
                        MessageBox.Show("Как вы это решили? Соберите ещё один пазл.");
                        break;
                    case 3:
                        MessageBox.Show("Не могу поверить, что такое существо как вы смогло решить такую сложную загадку. Соберите ещё один пазл.");
                        break;
                    case 4:
                        MessageBox.Show("Так держать, умница!!! Соберите ещё один пазл.");
                        break;
                }
            }
        }

        private void puzzleImage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Stupid++;
                Functions.movingPiece = null;
                foreach (var piece in Functions.Pieces)
                {
                    if (!piece.IsThePieceAtHome() && piece.Contains(e.Location))
                        Functions.movingPiece = piece;
                }
                if (Functions.movingPiece == null) return;
                Functions.movingPoint = e.Location;
                Functions.Pieces.Remove(Functions.movingPiece);
                Functions.Pieces.Add(Functions.movingPiece);
                Functions.MakeBackground(puzzleImageBox);
                Functions.DrawBoard(puzzleImageBox);
            }
            catch(Exception)
            {
                if (Stupid == 2)
                    MessageBox.Show("Ты тупой или да? Картинку выбери!");
                else if (Stupid == 3)
                {
                    Stupid = 0;
                    MessageBox.Show("Дебил, хватит кликать, выбирай картинку уже!!!");
                }
                else
                    MessageBox.Show("Для начала выберите картинку!");
            }
        }

        private void SolveIt_Click(object sender, EventArgs e)
        {
            Functions.SolveIt(puzzleImageBox);
        }

        private void chooseSize_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Functions.targetSize = Convert.ToInt32(chooseSize.Text);
                    Functions.StartGame(puzzleImageBox);
                }
            }
            catch(Exception)
            { }
        }

        private void chooseSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(chooseSize.Text) > 400)
                    chooseSize.Text = "400";
                if (Convert.ToInt32(chooseSize.Text) < 1)
                    chooseSize.Text = "1";
            }
            catch (Exception)
            { }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Небольшая помощь по игре! " + Environment.NewLine + "Интерфейс интуитивно понятен, но на всякий случай скажу - двигайте плитки на нужные места! " + Environment.NewLine + "В поле 1-400 введите любое число от 1 до 400 и нажмите клавишу [Enter], это разделит вставленную вами картинку на плитки указанным размером." + Environment.NewLine + "P.S. Лучше не ставьте значения 1-5, может повиснуть комп на несколько секунд, но после будет красивый пейзаж. "+Environment.NewLine+"Good Luck Commando!");
        }
    }
}
