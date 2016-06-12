using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiveTracker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private DiveSequence dive;

		private void Form1_Load(object sender, EventArgs e)
		{
			wmp.settings.mute = true;
			wmp.PlayStateChange += Wmp_PlayStateChange;
			wmp.PositionChange += wmp_PositionChange;
			wmp.settings.setMode("showFrame", true);
			wmp.URL = @"C:\Users\andyp\Google Drive\Microclim8\2016-05-Alvor\1_B-C-6-H.MTS";
		}

		private void Wmp_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
		{
			var pos = wmp.Ctlcontrols.currentPosition;
			switch (e.newState)
			{
				case 0:    // Undefined
					break;

				case 1:    // Stopped
					textBox1.Text = pos.ToString();
					break;

				case 2:    // Paused
					textBox1.Text = pos.ToString();
					break;

				case 3:    // Playing
					textBox1.Text = pos.ToString();
					break;

				case 4:    // ScanForward
					break;

				case 5:    // ScanReverse
					break;

				case 6:    // Buffering
					break;

				case 7:    // Waiting
					break;

				case 8:    // MediaEnded
					break;

				case 9:    // Transitioning
					break;

				case 10:   // Ready
					break;

				case 11:   // Reconnecting
					break;

				case 12:   // Last
					break;

				default:
					break;
			}
		}

		private void wmp_PositionChange(object sender, _WMPOCXEvents_PositionChangeEvent e)
		{
			textBox1.Text = e.newPosition.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var pos = wmp.Ctlcontrols.currentPosition;
			textBox1.Text = pos.ToString();
			lbPoints.Items.Add(pos);
		}

		private void listBox1_Click(object sender, EventArgs e)
		{
			var pos = (double)lbPoints.SelectedItem;
			wmp.Ctlcontrols.currentPosition = pos - 2.0;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;
			wmp.Ctlcontrols.currentPosition = double.Parse(textBox1.Text);
		}

		private void txtSequence_Leave(object sender, EventArgs e)
		{
			dive = new DiveSequence(txtSequence.Text);
			lbPoints.Items.Clear();
		}

		private void txtSequence_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;
			dive = new DiveSequence(txtSequence.Text);
			lbPoints.Items.Clear();
		}
	}
}