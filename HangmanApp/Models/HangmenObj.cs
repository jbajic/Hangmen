using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HangmanApp.Models
{
    class HangmenObj
    {
        private int stage;
        public Pen penPost;
        private Pen penMen;
        private Graphics graphics;
        private Panel panel;

        public HangmenObj(Panel panel)
        {
            this.stage = 7;
            penPost = new Pen(Color.Blue, 10);
            penMen = new Pen(Color.Red, 3);
            this.graphics = panel.CreateGraphics();
            this.panel = panel;
        }

        public void restartHangman()
        {
            panel.Invalidate();
            this.stage = 7;
        }

        public bool drawHangmen()
        {
            Console.WriteLine(stage);
            switch (stage)
            {
                case 7:
                    this.graphics.DrawLine(penPost, new Point(10, 400), new Point(230, 400));
                    break;
                case 6:
                    this.graphics.DrawLine(penPost, new Point(200, 400), new Point(200, 50));
                    break;
                case 5:
                    this.graphics.DrawLine(penPost, new Point(205, 50), new Point(80, 50));
                    break;
                case 4:
                    this.graphics.DrawLine(penPost, new Point(85, 50), new Point(85, 80));
                    break;
                case 3:
                    Rectangle rec = new Rectangle(new Point(60, 81), new Size(50, 50));
                    this.graphics.DrawEllipse(penMen, rec);
                    break;
                case 2:
                    this.graphics.DrawLine(penMen, new Point(85, 131), new Point(85, 250));
                    break;
                case 1:
                    this.graphics.DrawLine(penMen, new Point(85, 150), new Point(50, 110));
                    this.graphics.DrawLine(penMen, new Point(85, 150), new Point(120, 110));
                    break;
                case 0:
                    this.graphics.DrawLine(penMen, new Point(85, 250), new Point(50, 280));
                    this.graphics.DrawLine(penMen, new Point(85, 250), new Point(120, 280));
                    break;
            }
            if(this.lowerStage() == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int lowerStage()
        {
            return --this.stage;
        }

    }
}
