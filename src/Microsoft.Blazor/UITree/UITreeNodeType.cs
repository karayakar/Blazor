﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Blazor.UITree
{
    /// <summary>
    /// Describes the type of a <see cref="UITreeNode"/>.
    /// </summary>
    public enum UITreeNodeType: int
    {
        /// <summary>
        /// Represents a container for other nodes.
        /// </summary>
        Element = 1,

        /// <summary>
        /// Represents text content.
        /// </summary>
        Text = 2,

        /// <summary>
        /// Represents a key-value pair associated with another <see cref="UITreeNode"/>.
        /// </summary>
        Attribute = 3,

        /// <summary>
        /// Represents a child component.
        /// </summary>
        Component = 4,
    }
}