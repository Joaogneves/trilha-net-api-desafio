using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace api_desafio.Context
{
    public class OrganizadorContext: DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}