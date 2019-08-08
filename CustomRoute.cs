using Penguin.Persistence.Abstractions.Attributes.Control;
using System;
using System.Collections.Generic;

namespace Penguin.Cms.Attributes
{
    /// <summary>
    /// For Dynamic Rendering, allows a property to be tagged with a specific MVC route for rendering
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class CustomRouteAttribute : Attribute
    {
        #region Properties

        /// <summary>
        /// The DisplayContext that this route applies to
        /// </summary>
        public DisplayContext Context { get; set; }

        /// <summary>
        /// The object dictionary representing the passed in route values
        /// </summary>
        public Dictionary<string, object> RouteValues { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructs a new instance of this attribute
        /// </summary>
        /// <param name="context">The display context this attribute should apply to</param>
        /// <param name="controller">The name of the controller to route to</param>
        /// <param name="action">The controller action to route to</param>
        /// <param name="area">The area the controller resides in</param>
        /// <param name="namespace">The namespace the controller resides in</param>
        public CustomRouteAttribute(DisplayContext context, string controller, string action, string area = "", string @namespace = "")
        {
            this.RouteValues = new Dictionary<string, object>
            {
                { "controller", controller },
                { "action", action },
                { "area", area },
                { "namespace", @namespace }
            };

            this.Context = context;
        }

        #endregion Constructors
    }
}