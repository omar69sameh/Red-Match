using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_12
{
    public partial class Form1 : Form
    {
        class cActor
        {
            public int x, y;
        }
        int x = 200;
        int y = 200;
        int ct = 0;
        int x2 = 700;
        int y2 = 200;
        int ct2 = 0;
        int flag = 0;
        int ent = 0;
        int z = 0;
        public Form1()
        {
            WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawScene();
        }
        List<cActor> actors1 = new List<cActor>();
        List<cActor> actors2 = new List<cActor>();
        List<cActor> actors3 = new List<cActor>();
        void drawScene()
        {
            Graphics g= this.CreateGraphics();
            g.Clear(Color.Black);
            Pen pen = new Pen(Color.Yellow);
            for (int i=0; i<2;i++)
            {
                g.DrawRectangle(pen, x + (i * 500), y, 400, 400);
            }
            Random rr = new Random();
            int r1 = rr.Next(30);
            for(int  i=0; i<r1;i++)
            {
                Brush brush = new SolidBrush(Color.Red);
                g.FillRectangle(brush, x + (ct * 65), y, 50, 50);
                cActor pnn = new cActor();
                pnn.x = x;
                pnn.y = y;
                actors1.Add(pnn);
                ct++;
                if(ct==6)
                {
                    y += 60;
                    ct = 0;
                }
            }
            
            Random rr2 = new Random();
            int r2 = rr2.Next(r1 - 1);
            for (int i = 0; i < r2; i++)
            {
                SolidBrush brush = new SolidBrush(Color.Red);
                g.FillRectangle(brush, x2 + (ct2 * 65), y2, 50, 50);
                cActor pnn = new cActor();
                pnn.x = x2;
                pnn.y = y2;
                actors2.Add(pnn);
                ct2++;
                if (ct2 == 6)
                {
                    y2 += 60;
                    ct2 = 0;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Graphics g = this.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Orange);
                g.FillEllipse(brush, x2 + (ct2 * 65), y2, 50, 50);
                cActor pnn = new cActor();
                pnn.x = x2;
                pnn.y = y2;
                actors3.Add(pnn);
                ct2++;
                if(ct2==6)
                {
                    y2 += 60;
                    ct2 = 0;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                if (actors2.Count + actors3.Count==actors1.Count)
                {
                    MessageBox.Show("good");
                }
                else
                {
                    MessageBox.Show("erorr");
                }
            }
        }

    }
}
