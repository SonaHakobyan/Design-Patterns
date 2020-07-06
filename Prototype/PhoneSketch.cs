using System;

namespace Prototype
{
    /// <summary>
    /// Specify the kind of objects to create using a prototypical instance,
    /// and create new objects by copying this prototype.
    /// </summary>
    public class PhoneSketch : ICloneable
    {
        /// <summary>
        /// Model name
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Hardware name
        /// </summary>
        public string Hardware { get; set; }

        /// <summary>
        /// Operation system
        /// </summary>
        public OperationSystem OS { get; set; }

        /// <summary>
        /// Clone current instance
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.DeepCopy();
        }
    }
}
