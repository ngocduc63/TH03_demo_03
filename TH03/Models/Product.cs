namespace TH03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int id { get; set; }

        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        public string name { get; set; }

        [DisplayName("Giá niêm yết")]
        public double? unitPrice { get; set; }

        [StringLength(50)]
        [DisplayName("Ảnh")]
        public string image { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tạo")]
        public DateTime? productDate { get; set; }

        [DisplayName("Có sẵn")]
        public int? available { get; set; }

        [DisplayName("Lọai sản phẩm")]
        public int? categoryId { get; set; }

        [StringLength(50)]
        [DisplayName("Mô tả")]
        public string description { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
