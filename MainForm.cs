/*
 * Created by SharpDevelop.
 * User: David Ledford
 Date: 11/11/2012
 * Time: 9:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuickFixer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string myFileChoice = openFileDialog1.FileName;
			textBox1.Text = myFileChoice;	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				System.IO.StreamReader myFile =
					new System.IO.StreamReader(textBox1.Text);
				string myFileContents = myFile.ReadToEnd();
				myFile.Close();
			
				richTextBox1.Text = myFileContents.Replace(textBox2.Text, textBox3.Text);
				
				System.IO.StreamWriter myFileEdited =
					new System.IO.StreamWriter(textBox1.Text);
				myFileEdited.Write(richTextBox1.Text);
				myFileEdited.Close();
			}

		}
	}
}
