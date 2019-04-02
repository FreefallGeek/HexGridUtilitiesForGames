﻿#region The MIT License - Copyright (C) 2012-2014 Pieter Geerkens
/////////////////////////////////////////////////////////////////////////////////////////
//                PG Software Solutions Inc. - Hex-Grid Utilities
/////////////////////////////////////////////////////////////////////////////////////////
// The MIT License:
// ----------------
// 
// Copyright (c) 2012-2013 Pieter Geerkens (email: pgeerkens@hotmail.com)
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
using System;
using System.Threading;
using System.Windows.Forms;

using PGNapoleonics.WinForms;

#pragma warning disable 1587
/// <summary>Example usage of <see cref="HexUtilities"/> with <see cref="HexUtilities.HexgridPanel"/> 
/// in a simple <see cref="WinForms"/> application.</summary>
#pragma warning restore 1587
[assembly:CLSCompliant(true)]
namespace PGNapoleonics.HexgridScrollableExample {
  static class Program {
    volatile static int i = 0;

    /// <summary>The main entry point for the application.</summary>
    [STAThread]
    static void Main()      {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += 
        new ThreadExceptionEventHandler(
          (new ThreadExceptionHandler()).ApplicationThreadException);
      switch (i) {
        default:
        case 0:  Application.Run(new MdiParent()); break;
        case 1:  Application.Run(new ExampleHexgridPanelExample()); break;
        case 2:  Application.Run(new ExampleHexgridScrollable()); break;
        case 3:  Application.Run(new ExampleBufferedHexgridScrollable()); break;
      }
    }
  }
}
