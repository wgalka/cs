namespace WindowsForms_Playground.data {
    public class Product {
        public int Id { get; set; }                        // Unique identifier
        public string Name { get; set; }                   // Product name
        public string Description { get; set; }            // Optional description
        public string Category { get; set; }               // Category name
        public decimal Price { get; set; }                 // Price per unit
        public int QuantityInStock { get; set; }           // Current stock level
        public string SKU { get; set; }                    // Stock Keeping Unit
        public string Supplier { get; set; }               // Supplier name
        public bool IsActive { get; set; }                 // Whether product is available
        public DateTime CreatedAt { get; set; }            // Timestamp for creation
        public DateTime? UpdatedAt { get; set; }           // Optional timestamp for last update
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        public Product() {
            CreatedAt = DateTime.Now;
            IsActive = true;
        }

        public void SoftDelete() {
            IsDeleted = true;
            DeletedAt = DateTime.Now;
        }



        public override string ToString() {
            return $"{Name} ({SKU}) - ${Price} - {QuantityInStock} in stock";
        }
    }
}
