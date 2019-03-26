using LiveAndEnvironment;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bacterialus
{
    public partial class SpeciesForm : Form
    {
        private Species _species;
        private Camera _camera;

        const int BITMAP_RESOLUTION = 50;

        public SpeciesForm(Species species, Camera camera)
        {
            InitializeComponent();

            _species = species;
            _camera = camera;

            nameTextBox.Text = _species.Name;
            ShowColorOnDisplay(colorDisplayBox, _camera.SpeciesColors[_species]);
            foodTypeLabel.Text = _species.FoodType.Name;

            if (_species.Parent != null)
            {
                ShowColorOnDisplay(parentColorDisplayBox, _camera.SpeciesColors[_species.Parent]);
                parentNameLabel.Text = _species.Parent.Name;
                toParentButton.Enabled = true;
            }

            populationLabel.Text = _species.Population.ToString();

            speedLabel.Text = _species.Speed.ToString();
            eatSpeedLabel.Text = _species.EatSpeed.ToString();
            defenseLabel.Text = _species.Defense.ToString();
            growSpeedLabel.Text = _species.GrowSpeed.ToString();

            reproductionSpeedLabel.Text = _species.ReproductionSpeed.ToString();
            reproductionMassLabel.Text = _species.ReproductionMass.ToString();

            sensorRaduisLabel.Text = _species.SensorRadius.ToString();

            foreach (var item in _species.FoodList)
            {
                foodListBox.Items.Add(item);
            }
        }

        private void ShowColorOnDisplay(DisplayBox displayBox, Color color)
        {
            Bitmap colorBitmap = new Bitmap(BITMAP_RESOLUTION, BITMAP_RESOLUTION);
            for (int i = 0; i < BITMAP_RESOLUTION; i++)
            {
                for (int j = 0; j < BITMAP_RESOLUTION; j++)
                {
                    colorBitmap.SetPixel(i, j, color);
                }
            }
            displayBox.Image = colorBitmap;
        }

        private void toParentButton_Click(object sender, EventArgs e)
        {
            SpeciesForm speciesForm = new SpeciesForm(_species.Parent, _camera);
            speciesForm.Show();
        }
    }
}
