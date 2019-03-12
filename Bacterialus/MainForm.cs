using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacterialus
{
    public partial class MainForm : Form
    {
        int _mode = 0;

        private bool fullScreen;

        private Random _rand;

        private int _resolution;
        private Bitmap _canvas;
        private Bitmap _userDrawing;
        private Color _color1;
        private Color _color2;

        private int framesProSec;

        private int _frameInterval;

        public MainForm(int mode)
        {
            _mode = mode;

            InitializeComponent();

            if (mode == 0)
            {
                fullScreen = false;

                _rand = new Random();

                _resolution = 100;

                _canvas = new Bitmap(_resolution, _resolution);
                _userDrawing = new Bitmap(_resolution, _resolution);
                _color1 = Color.Blue;
                _color2 = Color.Aqua;

                framesProSec = 0;

                _frameInterval = 17;
            }
            else
            {
                _rand = new Random();

                _resolution = 100;

                _canvas = new Bitmap(_resolution, _resolution);
                _userDrawing = new Bitmap(_resolution, _resolution);
                Graphics graphics = Graphics.FromImage(_userDrawing);
                graphics.DrawImage(Image.FromFile("lox100x100.png"), 0, 0);
                displayBox1.Image = _canvas;
                _color1 = Color.Black;
                _color2 = Color.SeaGreen;

                framesProSec = 0;

                _frameInterval = 17;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            displayBox1.Width = this.Width - 114;
            displayBox1.Height = this.Height - 90;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Graphics graphics = displayBox1.CreateGraphics();
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

            if (_mode == 1)
            {
                humTimer.Start();
                SetFullScreenMode(true);
            }
        }

        private void GenerateHum()
        {
            int chance = _rand.Next(100);
            Graphics canvasGraphics = Graphics.FromImage(_canvas);
            //Console.Beep(37 + chance * 10, _frameInterval);
            for (int i = 0; i < _resolution; i++)
            {
                for (int j = 0; j < _resolution; j++)
                {
                    if (_rand.Next(100) <= chance)
                    {
                        _canvas.SetPixel(j, i, _color1);
                    }
                    else
                    {
                        _canvas.SetPixel(j, i, _color2);
                    }
                }
            }
            canvasGraphics.DrawImage(_userDrawing, 0, 0);
            framesProSec++;
            displayBox1.Image = _canvas;
        }

        private void humTimer_Tick(object sender, EventArgs e)
        {
            GenerateHum();
        }

        private void startPauseButton_Click(object sender, EventArgs e)
        {
            if (humTimer.Enabled)
            {
                humTimer.Stop();
            }
            else
            {
                humTimer.Start();
            }
        }

        private void SetInterfaceVisible(bool value)
        {
            menuStrip1.Visible = value;
            statusStrip1.Visible = value;
            startPauseButton.Visible = value;
            zoomInbutton.Visible = value;
            zoomOutbutton.Visible = value;
            slowestButton.Visible = value;
            fastestButton.Visible = value;
            colorOneButton.Visible = value;
            colorTwoButton.Visible = value;
        }

        private void SetFullScreenMode(bool value)
        {
            if (value)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                SetInterfaceVisible(false);
                this.TopMost = true;
                displayBox1.Location = new Point(0, 0);
                displayBox1.Size = new Size(this.Width + 10, this.Height + 5);
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                SetInterfaceVisible(true);
                displayBox1.Location = new Point(13, 28);
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
            }

            fullScreen = value;
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullScreen)
            {
                SetFullScreenMode(false);
            }
            else
            {
                SetFullScreenMode(true);
            }

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            humTimer.Start();
        }

        private void SetResolution(int value)
        {
            _resolution = value;
            _resolution = Math.Max(1, _resolution);
            _resolution = Math.Min(512, _resolution);
            _canvas = new Bitmap(_resolution, _resolution);
            Bitmap oldDrawing = new Bitmap(_userDrawing);
            _userDrawing = new Bitmap(_resolution, _resolution);
            Graphics graphics = Graphics.FromImage(_userDrawing);
            graphics.DrawImage(oldDrawing, 0, 0);

            GenerateHum();
        }

        private void ZoomInbutton_Click(object sender, EventArgs e)
        {
            SetResolution(_resolution / 2);
        }

        private void ZoomOutbutton_Click(object sender, EventArgs e)
        {
            SetResolution(_resolution * 2);
        }

        private void fpsTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusFPSLabel.Text = framesProSec.ToString();
            framesProSec = 0;
        }

        private void SetInterval(int value)
        {
            _frameInterval = value;
            _frameInterval = Math.Max(10, _frameInterval);
            _frameInterval = Math.Min(200, _frameInterval);
            humTimer.Interval = _frameInterval;
        }

        private void slowestButton_Click(object sender, EventArgs e)
        {
            SetInterval(_frameInterval * 2);
        }

        private void fastestButton_Click(object sender, EventArgs e)
        {
            SetInterval(_frameInterval / 2);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (e.KeyCode == Keys.Enter && e.Alt)
            {
                if (fullScreen)
                {
                    SetFullScreenMode(false);
                }
                else
                {
                    SetFullScreenMode(true);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (humTimer.Enabled)
                {
                    humTimer.Stop();
                }
                else
                {
                    humTimer.Start();
                }
            }

            if (e.Control)
            {
                if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                {
                    SetResolution(_resolution / 2);
                }

                if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                {
                    SetResolution(_resolution * 2);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                {
                    SetInterval(_frameInterval / 2);
                }

                if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                {
                    SetInterval(_frameInterval * 2);
                }
            }

            if (e.KeyCode == Keys.D1)
            {
                colorDialog1.ShowDialog();
                _color1 = colorDialog1.Color;
                colorOneButton.ForeColor = _color1;
            }

            if (e.KeyCode == Keys.D2)
            {
                colorDialog1.ShowDialog();
                _color2 = colorDialog1.Color;
                colorTwoButton.ForeColor = _color2;
            }
        }

        private void colorOneButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            _color1 = colorDialog1.Color;
            colorOneButton.ForeColor = _color1;
        }

        private void colorTwoButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            _color2 = colorDialog1.Color;
            colorTwoButton.ForeColor = _color2;
        }

        private void displayBox1_MouseClick(object sender, MouseEventArgs e)
        {
            double onePixelWidth = Convert.ToDouble(displayBox1.Width) / _resolution;
            double onePixelHeight = Convert.ToDouble(displayBox1.Height) / _resolution;
            int imageX = (int)((Convert.ToDouble(e.X) + onePixelWidth / 2) / onePixelWidth);
            int imageY = (int)((Convert.ToDouble(e.Y) + onePixelHeight / 2) / onePixelHeight);

            _userDrawing.SetPixel(imageX, imageY, Color.Black);

            GenerateHum();
        }

        private void showLoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(_userDrawing);
            graphics.DrawImage(Image.FromFile("lox100x100.png"), 0, 0);

        }
    }
}
