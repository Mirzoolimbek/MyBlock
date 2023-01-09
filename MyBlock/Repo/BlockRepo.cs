using MyBlock.mvc.DataLayer;
using MyBlock.mvc.Interface;
using MyBlock.mvc.Models;

public class BlockRepo : IBlockInterface
{
    private readonly DataContext _datacontext;

    public BlockRepo(DataContext dataContext)
    {
        _datacontext = dataContext;
    }
    public Block AddBlock(Block block)
    {
        _datacontext.Blocks.Add(block);
        _datacontext.SaveChanges();
        return block;
    }

    public void DeleteBlock(Guid id)
    {
        var block = _datacontext.Blocks.FirstOrDefault(f => f.Id == id);
        _datacontext.Blocks.Remove(block);
        _datacontext.SaveChanges();
    }

    public List<Block> GetAllBlocks()
    {
        var allBlock = _datacontext.Blocks.ToList();
        return allBlock;
    }

    public Block GetById(Guid blockId)
    {
        var block = _datacontext.Blocks.FirstOrDefault(f => f.Id == blockId);
        return block;
    }

    public Block UpdateBlock(Block block)
    {
        _datacontext.Blocks.Update(block);
        _datacontext.SaveChanges();
        return block;
    }
}
