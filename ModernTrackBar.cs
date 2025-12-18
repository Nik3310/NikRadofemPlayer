using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NikRadofemPlayerWindows
{
    [DefaultEvent("Scroll")]
    public class ModernTrackBar : Control
    {
        private int _value = 50;
        private int _maximum = 100;
        private Color _trackColor = Color.FromArgb(64, 64, 64);
        private Color _progressColor = Color.Lime;
        private Color _thumbColor = Color.White;

        public event EventHandler Scroll;

        public ModernTrackBar()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.Height = 20;
            this.Cursor = Cursors.Hand;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get => _value;
            set
            {
                if (value < 0) value = 0;
                if (value > _maximum) value = _maximum;
                if (_value != value)
                {
                    _value = value;
                    Invalidate();
                    Scroll?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TrackColor
        {
            get => _trackColor;
            set { _trackColor = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ProgressColor
        {
            get => _progressColor;
            set { _progressColor = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ThumbColor
        {
            get => _thumbColor;
            set { _thumbColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int trackHeight = 4;
            int thumbSize = 14;
            int trackY = (this.Height - trackHeight) / 2;

            float percent = (float)_value / _maximum;
            int trackWidth = this.Width - thumbSize;
            int thumbX = (int)(trackWidth * percent);

            using (Brush b = new SolidBrush(_trackColor))
            {
                Rectangle rect = new Rectangle(thumbSize / 2, trackY, trackWidth, trackHeight);
                e.Graphics.FillRectangle(b, rect);
            }

            using (Brush b = new SolidBrush(_progressColor))
            {
                Rectangle rect = new Rectangle(thumbSize / 2, trackY, thumbX, trackHeight);
                e.Graphics.FillRectangle(b, rect);
            }

            using (Brush b = new SolidBrush(_thumbColor))
            {
                e.Graphics.FillEllipse(b, thumbX, (this.Height - thumbSize) / 2, thumbSize, thumbSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MoveThumb(e.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                MoveThumb(e.X);
            }
        }

        private void MoveThumb(int mouseX)
        {
            int thumbSize = 14;
            int trackWidth = this.Width - thumbSize;

            int x = mouseX - (thumbSize / 2);
            if (x < 0) x = 0;
            if (x > trackWidth) x = trackWidth;

            float percent = (float)x / trackWidth;
            this.Value = (int)(percent * _maximum);
        }
    }
}