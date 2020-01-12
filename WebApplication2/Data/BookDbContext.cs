using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.AccountViewModels;

namespace WebApplication2.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }


        public DbSet<BookModel> Books { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }

    }
}
