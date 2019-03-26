using LiveAndEnvironment;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Bacterialus
{
    public partial class MainForm : Form
    {
        const double ADD_RESOLUTION_COEFFICIENT = 1.2;
        const double ADD_FRAME_INTERVAL_COEFFICIENT = 1.2;

        const int MIN_FRAME_INTERVAL = 10;
        const int MAX_FRAME_INTERVAL = 200;

        private bool fullScreen;

        private GameEngine _engine;

        private Camera _camera;

        private int _framesProSec;
        private int _frameInterval;
        
        Species _lox;

        private int _saveCounter;
        private int _saveTicks;

        public MainForm()
        {
            InitializeComponent();
            fullScreen = false;

            _engine = new GameEngine(100, 100);
            _camera = new Camera(_engine);

            _framesProSec = 0;
            _frameInterval = 17;

            new FoodType("A0");

            _lox = new Species("LOX", FoodType.AllFoodTypes[0]);
            _lox.GrowSpeed = 0.003;
            _lox.EatSpeed = 0.15;
            _lox.ReproductionMass = 1;
            _lox.ReproductionSpeed = 1.1;
            _lox.Speed = 1;
            _lox.SensorRadius = 3;

            _saveCounter = 0;
            _saveTicks = 1;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            cameraDisplayBox.Width = this.Width - 209;
            cameraDisplayBox.Height = this.Height - 90;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Graphics graphics = cameraDisplayBox.CreateGraphics();
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

            resolutionToolStripStatusLabel.Text = _camera.Resolution.ToString();
        }

        private void DrawFrame()
        {
            _framesProSec++;
            Bitmap frame = _camera.GetFrame();
            cameraDisplayBox.Image = frame;

            _saveTicks++;
            if (_saveTicks % 100 == 0)
            {
                _saveTicks = 1;
                frame.Save("papka/frame" + _saveCounter + ".png", ImageFormat.Png);
                _saveCounter++;
            }
        }

        private void startPauseButton_Click(object sender, EventArgs e)
        {
            if (simulationTagTimer.Enabled)
            {
                simulationTagTimer.Stop();
            }
            else
            {
                simulationTagTimer.Start();
            }
        }

        private void SetInterfaceVisible(bool value)
        {
            menuStrip1.Visible = value;
            statusStrip1.Visible = value;

            startPauseButton.Visible = value;
            turnButton.Visible = value;
            restartButton.Visible = value;

            zoomInbutton.Visible = value;
            zoomOutbutton.Visible = value;

            slowestButton.Visible = value;
            fastestButton.Visible = value;

            minimapDisplayBox.Visible = value;
        }

        private void SetFullScreenMode(bool value)
        {
            if (value)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                SetInterfaceVisible(false);
                cameraDisplayBox.Location = new Point(0, 0);
                cameraDisplayBox.Size = new Size(this.Width + 10, this.Height + 5);
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                SetInterfaceVisible(true);
                cameraDisplayBox.Location = new Point(13, 28);
                this.WindowState = FormWindowState.Normal;
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
            simulationTagTimer.Start();
        }

        private void SetResolution(int value)
        {
            _camera.Resolution = value;

            resolutionToolStripStatusLabel.Text = _camera.Resolution.ToString();

            DrawFrame();
        }

        private void AddResolution()
        {
            SetResolution((int)(_camera.Resolution * ADD_RESOLUTION_COEFFICIENT));
        }

        private void SubstractResolution()
        {
            SetResolution((int)(_camera.Resolution / ADD_RESOLUTION_COEFFICIENT));
        }

        private void ZoomInbutton_Click(object sender, EventArgs e)
        {
            SubstractResolution();
        }

        private void ZoomOutbutton_Click(object sender, EventArgs e)
        {
            AddResolution();
        }

        private void fpsTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusFPSLabel.Text = _framesProSec.ToString();
            _framesProSec = 0;
        }

        private void SetFrameInterval(int value)
        {
            _frameInterval = Math.Max(MIN_FRAME_INTERVAL, value);
            _frameInterval = Math.Min(MAX_FRAME_INTERVAL, _frameInterval);

            simulationTagTimer.Interval = _frameInterval;
        }

        private void AddFrameInterval()
        {
            SetFrameInterval((int)(_frameInterval * ADD_FRAME_INTERVAL_COEFFICIENT));
        }

        private void SubstractFrameInterval()
        {
            SetFrameInterval((int)(_frameInterval / ADD_FRAME_INTERVAL_COEFFICIENT));
        }

        private void slowestButton_Click(object sender, EventArgs e)
        {
            AddFrameInterval();
        }

        private void fastestButton_Click(object sender, EventArgs e)
        {
            SubstractFrameInterval();
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
            else if (e.KeyCode == Keys.Space)
            {
                if (simulationTagTimer.Enabled)
                {
                    simulationTagTimer.Stop();
                }
                else
                {
                    simulationTagTimer.Start();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ToNormalState();
            }

            if (e.Control)
            {
                if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                {
                    SubstractResolution();
                }

                if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                {
                    AddResolution();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                {
                    SubstractFrameInterval();
                }

                if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                {
                    AddFrameInterval();
                }
            }

            
        }

        private Point GetImageCoords(int width, int height, int resolution,  int mouseX, int mouseY)
        {
            double onePixelWidth = Convert.ToDouble(width) / resolution;
            double onePixelHeight = Convert.ToDouble(height) / resolution;
            int imageX = (int)((Convert.ToDouble(mouseX) + onePixelWidth / 2) / onePixelWidth);
            int imageY = (int)((Convert.ToDouble(mouseY) + onePixelHeight / 2) / onePixelHeight);

            return new Point(imageX, imageY);
        }

        private void displayBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = GetImageCoords(cameraDisplayBox.Width, cameraDisplayBox.Height, 
                _camera.Resolution, e.X, e.Y);

            if (e.Button == MouseButtons.Left)
            {
                Unit unit = new Unit(_lox, _engine.Map[_camera.OffsetY + point.Y, _camera.OffsetX + point.X]);
                _engine.AddUnit(unit);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (_engine.Map[_camera.OffsetY + point.Y, _camera.OffsetX + point.X].Unit != null)
                {
                    Species species = _engine.Map[_camera.OffsetY + point.Y, _camera.OffsetX + point.X].Unit.Species;

                    SpeciesForm speciesForm = new SpeciesForm(species, _camera);
                    speciesForm.Show();
                }
            }

            DrawFrame();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            _engine = new GameEngine(100, 100);
            _camera = new Camera(_engine);
        }

        private void simulationTagTimer_Tick(object sender, EventArgs e)
        {
            _engine.Turn();
            DrawFrame();
            
        }

        private void cameraDisplayBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = GetImageCoords(cameraDisplayBox.Width, cameraDisplayBox.Height,
                _camera.Resolution, e.X, e.Y);

            coordsToolStripStatusLabel.Text = point.ToString();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            _engine.Turn();
            DrawFrame();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _camera.MoveOffset(-_camera.Resolution / 5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                _camera.MoveOffset(_camera.Resolution / 5, 0);
            }
            else if (e.KeyCode == Keys.Up)
            {
                _camera.MoveOffset(0, -_camera.Resolution / 5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                _camera.MoveOffset(0, _camera.Resolution / 5);
            }

            DrawFrame();
        }

        private void ToNormalState()
        {
            SetFullScreenMode(false);

            this.Width = 509;
            this.Height = 334;

            _camera.Resolution = _engine.Map.GetLength(0);
            _camera.Move(0, 0);

            DrawFrame();
        }

        private void toNormalStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToNormalState();
        }
    }
}
