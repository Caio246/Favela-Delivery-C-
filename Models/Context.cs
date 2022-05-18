﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavelaDelivery.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options) : base(Options)
        {

        }
        public DbSet<CadastroCliente> cadastrocliente { get; set; }
        public DbSet<CadastroEmpreendedor> cadastroempreendedor { get; set; }
        public DbSet<CadastroEntregador> cadastroentregador { get; set; }
       }
    }