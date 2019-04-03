﻿#region The MIT License - Copyright (C) 2012-2019 Pieter Geerkens
/////////////////////////////////////////////////////////////////////////////////////////
//                PG Software Solutions - Hex-Grid Utilities
/////////////////////////////////////////////////////////////////////////////////////////
// The MIT License:
// ----------------
// 
// Copyright (c) 2012-2019 Pieter Geerkens (email: pgeerkens@users.noreply.github.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, 
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
// permit persons to whom the Software is furnished to do so, subject to the following 
// conditions:
//     The above copyright notice and this permission notice shall be 
//     included in all copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//     OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
//     NON-INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
//     HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
//     FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
//     OTHER DEALINGS IN THE SOFTWARE.
/////////////////////////////////////////////////////////////////////////////////////////
#endregion
using System.Collections.Generic;

using PGNapoleonics.HexUtilities;
using PGNapoleonics.HexUtilities.Common;

namespace PGNapoleonics.HexgridExampleCommon {
    using MapHex  = IHex;
    using HexSize = System.Drawing.Size;

    /// <summary>TODO</summary>
    public sealed class AStarBugMap : MapDisplayBlocked<MapHex> {
         /// <summary>TODO</summary>
         public AStarBugMap() : base(_sizeHexes, new HexSize(26,30), TerrainMap.InitializeHex) { }

        /// <inheritdoc/>
        public override short?  Heuristic(HexCoords source, HexCoords target)
        => (short)(MinimumStepCost * source.Range(target));

        /// <inheritdoc/>
        public override int    ElevationBase   =>  0;

        /// <inheritdoc/>
        public override int    ElevationStep   => 10;

        /// <summary>TODO</summary>
        protected override int MinimumStepCost => 2;

        #region static Board definition
        static IReadOnlyList<string> _board     = MapDefinitions.AStarBugMapDefinition;
        static HexSize               _sizeHexes = new HexSize(_board[0].Length, _board.Count);
        #endregion
    }
}
