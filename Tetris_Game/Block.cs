
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Tetris_Game
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }

        public abstract int Id { get; }


        public int rotationState;
        public Position offset;

        public Block(){
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePosition()
        {
            foreach(Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column); 
            }
        }

        //Rotate the block 90 degree clockwise

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        //Rotate to counter clockwise
        public void RotateCCW()
        {
            if(rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }
        public void Move (int row, int columns)
        {
            offset.Row += row;
            offset.Column += columns;
        }
        public void Reset()
        {
            rotationState = 0;
            offset.Row = offset.Row;
            offset.Column = offset.Column;
        }
    }   
   
}
