using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<ClienteEntity> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-CMEJDLF\\SQLEXPRESS01;Initial Catalog=ClinicaVeterinaria;Integrated Security=True; Encrypt=False");
    }
}

public class ClienteEntity
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string email { get; set;}
    }
