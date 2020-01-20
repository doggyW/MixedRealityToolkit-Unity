﻿
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.UI
{
    /// <summary>
    /// Interface for defining a bounds target used by <see cref="AppBar"/>
    /// Implement this interface if you have a component that should be activated / deactivated by the AppBar
    /// </summary>
    internal interface IBoundsTargetProvider
    {

        /// <summary>
        /// Indicates if the provider is currently active
        /// </summary>
        bool Active
        {
            get;
            set;
        }

        /// <summary>
        /// The object that this component is targeting
        /// </summary>
        GameObject Target
        {
            get;
            set;
        }

        /// <summary>
        /// The collider reference tracking the bounds utilized by this component during runtime
        /// </summary>
        BoxCollider TargetBounds
        {
            get;
        }
    }
}
