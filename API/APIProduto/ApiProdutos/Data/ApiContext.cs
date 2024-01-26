using ApiProdutos.Dtos;
using ApiProdutos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options)  { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<User> Usuarios { get; set; }
    }
}
