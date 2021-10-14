namespace SampleWPF.Models
{
    public class MainWindow
    {
        public string Description { get; set; }
        public string Finish { get; set; }
        public string PurchaseInformation { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public double Length { get; set; }
        public string Status { get; init; }
        public string Revision { get; init; }
        public string PartNumber { get; init; }
        public string RawMaterial { get; set; }
        public double Mass { get; set; }
        public bool Weld { get; set; }
        public bool Assembly { get; set; }
        public bool Plasma { get; set; }
        public bool Laser { get; set; }
        public bool Purchase { get; set; }
        public bool Lathe { get; set; }
        public bool Drill { get; set; }
        public bool Fold { get; set; }
        public bool Roll { get; set; }
        public bool Saw { get; set; }
    }
}
