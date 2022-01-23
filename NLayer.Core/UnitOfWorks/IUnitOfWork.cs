namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Task SaveChangeAsync();
        /// </summary>
        Task SaveChangeAsync();
        /// <summary>
        /// // void SaveChanges();
        /// </summary>
        void SaveChange();
    }
}
