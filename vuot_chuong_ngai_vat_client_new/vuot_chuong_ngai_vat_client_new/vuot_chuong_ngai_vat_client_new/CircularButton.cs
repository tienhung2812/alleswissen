using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vuot_chuong_ngai_vat_client_new
{
    public partial class CircularButton : Control
    {
        private bool _Hovering = false;
        private bool Hovering
        {
            get { return _Hovering; }
            set
            {
                if (value == _Hovering) return;
                _Hovering = value;
                Invalidate();
            }
        }

        private bool _Pressed = false;
        private bool Pressed
        {
            get { return _Pressed; }
            set
            {
                if (value == _Pressed) return;
                _Pressed = value;
                Invalidate();
            }
        }

        public CircularButton()
        {
            InitializeComponent();
        }

        public new String Text
        {
            get { return base.Text; }
            set
            {
                if (value == base.Text) return;
                base.Text = value;
                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Hovering = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Hovering = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Hovering = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Hovering = false;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics gfx = pe.Graphics;
            Rectangle rc = ClientRectangle;
            rc.Width -= 1;
            rc.Height -= 1;
            gfx.FillRectangle(new SolidBrush(Parent.BackColor),ClientRectangle);

            Color fill;
            if (Pressed) fill = Color.DarkBlue;
            else if (Hovering) fill = Color.DarkRed;
            else fill = Color.Red;
            gfx.FillEllipse(new SolidBrush(fill), rc);

            gfx.DrawEllipse(new Pen(Color.Red, 1.0f), rc);
            Font fnt = new Font("Verdana", (float)rc.Height * 0.3f, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            gfx.DrawString(Text, fnt, new SolidBrush(Color.RoyalBlue), new RectangleF((float)rc.Left, (float)rc.Bottom, (float)rc.Width, (float)rc.Height),sf);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            
        }
    }
}
