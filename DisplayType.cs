using System;

namespace Penguin.Cms.Attributes
{
    /// <summary>
    /// Specifies that during dynamic display, this property should be treated as a different type
    /// </summary>
    public class DisplayType : Attribute
    {
        #region Properties

        /// <summary>
        /// The FullName of the type to treat this property as
        /// </summary>
        public string Name { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance of this attribute
        /// </summary>
        /// <param name="name">The full name of the type to render this property as</param>
        public DisplayType(string name)
        {
            Name = name;
        }

        #endregion Constructors
    }
}