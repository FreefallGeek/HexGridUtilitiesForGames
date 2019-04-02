With our easy coordinate transformation to- and from-Canonical coordinates, this becomes dead simple:

From **Coords.cs**:
{{
    private int Range(ICoordsCanon coords) {
      var deltaX = coords.X - VectorCanon.X;
      var deltaY = coords.Y - VectorCanon.Y;
      return (Math.Abs(deltaX) + Math.Abs(deltaY) + Math.Abs(deltaX-deltaY)) / 2;
    }
}}
Invoking this method is as simple as this code fragement from **hexgridPanel_MouseMove**:
{{
void hexgridPanel_MouseMove(object sender, MouseEventArgs e) {
  HotSpotHex = hexgridPanel.GetHexCoords(e.Location).User;
  Range      = CurrentHex.Range(HotSpotHex);
  // etc.
}
}}
This internal method is aliased, with the same name and signature, in all three of the Coordinate interfaces: **ICoordsCanon**, **ICoordsUser**, and **ICoordsCustom**.

The proof of this formula (in _Canonical_ coordinates) is readiy available all over the web; I will not repeat it here. Note that this variant of the formual is for X- and Y-axes at 120 degrees; the formula varies slightly if they are chosen at 60 degrees instead.