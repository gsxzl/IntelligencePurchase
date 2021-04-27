using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligencePurchase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //Menu_Top.Location = new Point(this.label_gongsi.Location.X + 200, Menu_Top.Location.Y);
            Menu_Top.Size = new Size(this.Width - this.label_gongsi.Location.X - 300, panel_Top.Height);
            this.panel_Control.Location = new Point(this.Btn_Biaoti.Location.X, Btn_Biaoti.Location.Y + Btn_Biaoti.Height + 10);
            this.panel_Control.Size = new Size(this.Width - this.Btn_Biaoti.Location.X - 10, this.Height - Btn_Biaoti.Location.Y - Btn_Biaoti.Height - 10);
        }
    }
}
