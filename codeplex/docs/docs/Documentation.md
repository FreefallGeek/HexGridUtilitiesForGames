## Using the WinForms Example:
* Left-click to select a Start hex (outlined in red).
* Ctrl-Left-click to select a Goal hex and show best path from start to this Goal.
* Move the mouse to show Field-of-View from this location.
* Select the desired map from the cmbo-box on the toolbar.
* Hover over a hex to display in the status bar:
	* Current User (rectangular from upper left) coordinates;
	* Current Custom (rectangular from lower left) coordinates ;
	* Range _as-the-crow-flies_ of the hover hex from the current hex; and
	* Length of the last requested best path.
* Anchor the Field-of-View by toggling Range-Line on, and verify the sight lines.
* Select a landmark to verify hex distances and the heuristic function.
* Toggle direction arrows for the current shortest path.
* Transpose the map to horizontal hex-grain, and back again, with the push of a button.
* **WinForms**** users: Check out how the example sub-classes **MapDisplay<THex>** and **HexgridPanel** in implementing all this functionality in minimal code.
## Notes on Key Algorithms:

* [Coordinate Transformations Between Canonical, User, and Custom](Coordinate-Transformations-Between-Canonical,-User,-and-Custom) (updated 2013-08-04)
* [Coordinate Systems - ICoordsUser](Coordinate-Systems---ICoordsUser)
* [Hex-Picking (Identifying a Hex from Mouse Coordinates)](Hex-Picking-(Identifying-a-Hex-from-Mouse-Coordinates)) (current 2013-08-04)
* [Range Finding](Range-Finding) (current, 2013-08-04)
* [Path Finding](Path-Finding)
* [Defining a Custom Coordinate System](Defining-a-Custom-Coordinate-System)
* [What if my Hex-Grain is Horizontal?](What-if-my-Hex-Grain-is-Horizontal_) 
* [Getting a Field-of-View](Getting-a-Field-of-View) (updated 2013-08-04)

**Detailed code documentation built with [Doxygen](http://www.stack.nl/~dimitri/doxygen/index.html) and the [dot tool from graphviz](http://www.graphviz.org/) is available as a [Download](https://hexgridutilities.codeplex.com/releases/view/110315)**  
(approaching 50% complete as of 2013-08-05).