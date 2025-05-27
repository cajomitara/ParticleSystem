namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        TeleportPoint teleport = new TeleportPoint();
        CounterPoint counter = new CounterPoint();
        BounceArea bounce = new BounceArea();
        RadarArea radar = new RadarArea();
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.MouseWheel += picDisplay_MouseWheel;


            emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(emitter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var particle in emitter.particles.OfType<ParticleColorful>())
            {
                particle.FromColor = emitter.ColorFrom;
                particle.ToColor = emitter.ColorTo;
            }

            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbGraviton1_Scroll(object sender, EventArgs e)
        {

        }

        private void tbGravitation2_Scroll(object sender, EventArgs e)
        {

        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (comboBox1.Text == "Телепорты")
                {
                    if (!emitter.impactPoints.Contains(teleport))
                    {
                        emitter.impactPoints.Add(teleport);
                    }

                    teleport.X = e.X;
                    teleport.Y = e.Y;
                }
                else if (comboBox1.Text == "Точка-счётчик")
                {
                    if (!emitter.impactPoints.Contains(counter))
                    {
                        emitter.impactPoints.Add(counter);
                    }

                    counter.X = e.X;
                    counter.Y = e.Y;
                }
                else if (comboBox1.Text == "Области отскока")
                {
                    if (!emitter.impactPoints.Contains(bounce))
                    {
                        emitter.impactPoints.Add(bounce);
                    }

                    bounce.X = e.X;
                    bounce.Y = e.Y;
                }
                else if (comboBox1.Text == "Радар")
                {
                    if (!emitter.impactPoints.Contains(radar))
                    {
                        emitter.impactPoints.Add(radar);
                    }

                    radar.X = e.X;
                    radar.Y = e.Y;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (comboBox1.Text == "Телепорты")
                {
                    if (!emitter.impactPoints.Contains(teleport))
                    {
                        emitter.impactPoints.Add(teleport);
                    }
                    teleport.ExitX = e.X;
                    teleport.ExitY = e.Y;
                }
                else if (comboBox1.Text == "Точка-счётчик")
                {
                    if (!emitter.impactPoints.Contains(counter))
                    {
                        float dx = counter.X - e.X;
                        float dy = counter.Y - e.Y;
                        if (dx * dx + dy * dy <= counter.Radius * counter.Radius)
                        {
                            emitter.impactPoints.Remove(counter);
                        }
                    }
                }
                else if (comboBox1.Text == "Области отскока")
                {
                    if (!emitter.impactPoints.Contains(bounce))
                    {
                        float dx = bounce.X - e.X;
                        float dy = bounce.Y - e.Y;
                        if (dx * dx + dy * dy <= bounce.Radius * bounce.Radius)
                        {
                            emitter.impactPoints.Remove(bounce);
                        }
                    }
                }
                else if (comboBox1.Text == "Радар")
                {
                    if (!emitter.impactPoints.Contains(radar))
                    {
                        float dx = radar.X - e.X;
                        float dy = radar.Y - e.Y;
                        if (dx * dx + dy * dy <= radar.Radius * radar.Radius)
                        {
                            emitter.impactPoints.Remove(radar);
                        }
                    }
                }
            }
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta > 0 ? 5 : -5;
            bounce.Radius = Math.Clamp(bounce.Radius + delta, 10, 200);
        }

        private void tbTeleportSize_Scroll(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(teleport))
            {
                teleport.Radius = tbTeleportSize.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var obj in emitter.impactPoints.ToList())
            {
                emitter.impactPoints.Remove(obj);
            }
        }

        private void tbRadarSize_Scroll(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Radius = tbRadarSize.Value;
            }
        }

        private void pbRed_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.Red;
            }
        }

        private void pbGreen_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.Lime;
            }
        }

        private void pbBlue_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.SkyBlue;
            }
        }

        private void pbPink_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.DeepPink;
            }
        }

        private void pbGrey_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.DarkGray;
            }
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            if (emitter.impactPoints.Contains(radar))
            {
                radar.Color = Color.Orange;
            }
        }
    }
}
