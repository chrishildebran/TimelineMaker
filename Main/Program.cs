// ##########################################
// Solution: MakeFoldersSolution
// Project: TimelineMaker
// File: Program.cs
// 
// Last User: Chris Hildebran
// Last Edit: 2019-02-03 7:47 AM
// ##########################################

using System;
using System.Windows.Forms;

namespace Timeline
{
          internal static class Program
          {
                    #region Methods

                    /// <summary>
                    ///           The main entry point for the application.
                    /// </summary>
                    [STAThread]
                    private static void Main()
                    {
                              Application.EnableVisualStyles();
                              Application.SetCompatibleTextRenderingDefault(false);
                              Application.Run(new Form1());
                    }

                    #endregion
          }
}