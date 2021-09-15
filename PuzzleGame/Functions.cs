using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGame
{
    class Functions
    {
        public static Bitmap wholePicture, background, board;
        public static List<Piece> Pieces;
        public static int targetSize = 200;
        public static int numRow, numCol, rowHeight, colWidth;
        public static Piece movingPiece;
        public static Point movingPoint;
        public static bool GameOver = true;

        public static void LoadPicture(string filename, PictureBox puzzleImage, Form form)
        {
            try
            {
                using (var bm = new Bitmap(filename))
                {
                    wholePicture = new Bitmap(800, 600);
                    using (var gr = Graphics.FromImage(wholePicture))
                    {
                        gr.DrawImage(bm, 0, 0, 800, 600);
                    }
                }
                background = new Bitmap(800, 600);
                board = new Bitmap(800, 600);
                puzzleImage.Size = wholePicture.Size;
                puzzleImage.Image = board;
                form.ClientSize = new Size(puzzleImage.Right + puzzleImage.Left, puzzleImage.Bottom + puzzleImage.Left);
                StartGame(puzzleImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StartGame(PictureBox puzzleImage)
        {
            if (wholePicture == null) return;
            GameOver = false;
            numRow = wholePicture.Height / targetSize;
            rowHeight = wholePicture.Height / numRow;
            numCol = wholePicture.Width / targetSize;
            colWidth = wholePicture.Width / numCol;
            var rand = new Random();
            Pieces = new List<Piece>();
            for(int row = 0; row < numRow; row++)
            {
                int hgt = rowHeight;
                if (row == numRow - 1) hgt = wholePicture.Height - row * rowHeight;
                for(int col = 0; col < numCol; col++)
                {
                    int wid = colWidth;
                    if (col == numCol - 1) wid = wholePicture.Width - col * colWidth;
                    var rect = new Rectangle(col * colWidth, row * rowHeight, wid, hgt);
                    var newPiece = new Piece(wholePicture, rect)
                    {
                        currentlocation = new Rectangle(rand.Next(0, wholePicture.Width - wid),
                        rand.Next(0, wholePicture.Height - hgt),
                        wid, hgt)
                    };
                    Pieces.Add(newPiece);
                }
            }
            MakeBackground(puzzleImage);
            DrawBoard(puzzleImage);
        }

        public static void MakeBackground(PictureBox puzzleImage)
        {
            using (var gr = Graphics.FromImage(background))
            {
                gr.Clear(puzzleImage.BackColor);
                using (var thickpen = new Pen(Color.DarkGray, 3))
                {
                    for (int y = 0; y <= wholePicture.Height; y += rowHeight)
                    {
                        gr.DrawLine(thickpen, 0, y, wholePicture.Width, y);
                    }
                    gr.DrawLine(thickpen, 0, wholePicture.Height, wholePicture.Width, wholePicture.Height);
                    for(int x = 0; x <= wholePicture.Width; x += colWidth)
                    {
                        gr.DrawLine(thickpen, x, 0, x, wholePicture.Height);
                    }
                    gr.DrawLine(thickpen, wholePicture.Width, 0, wholePicture.Width, wholePicture.Height);
                }
                using (var whitepen = new Pen(Color.White, 1))
                {
                    using (var blackpen = new Pen(Color.Black, 1))
                    {
                        foreach(var piece in Pieces)
                        {
                            if (piece == movingPiece)
                                continue;
                            gr.DrawImage(wholePicture,
                                piece.currentlocation,
                                piece.homelocation,
                                GraphicsUnit.Pixel);
                            if (GameOver)
                                continue;
                            gr.DrawRectangle(piece.IsThePieceAtHome() 
                                ? whitepen : blackpen,
                                piece.currentlocation);
                        }
                    }
                }
            }
            puzzleImage.Visible = true;
            puzzleImage.Refresh();
        }

        public static void DrawBoard(PictureBox puzzleImage)
        {
            using (var gr = Graphics.FromImage(board))
            {
                gr.DrawImage(background, 0, 0, background.Width, background.Height);
                if(movingPiece != null)
                {
                    gr.DrawImage(wholePicture,
                        movingPiece.currentlocation,
                        movingPiece.homelocation,
                        GraphicsUnit.Pixel);
                    using (var bluepen = new Pen(Color.Blue, 4))
                    {
                        gr.DrawRectangle(bluepen, movingPiece.currentlocation);
                    }
                }
            }
            puzzleImage.Visible = true;
            puzzleImage.Refresh();
        }

        public static void SolveIt(PictureBox puzzleImage)
        {
            if (wholePicture == null) return;
            GameOver = false;
            numRow = wholePicture.Height / targetSize;
            rowHeight = wholePicture.Height / numRow;
            numCol = wholePicture.Width / targetSize;
            colWidth = wholePicture.Width / numCol;
            Pieces = new List<Piece>();
            for(int row = 0; row < numRow; row++)
            {
                int hgt = rowHeight;
                if (row == numRow - 1) hgt = wholePicture.Height - row * rowHeight;
                for(int col = 0; col < numCol; col++)
                {
                    int wid = colWidth;
                    if (col == numCol - 1) wid = wholePicture.Width - col * colWidth;
                    var rect = new Rectangle(col * colWidth, row * rowHeight, wid, hgt);
                    var newPiece = new Piece(wholePicture, rect)
                    {
                        currentlocation = rect
                    };
                    Pieces.Add(newPiece);
                }
            }
            MakeBackground(puzzleImage);
            DrawBoard(puzzleImage);
        }
    }
}
