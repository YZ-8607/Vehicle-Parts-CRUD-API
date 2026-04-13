using Postgrest.Attributes;
using Postgrest.Models;

namespace VehiclePartsApi.Models;

[Table("parts")]
public class PartModel : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; }
    [Column("part_name")]
    public required String PartName { get; set;}
    [Column("part_number")]
    public required String PartNumber { get; set; }
    [Column("weight_kg")]
    public decimal WeightKg { get; set; }
    [Column("supplier_id")]
    public required int SupplierId { get; set; }
    [Column("is_active")]
    public bool IsActive { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}