using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game
{
    public class GameState
    {
        private Block currentBlock;
        
        public Block CurrentBlock
        { 
            get => currentBlock;
            private set
            {
                currentBlock = value;
                currentBlock.Reset();
            } 

        }  
        public GameGrid  GameGrid { get; set; }
        public BlockQueue BlockQueue { get; }
        public bool GameOver { get; private set; }  
    
        public GameState()
        {
            GameGrid = new GameGrid(22, 10);
            BlockQueue = new BlockQueue();
            currentBlock = BlockQueue.GetAndUpdate();
        }
        public bool BlockFits()
        {
            foreach (Position p in currentBlock.TilePosition())
            {
                if (!GameGrid.IsEmpty(p.Row,p.Column))
                {
                    return false;
                }
            }
            return true;
        }
        public void RotateBlockCW()
        {
            CurrentBlock.RotateCW();

            if(!BlockFits())
            {
                currentBlock.RotateCCW();
            }
        }
        public void RotateBlockCCW()
        {
            currentBlock.RotateCCW();
            if (!BlockFits())
            {
                currentBlock.RotateCW();    
            }
        }
        public void MoveBlockLeft()
        {
            currentBlock.Move(0,-1);
            if (!BlockFits())
            {
                currentBlock.Move(0,1);    
            }
        }
        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);

            if (!BlockFits())
            {
                currentBlock.Move(0, -1);
            }
        }
        private bool IsGameOver()
        {
            return !(GameGrid.IsRowFull(0) && GameGrid.IsRowEmpty(1));
        }
        private void PlaceBlock()
        {
            foreach(Position p in CurrentBlock.TilePosition()) 
            {
                GameGrid[p.Row, p.Column] = currentBlock.Id;
            }
            GameGrid.ClearFullRows();

            if (IsGameOver())
            {
                GameOver = true;

            }
            else
            {
                currentBlock = BlockQueue.GetAndUpdate(); 
            }
        } 
        public void MoveBlockDown()
        {
            CurrentBlock.Move(1, 0);
            if (!BlockFits())
            {
                CurrentBlock.Move(-1, 0);
                PlaceBlock();
            }
        }
    }

}
