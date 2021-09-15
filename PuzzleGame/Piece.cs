using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PuzzleGame
{
    class Piece
    {
        public Bitmap picture;
        public Rectangle homelocation, currentlocation;

        public Piece(Bitmap newPicture, Rectangle newHomeLocation)
        {
            picture = newPicture;
            homelocation = newHomeLocation;
        }

        public bool Contains(Point point)
        {
            return currentlocation.Contains(point);
        }

        public bool IsThePieceCloseToHome()
        {
            if ((Math.Abs(currentlocation.X - homelocation.X) >= 20) || 
                Math.Abs(currentlocation.Y - homelocation.Y) >= 20) return false;
            currentlocation = homelocation;
            return true;
        }

        public bool IsThePieceAtHome()
        {
            return homelocation.Equals(currentlocation);
        }
    }
}
