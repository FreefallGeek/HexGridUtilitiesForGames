This elegant algorithm is from [James McNeill](http://playtechs.blogspot.ca/2007/04/hex-grids.html). I cannot say much to improve on his explanation, so I will only note that a few details specific to this implementation have been filled in. 

From the **Grid Coordinates** section of **HexgridPanel.cs**:

{{
    /// Mathemagically (left as exercise for the reader) our 'picking' matrices are 
    /// these, assuming: 
    ///  - origin at upper-left corner of hex (0,0);
    ///  - 'straight' hex-axis vertically down; and
    ///  - 'oblique'  hex-axis up-and-to-right (at 120 degrees from 'straight').
    private Matrix matrixX { 
      get { return new Matrix((3.0F/2.0F)/GridSize.Width,  (3.0F/2.0F)/GridSize.Width,
                                    1.0F/GridSize.Height,       -1.0F/GridSize.Height,  -0.5F,-0.5F); } 
    }
    private Matrix matrixY { 
      get { return new Matrix(       0.0F,                 (3.0F/2.0F)/GridSize.Width,
                                   2.0F/GridSize.Height,         1.0F/GridSize.Height,  -0.5F,-0.5F); } 
    }

    /// <summary>Canonical coordinates for a selected hex for a given AutoScroll position.</summary>
    /// <param name="point">Screen point specifying hex to be identified.</param>
    /// <param name="autoScroll">AutoScrollPosition for game-display Panel.</param>
    /// <returns>Canonical coordinates for a hex specified by a screen point.</returns>
    /// <see cref="HexGridAlgorithm.mht"/>
    protected ICoordsCanon GetHexCoords(Point point, Size autoScroll) {
      if( Host == null ) return Coords.EmptyCanon;

      autoScroll = TransposeSize(autoScroll);

      /// Adjust for origin not as assumed by GetCoordinate().
      var grid    = new Size((int)(GridSize.Width*2F/3F), (int)GridSize.Height);
      var margin  = new Size((int)(MapMargin.Width *MapScale), 
                             (int)(MapMargin.Height*MapScale));

      point      -= autoScroll + margin + grid;
      return Coords.NewCanonCoords( GetCoordinate(matrixX, point), 
                                    GetCoordinate(matrixY, point) );
    }

    Size TransposeSize(Size size) { return IsTransposed ? new Size (size.Height, size.Width)
                                                        : size; }

    /// <summary>Calculates a (canonical X or Y) grid-coordinate for a point, from the supplied 'picking' matrix.</summary>
    /// <param name="matrix">The 'picking' matrix</param>
    /// <param name="point">The screen point identifying the hex to be 'picked'.</param>
    /// <returns>A (canonical X or Y) grid coordinate of the 'picked' hex.</returns>
	  private static int GetCoordinate (Matrix matrix, Point point){
      var pts = new Point[]() {point};
      matrix.TransformPoints(pts);
		  return (int) Math.Floor( (pts[0](0)(0).X + pts[0](0)(0).Y + 2F) / 3F );
	  }
}}