using System;
using System.Collections.Generic;
using System.Drawing;
using LiveAndEnvironment;

namespace Bacterialus
{
    class Camera
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

        private Color GetRandomColor()
        {
            Random rand = new Random();
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);

            int baseColor = rand.Next(3);
            if (baseColor == 0)
            {
                r = 255;
            }
            else if (baseColor == 1)
            {
                g = 255;
            }
            else if (baseColor == 2)
            {
                b = 255;
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
                    frame.SetPixel(j, i, Color.Black);

                    if (Engine.Map[i + OffsetY, j + OffsetX].Unit != null)
                    {
                        Species species = Engine.Map[i + OffsetY, j + OffsetX].Unit.Species;

                        if (!SpeciesColors.ContainsKey(species))
                        {
                            SpeciesColors.Add(species, GetRandomColor());
                        }

                        frame.SetPixel(j, i, SpeciesColors[Engine.Map[i + OffsetY, j + OffsetX].Unit.Species]);
                    }
                    else if (Engine.Map[i + OffsetY, j + OffsetX].Environment != null)
                    {
                        EnvironmentType environmentType = Engine.Map[i + OffsetY, j + OffsetX].Environment.Type;

                        if (!EnvironmentColors.ContainsKey(environmentType))
                        {
                            EnvironmentColors.Add(environmentType, GetRandomColor());
                        }

                        frame.SetPixel(j, i, EnvironmentColors[Engine.Map[i + OffsetY, j + OffsetX].Environment.Type]);
                    }
                }
            }

            return frame;
        }
    }
}
