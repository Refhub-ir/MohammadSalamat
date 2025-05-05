using Microsoft.EntityFrameworkCore;

namespace RefhubMVC.DB_context
{
    public class Refhub_db : DbContext
    {
        public Refhub_db(DbContextOptions<Refhub_db> options) : base(options) { }
    }
}
