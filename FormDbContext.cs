
using Microsoft.EntityFrameworkCore;
using OrderApplicationPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace OrderApplicationPage.Data
{

    public class FormDbContext : DbContext
    {
        // type ctor and tab for constractors
        public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
        {

        }

        //to push to the database
        public DbSet<Order> Orders { get; set; }


    }


}

