using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Timeline
{
          public partial class Form1 : Form
          {
                    #region Fields

                    private string _decade;

                    private string _rootPath;

                    private string _suffix;

                    private string _yearEnd;

                    private string _yearStart;

                    #endregion

                    #region Constructors

                    public Form1()
                    {
                              InitializeComponent();
                    }

                    #endregion

                    #region Methods

                    private void BtnRootFolderSelect(object sender, EventArgs e)
                    {
                              folderBrowserDialog1.ShowDialog();

                              txtRootDirectory.Text = folderBrowserDialog1.SelectedPath;

                              _rootPath = txtRootDirectory.Text;
                    }


                    private void button2_Click(object sender, EventArgs e)

                    {
                              var countNew      = 0;
                              var countExisting = 0;

                              _suffix = "_"                    + txtWho.Text + "_" + cmbEventType.Text + "_" +
                                        txtWhereEventCity.Text +
                                        " "                    + txtWhereEventState.Text + "_TLM";

                              var stopwatch = new Stopwatch();

                              if (cmbIntervalUnit.SelectedItem.ToString() == "Day(s)")
                              {
                                        stopwatch.Start();

                                        for (var x = dtpStartDate.Value; x <= dtpEndDate.Value; x = x.AddDays(1))
                                        {
                                                  _decade = x.Year.ToString().Substring(0, 3) + "0S";


                                                  var directoryPath =
                                                            _rootPath              + "\\"   + _decade +
                                                            "\\"                   + x.Year + "\\"    +
                                                            x.Year                 +
                                                            x.Month.ToString("D2") + x.Day.ToString("D2") + "_" +
                                                            x.DayOfWeek            + "_TLM";

                                                  if (!Directory.Exists(directoryPath))
                                                  {
                                                            Directory.CreateDirectory(directoryPath);

                                                            countNew += 1;
                                                  }
                                                  else
                                                  {
                                                            countExisting += 1;
                                                  }
                                        }

                                        stopwatch.Stop();
                              }


                              var et = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).TotalSeconds;


                              Directory.CreateDirectory(_rootPath + "\\TLM\\New_"      + countNew);
                              Directory.CreateDirectory(_rootPath + "\\TLM\\Existing_" + countExisting);
                    }


                    private void dtpEndDate_ValueChanged(object sender, EventArgs e)
                    {
                              _yearEnd = dtpEndDate.Value.Year.ToString();
                    }


                    private void dtpStartDate_ValueChanged(object sender, EventArgs e)
                    {
                              _yearStart = dtpStartDate.Value.Year.ToString();

                              _decade = dtpStartDate.Value.Year.ToString().Substring(0, 3) + "0s";
                    }


                    private void Form1_Load(object sender, EventArgs e)
                    {
                    }


                    private void Form1_Load_1(object sender, EventArgs e)
                    {
                              dtpEndDate.Value = DateTime.Now;

                              folderBrowserDialog1.SelectedPath = @"C:\Temp";
                    }


                    private void Form1_MouseMove(object sender, MouseEventArgs e)
                    {
                    }


                    private void tbRootDirectory_TextChanged(object sender, EventArgs e)
                    {
                              folderBrowserDialog1.SelectedPath = txtRootDirectory.Text;
                    }

                    #endregion
          }
}