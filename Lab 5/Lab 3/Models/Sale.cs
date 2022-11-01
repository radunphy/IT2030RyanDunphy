using System.ComponentModel.DataAnnotations;

namespace Lab_3.Models
{
    public class Sale
    {
        [Required(ErrorMessage = "Please enter a value for the sale price")]
        [Range(0, double.MaxValue, ErrorMessage = "Sale price must be greater than 0")]
        public decimal? SaleAmount { get; set; }
       
        [Required(ErrorMessage = "Please enter a value for tax rate")]
        [Range(0, 10, ErrorMessage = "Tax Rate must be between 0 and 10")]
        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount()
        {
            if (TaxRate < 1 && TaxRate > 0)
                return (SaleAmount * TaxRate);
            else
                return (SaleAmount * TaxRate) / 100;
        }

        public decimal? TotalSalePrice()
        {
            return (SaleAmount + TaxAmount());
        }
    }
}
