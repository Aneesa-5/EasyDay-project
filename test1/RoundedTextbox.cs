using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace test1
{
    public class RoundedTextBox : UserControl
    {
        private TextBox textBox = new TextBox();

        public RoundedTextBox()
        {
            DoubleBuffered = true;
            Size = new Size(200, 30);

            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(10, 7);
            textBox.Width = Width - 20;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.BackColor = BackColor;

            Controls.Add(textBox);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            textBox.Width = Width - 20;
            textBox.Height = Height - 14;
            textBox.Location = new Point(10, (Height - textBox.Height) / 2);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            textBox.BackColor = BackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 15;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public TextBox InnerTextBox
        {
            get { return textBox; }
        }
    }
}
