using ParticleSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = $"Я гравитон\nc силой {Power}";
            var font = new Font("Verdana", 10);

            var size = g.MeasureString(text, font);

            g.FillRectangle(
                new SolidBrush(Color.Red),
                X - size.Width / 2,
                Y - size.Height / 2,
                size.Width,
                size.Height
            );

            g.DrawString(
                text,
                font,
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat
            );
        }
    }
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class TeleportPoint : IImpactPoint
    {
        public float ExitX;
        public float ExitY;
        public int Radius = 50;
        public float DirectionAngle;

        public override void ImpactParticle(Particle particle)
        {
            float dx = X - particle.X;
            float dy = Y - particle.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance + particle.Radius < Radius)
            {
                particle.X = ExitX;
                particle.Y = ExitY;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.DeepSkyBlue), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.DrawEllipse(new Pen(Color.OrangeRed), ExitX - Radius, ExitY - Radius, Radius * 2, Radius * 2);

            g.DrawLine(new Pen(Color.Red), X, Y, ExitX, ExitY);
        }
    }

    public class CounterPoint : IImpactPoint
    {
        public int Count = 0;
        public int Radius = 30;
        private Color baseColor = Color.White;
        private Color targetColor = Color.Green;

        public override void ImpactParticle(Particle particle)
        {
            float dx = X - particle.X;
            float dy = Y - particle.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance <= Radius + particle.Radius)
            {
                particle.Life = 0;
                Count++;
            }
        }

        public override void Render(Graphics g)
        {
            float saturation = Math.Min(1.0f, Count / 5000.0f);
            Color color = InterpolateColor(baseColor, targetColor, saturation);

            g.FillEllipse(new SolidBrush(color), X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.DrawEllipse(new Pen(Color.Black, 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);

            var format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(
                Count.ToString(),
                new Font("Arial", 12, FontStyle.Bold),
                Brushes.White,
                new PointF(X, Y),
                format
            );
        }

        private Color InterpolateColor(Color start, Color end, float ratio)
        {
            int r = (int)(start.R * (1 - ratio) + end.R * ratio);
            int g = (int)(start.G * (1 - ratio) + end.G * ratio);
            int b = (int)(start.B * (1 - ratio) + end.B * ratio);

            return Color.FromArgb(
                Math.Clamp(r, 0, 255),
                Math.Clamp(g, 0, 255),
                Math.Clamp(b, 0, 255)
            );
        }
    }
    public class BounceArea : IImpactPoint
    {
        public int Radius = 50;

        public override void ImpactParticle(Particle particle)
        {
            float dx = X - particle.X;
            float dy = Y - particle.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance <= Radius + particle.Radius)
            {
                float nx = dx / distance;
                float ny = dy / distance;

                particle.X = X - nx * (Radius + particle.Radius);
                particle.Y = Y - ny * (Radius + particle.Radius);

                float dot = particle.SpeedX * nx + particle.SpeedY * ny;
                particle.SpeedX -= 2 * dot * nx;
                particle.SpeedY -= 2 * dot * ny;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.FromArgb(100, Color.Blue), 2), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}