namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        TeleportPoint teleport;
        CounterPoint counter;
        BounceArea bounce;

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
                    if (teleport == null)
                    {
                        teleport = new TeleportPoint();
                        emitter.impactPoints.Add(teleport);
                    }

                    teleport.X = e.X;
                    teleport.Y = e.Y;
                }
                else if (comboBox1.Text == "Точка-счётчик")
                {
                    if (counter == null)
                    {
                        counter = new CounterPoint();
                        emitter.impactPoints.Add(counter);
                    }

                    counter.X = e.X;
                    counter.Y = e.Y;
                }
                else if (comboBox1.Text == "Области отскока")
                {
                    if (bounce == null)
                    {
                        bounce = new BounceArea();
                        emitter.impactPoints.Add(bounce);
                    }

                    bounce.X = e.X;
                    bounce.Y = e.Y;
                }
                else if (comboBox1.Text == "Радар")
                {

                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                if (comboBox1.Text == "Телепорты")
                {
                    if (teleport == null)
                    {
                        teleport = new TeleportPoint();
                        emitter.impactPoints.Add(teleport);
                    }
                    teleport.ExitX = e.X;
                    teleport.ExitY = e.Y;
                }
                else if (comboBox1.Text == "Точка-счётчик")
                {
                    if (counter != null)
                    {
                        float dx = counter.X - e.X;
                        float dy = counter.Y - e.Y;
                        if (dx * dx + dy * dy <= counter.Radius * counter.Radius)
                        {
                            emitter.impactPoints.Remove(counter);
                            counter = null;
                        }
                    }
                }
                else if (comboBox1.Text == "Области отскока")
                {

                }
                else if (comboBox1.Text == "Радар")
                {

                }

            }
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta > 0 ? 5 : -5;
            bounce.Radius = Math.Clamp(bounce.Radius + delta, 10, 200);
        }
    }
}
