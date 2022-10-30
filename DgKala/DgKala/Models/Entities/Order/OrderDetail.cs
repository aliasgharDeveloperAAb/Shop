using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Order
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }

        #region Relation

        public Order Order { get; set; }
        public Category.Category Category { get; set; }

        #endregion
    }
}
