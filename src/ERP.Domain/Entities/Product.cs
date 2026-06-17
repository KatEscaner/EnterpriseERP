using ERP.Domain.Common;
using ERP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Entities;

public class Product : BaseEntity 
{
    public string Name { get; set; } = string.Empty;
    public string? Description {  get; set; }
    public string SKU { get; set; } = string.Empty;
    public decimal PurchusePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int Stock {  get; set; }
    public int MinimumStock { get; set; }
    public ProductStatus Status { get; set; } = ProductStatus.Active;
    public int CategoryId { get; set; }
    public Category category { get; set; } = null!;
}