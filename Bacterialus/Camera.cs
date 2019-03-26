using System;
using System.Collections.Generic;
using System.Drawing;
using LiveAndEnvironment;

namespace Bacterialus
{
    public class Camera
    {
        const int RESOLUTION_MIN = 10;
        const int RESOLUTION_MAX = 512;

        public GameEngine Engine { get; private set; }
        public Dictionary<EnvironmentType, Color> EnvironmentColors { get; private set; }
        public Dictionary<Species, Color> SpeciesColors { get; private set; }

        private int _offsetX;
        public int OffsetX
        {
            get
            {
                return _offsetX;
            }
            private set
            {
                _offsetX = Math.Max(-Resolution, value);
                _offsetX = Math.Min(Engine.Map.GetLength(1), _offsetX);
            }
        }

        private int _offsetY;
        public int OffsetY
        {
            get
            {
                return _offsetY;
            }
            private set
            {
                _offsetY = Math.Max(-Resolution, value);
                _offsetY = Math.Min(Engine.Map.GetLength(0), _offsetY);
            }
        }

        private int _resolution;
        public int Resolution
        {
            get
            {
                return _resolution;
            }
            set
            {
                _resolution = Math.Max(RESOLUTION_MIN, value);
                _resolution = Math.Min(RESOLUTION_MAX, _resolution);

                OffsetX = OffsetX;
                OffsetY = OffsetY;
            }
        }

        const int COLOR_CHANGE_MIN = -70;
        const int COLOR_CHANGE_MAX = 70;
        const int MIN_COLOR_DIFFERENT = 120;
        const int BASE_COLOR_MIN = 180;

        public Camera(GameEngine engine)
        {
            Engine = engine;

            Resolution = engine.Map.GetLength(0);

            OffsetX = 0;
            OffsetY = 0;

            EnvironmentColors = new Dictionary<EnvironmentType, Color>();
            SpeciesColors = new Dictionary<Species, Color>();
        }

        public void Move(int x, int y)
        {
            OffsetX = x;
            OffsetY = y;
        }

        public void MoveOffset(int dx, int dy)
        {
            OffsetX = OffsetX + dx;
            OffsetY = OffsetY + dy;
        }

        private Color GetRandomBrightColor()
        {
            Random rand = new Random();
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);

            if (r >= g && r >= b)
            {
                r = Math.Max(r, BASE_COLOR_MIN);
            }
            else if (g >= r && g >= b)
            {
                g = Math.Max(g, BASE_COLOR_MIN);
            }
            else if (b >= r && b >= g)
            {
                b = Math.Max(b, BASE_COLOR_MIN);
            }

            return Color.FromArgb(r, g, b);
        }

        public Color GetDescendantColor(Color parentColor)
        {
            int colorDifferent = 0;
            Random rand = new Random();
            int r = 0;
            int g = 0;
            int b = 0;
            while (colorDifferent < MIN_COLOR_DIFFERENT)
            {
                r = Math.Max(parentColor.R + rand.Next(COLOR_CHANGE_MIN, COLOR_CHANGE_MAX + 1), 0);
                r = Math.Min(r, 255);
                g = Math.Max(parentColor.G + rand.Next(COLOR_CHANGE_MIN, COLOR_CHANGE_MAX + 1), 0);
                g = Math.Min(g, 255);
                b = Math.Max(parentColor.B + rand.Next(COLOR_CHANGE_MIN, COLOR_CHANGE_MAX + 1), 0);
                b = Math.Min(b, 255);

                if (r >= g && r >= b)
                {
                    r = Math.Max(r, BASE_COLOR_MIN);
                }
                else if (g >= r && g >= b)
                {
                    g = Math.Max(g, BASE_COLOR_MIN);
                }
                else if (b >= r && b >= g)
                {
                    b = Math.Max(b, BASE_COLOR_MIN);
                }

                colorDifferent = Math.Abs(parentColor.R - r) + Math.Abs(parentColor.G - g) + Math.Abs(parentColor.B - b);
            }
            
            return Color.FromArgb(r, g, b);
        }

        public Bitmap GetFrame()
        {
            Bitmap frame = new Bitmap(Resolution, Resolution);

            for (int i = 0; i < Resolution && i + OffsetY < Engine.Map.GetLength(0); i++)
            {
                for (int j = 0; j < Resolution && j + OffsetX < Engine.Map.GetLength(1); j++)
                {
                    if (i + OffsetY >= 0 && i + OffsetY < Engine.Map.GetLength(0) &&
                        j + OffsetX >= 0 && j + OffsetX < Engine.Map.GetLength(1))
                    {
                        frame.SetPixel(j, i, Color.Black);
                        if (Engine.Map[i + OffsetY, j + OffsetX].Unit != null)
                        {
                            Species species = Engine.Map[i + OffsetY, j + OffsetX].Unit.Species;

                            if (!SpeciesColors.ContainsKey(species))
                            {
                                if (species.Parent != null)
                                {
                                    if (SpeciesColors.ContainsKey(species.Parent))
                                    {
                                        SpeciesColors.Add(species, GetDescendantColor(SpeciesColors[species.Parent]));
                                    }
                                    else
                                    {
                                        SpeciesColors.Add(species, GetRandomBrightColor());
                                    }
                                }
                                else
                                {
                                    SpeciesColors.Add(species, GetRandomBrightColor());
                                }
                            }

                            frame.SetPixel(j, i, SpeciesColors[Engine.Map[i + OffsetY, j + OffsetX].Unit.Species]);
                        }
                        else if (Engine.Map[i + OffsetY, j + OffsetX].Environment != null)
                        {
                            EnvironmentType environmentType = Engine.Map[i + OffsetY, j + OffsetX].Environment.Type;

                            if (!EnvironmentColors.ContainsKey(environmentType))
                            {
                                EnvironmentColors.Add(environmentType, GetRandomBrightColor());
                            }

                            frame.SetPixel(j, i, EnvironmentColors[Engine.Map[i + OffsetY, j + OffsetX].Environment.Type]);
                        }
                    }
                }
            }

            return frame;
        }
    }
}
