using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Classes
{
   public class Block
    {

        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public Block(int[] input)
        {
            Width = input[0];
            Length = input[1];
            Height = input[2];
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetLength()
        {
            return Length;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetVolume()
        {
            return Height * Length * Width;
        }

        public int GetSurfaceArea()
        {
            return (Height * Width + Height * Length  + Width * Length) * 2;
        }
    }
}
