using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int x = 0, y = 0,hp=100;
        public static string name = "玩家1";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += Form1_KeyDown;

            Random random = new Random();
            int jX= random.Next(0,this.ClientSize.Width-btnJ.Width);
            int jY = random.Next(0,this.ClientSize.Height-btnJ.Height);
            btnP.Location = new Point(jX, jY);
            btnP.Text = name + "HP："+Convert.ToString(hp);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSet a = new frmSet();

            a.Show(this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point p = new Point(x, y);

            btnP.Text = name + "HP：" + hp;

            if (btnP.Location.X+btnP.Size.Width>=btnJ.Location.X && btnP.Location.X<=btnJ.Location.X+btnJ.Width)
            {
                if (btnP.Location.Y + btnP.Size.Height >= btnJ.Location.Y && btnP.Location.Y <= btnJ.Location.Y + btnJ.Height)
                {
                    DialogResult dr = MessageBox.Show("你遇到了一只可爱的小怪兽", "单击“确定”攻击怪兽", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.OK)
                    {
                        btnJ.Location = new Point(-100, -100);
                        MessageBox.Show("恭喜你打败了小怪兽！");
                        hp = hp - 2;
                    }
                    else
                    {
                        Random random = new Random();
                        int suiji = random.Next(3,10);
                        MessageBox.Show("你在逃亡的过程中被怪兽打死了！");
                        hp = hp - suiji;
                    }
                }
            }

            if (e.KeyCode == Keys.S && btnP.Location.Y+btnP.Size.Height<=this.ClientSize.Height)
            {
                y = y + 1;
                btnP.Location = p;

            }
            if (e.KeyCode == Keys.W && btnP.Location.Y>=0)
            {
                y = y - 1;
                btnP.Location = p;

            }
            if (e.KeyCode == Keys.D && btnP.Location.X + btnP.Size.Width <= this.ClientSize.Width)
            {
                x = x + 1;
                btnP.Location = p;

            }
            if (e.KeyCode == Keys.A && btnP.Location.X >= 0)
            {
                x = x - 1;
                btnP.Location = p;

            }
        }
    }
}
