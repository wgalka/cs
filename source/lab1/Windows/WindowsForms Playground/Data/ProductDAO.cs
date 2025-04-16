using Bogus;
using WindowsForms_Playground.data;

namespace WindowsForms_Playground.Data {
    internal class ProductDAO {
        private List<Product> products = new List<Product>();
        private int nextId = 1;

        public ProductDAO() {
            products = GenerateFakeProducts(50);
            nextId = products.Max(p => p.Id) + 1;
        }

        public List<Product> GetAll(bool includeDeleted = false) {
            return includeDeleted
                ? products.ToList()
                : products.Where(p => !p.IsDeleted).ToList();
        }

        public Product GetById(int id) {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product) {
            product.Id = nextId++;
            product.CreatedAt = DateTime.Now;
            products.Add(product);
        }

        public void Update(Product product) {
            var existing = GetById(product.Id);
            if (existing != null && !existing.IsDeleted) {
                existing.Name = product.Name;
                existing.Description = product.Description;
                existing.Category = product.Category;
                existing.Price = product.Price;
                existing.QuantityInStock = product.QuantityInStock;
                existing.SKU = product.SKU;
                existing.Supplier = product.Supplier;
                existing.UpdatedAt = DateTime.Now;
            }
        }

        public void SoftDelete(int id) {
            var product = GetById(id);
            product?.SoftDelete();
        }

        public List<Product> Search(string term) {
            if (string.IsNullOrWhiteSpace(term)) return GetAll();

            return products
                .Where(p => !p.IsDeleted &&
                    (p.Name.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.Description.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.Category.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.Supplier.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.SKU.Contains(term, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

        public void Restore(int id) {
            var product = GetById(id);
            if (product != null && product.IsDeleted) {
                product.IsDeleted = false;
                product.DeletedAt = null;
            }
        }

        public List<Product> GetSortedPage(string sortBy, bool ascending, int pageNumber, int pageSize) {
            var query = products.Where(p => !p.IsDeleted);

            // Dynamic sorting
            query = sortBy switch {
                "Name" => ascending ? query.OrderBy(p => p.Name) : query.OrderByDescending(p => p.Name),
                "Price" => ascending ? query.OrderBy(p => p.Price) : query.OrderByDescending(p => p.Price),
                "QuantityInStock" => ascending ? query.OrderBy(p => p.QuantityInStock) : query.OrderByDescending(p => p.QuantityInStock),
                "CreatedAt" => ascending ? query.OrderBy(p => p.CreatedAt) : query.OrderByDescending(p => p.CreatedAt),
                _ => query.OrderBy(p => p.Id) // default sort
            };

            return query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        // Get the total number of products (without soft deleted products)
        public int GetCount(bool includeDeleted = false) {
            return includeDeleted
                ? products.Count
                : products.Count(p => !p.IsDeleted);
        }

        // Get the count of active products (those not soft deleted)
        public int GetActiveCount() {
            return products.Count(p => !p.IsDeleted);
        }


        public static List<Product> GenerateFakeProducts(int count) {
            int id = 1;

            var faker = new Faker<Product>()
                .RuleFor(p => p.Id, f => id++)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Category, f => f.Commerce.Categories(1)[0])
                .RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price(5, 500)))
                .RuleFor(p => p.QuantityInStock, f => f.Random.Int(0, 150))
                .RuleFor(p => p.SKU, f => f.Commerce.Ean13())
                .RuleFor(p => p.Supplier, f => f.Company.CompanyName())
                .RuleFor(p => p.IsActive, f => true)
                .RuleFor(p => p.CreatedAt, f => f.Date.Past(1))
                .RuleFor(p => p.UpdatedAt, f => null)
                .RuleFor(p => p.IsDeleted, f => false)
                .RuleFor(p => p.DeletedAt, f => null);

            return faker.Generate(count);
        }
    }
}
