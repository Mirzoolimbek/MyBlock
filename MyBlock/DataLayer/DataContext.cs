﻿using MyBlock.mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace MyBlock.mvc.DataLayer
{
    public class DataContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }


        public DbSet<Block> Blocks { get; set; }




    }

}
