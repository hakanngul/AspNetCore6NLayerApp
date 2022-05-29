using NLayer.Core.UnitOfWorks;

namespace NLayer.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
