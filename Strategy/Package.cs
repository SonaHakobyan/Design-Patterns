using Strategy.Enums;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Defines a basic package to be shipped.
    /// Contains package content and packing materials used.
    /// </summary>
    public class Package
    {
        public string Content { get; set; }
        public ShipmentMode ShipmentMode { get; set; }
        public List<PackingMaterial> Materials { get; set; }

        public Package(string content)
        {
            this.Content = content;
            this.Materials = new List<PackingMaterial>();
        }

        /// <summary>
        /// Outputs package Content and comma-delimited list of packing materials and shipment mode
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            return $"{this.Content} was packaged using {string.Join(", ", Materials.ToArray())} and was shipped by {this.ShipmentMode}.";
        }
    }
}