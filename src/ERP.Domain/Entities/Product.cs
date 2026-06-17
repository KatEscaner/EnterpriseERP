using ERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Entities;

public class Product : BaseEntity {
    public string Name { get; set; } = string.Empty;
    public string? Description {  get; set; }
    public string SKU { get; set; } = string.Empty;
    public decimal PurchusePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int Stock {  get; set; }
    public int MinimumStock { get; set; }
    public bool IsActive { get; set; } = true;
    public int CategoryId { get; set; }
    public Category category { get; set; } = null!;
}