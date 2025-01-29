using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace clean_comment.RJControls
{
    public class RJToggleBtn : CheckBox
    {

        //fields
        private Color onBckColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBckColor = Color.DarkGray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;


        public Color OnBckColor { get => onBckColor; set { onBckColor = value; this.Invalidate(); } }
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        public Color OffBckColor { get => offBckColor; set { offBckColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value;this.Invalidate(); }
}

        //constructor
        public RJToggleBtn()
        {
            this.MinimumSize = new Size(45, 22);
        }

        public override string Text { get => base.Text;}


        [DefaultValue(true)]
        public bool SolidStyle { get => solidStyle; set { solidStyle = value; this.Invalidate(); } }

        //mthods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle( this.Width - arcSize - 2 , 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked)
            {
                if(solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBckColor), GetFigurePath());

                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(onBckColor, 2), GetFigurePath());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBckColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(offBckColor, 2), GetFigurePath());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
