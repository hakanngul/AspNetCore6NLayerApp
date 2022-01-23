

namespace NLayer.Core.Models

{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        // 1-Çok işlişki yapma durumunu anlatıyor.  ICollection<Product> Products
        public ICollection<Product> Products { get; set; }
    }
}
