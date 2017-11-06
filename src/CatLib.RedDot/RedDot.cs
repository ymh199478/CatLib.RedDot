﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System.Collections.Generic;

namespace CatLib.RedDot
{
    /// <summary>
    /// Red dot
    /// </summary>
    public class RedDot : IRedDot
    {
        /// <summary>
        /// Parent dot
        /// </summary>
        private IRedDot parent;

        /// <summary>
        /// Children dot
        /// </summary>
        private List<IRedDot> children;


    }
}
