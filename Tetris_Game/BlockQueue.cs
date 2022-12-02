using System;

namespace Tetris_Game
{
    public class BlockQueue
    {
        public readonly Block[] blocks = new Block[] {
           new IBlock(),
           new JBlock(),
           new  LBlock(),
           new  OBlock(),
           new SBlock(),
           new TBlock(),
           new ZBlock()

        };
        private readonly Random random= new Random();   
        public Block NextBlock { get;private set; }

        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }
        public Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }
        public Block GetAndUpdate()
        {
            Block block = NextBlock;
            do{
                NextBlock = RandomBlock();
            } while (block.Id== NextBlock.Id);
            return block;
        } 
    }
}
