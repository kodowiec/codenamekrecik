using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{

    public partial class Preview : Form
    {
        Panel canvas;
        int canvaswidth;
        int canvasheight;
        int tilesize;

        string[,] strings;
        Color[,] colors;
        public Preview(Panel canvas, int canvaswidth, int canvasheight, int tilesize)
        {
            this.canvas = canvas;
            this.canvasheight = canvasheight;
            this.canvaswidth = canvaswidth;
            this.tilesize = tilesize;
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //int fontsize = this.Width / this.canvaswidth;
            //if (fontsize * this.canvasheight > this.Height) fontsize = this.Height / this.canvasheight;
            richTextBox1.Font = new System.Drawing.Font("MxPlus IBM BIOS",tilesize * 0.65f , System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            strings = new string[canvaswidth, canvasheight];
            colors = new Color[canvaswidth, canvasheight];

            foreach (Panel item in canvas.Controls)
            {
                int x = (item.Left - 5) / tilesize;
                int y = (item.Top - 5) / tilesize;

                strings[x, y] = item.Controls[0].Text;
                colors[x, y] = item.BackColor;
            }

            for (int y = 0; y < canvasheight; y++)
            {
                for (int x = 0; x < canvaswidth; x++)
                {
                    richTextBox1.AppendText(strings[x, y], colors[x, y]);
                }
                if (y != canvasheight - 1) richTextBox1.AppendText("\n");
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
