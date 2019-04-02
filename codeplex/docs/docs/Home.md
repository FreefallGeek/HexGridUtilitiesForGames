# Hex-Grid Utilities

## Hex Grid Utilities for Board-Game Development in C#

**A tool-kit of utilities for building board- and strategy-games on a hexagonal grid, providing these features:**

* Lightning-fast **ALT Bidirectional Path-Finding** implementation;
* Fast **Shadowcasting** implementation provides 3D Field-of-View;
* **Hex-picking** (identifying the hex selected by the user);
* All internal calculations performed with integer canonical (obtuse) coordinates;
* All external interfaces and board storage use rectangular coordinates;
* Built-in support for non-standard & transformed coordinate systems (such as for multi-map boards);
* Automatic internal conversion between coordinate systems hidden in a single type **HexCoords**;
* **WinForms** Panel sub-class exposing all of the above plus:
	* Mouse-wheel zoom and scroll; and
	* Map transposition
* As of ChangeSet 30020, optionally supports automatic visibility limiting due to Earth's curvature.
* Example of visibility limited by Earth's curvature: [FOV with Curved Earth w/ 400 yd hexes & 30 ft contours](FOV-with-Curved-Earth-w_-400-yd-hexes-&-30-ft-contours)

* **MazeMap:**   ![](Home_MazeMapPathFInding.PNG)
* **TerrainMap:**   ![](Home_TerrainMapFOV.PNG)

Got questions? Please leave a [comment](http://hexgridutilities.codeplex.com/documentation) (or start a [discussion](http://hexgridutilities.codeplex.com/discussions) thread) and I will get back to you as quickly as I can.

## Reviews and Ratings
If you downloaded this library and found it useful (and even if you didn't actually; I can take brickbats as well as bouquets), please select **Review This Release** on the Downloads page. You will be presented with a dialog box where you can review and rate the release. Specific issues can also be reported on the **Issues** tab.

I appreciate all feedback, and promise to read all comments and issues. 
----
Many thanks to:
* Eric Lippert for providing the original (rectangular) [A* Path-Finding](http://blogs.msdn.com/b/ericlippert/archive/tags/astar/) and [Shadowcasting](http://blogs.msdn.com/b/ericlippert/archive/tags/shadowcasting/) implementations;
* Wim Pijls & Henk Post for **_[Yet Another Bidirectional Algorithm for Shortest Paths](http://repub.eur.nl/res/pub/16100/ei2009-10.pdf)_**;
* Luis Henrique Oliveira Rios & Luiz Chaimowicz for **_[PNBA{"**"} - A Parallel Bidirectional Heuristic Search Algorithm](http://homepages.dcc.ufmg.br/~chaimo/public/ENIA11.pdf|)_**; and
* Andrew V. Goldberg & Renato F. Werneck for **_[Computing Point-to-Point Shortest Paths from External Memory](http://www.cs.princeton.edu/courses/archive/spr06/cos423/Handouts/GW05.pdf)_**, (the explanation of **ALT** that finally stuck.)
