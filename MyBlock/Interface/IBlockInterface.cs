using MyBlock.mvc.Models;

namespace MyBlock.mvc.Interface
{   
    public interface IBlockInterface
    {
        List<Block> GetAllBlocks();
        Block GetById(Guid blockId);
        Block AddBlock(Block block);
        Block UpdateBlock(Block block);
        void DeleteBlock(Guid id);
    }
}

