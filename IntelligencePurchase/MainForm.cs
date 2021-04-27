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

        private void Menu_Top_ClickItemed(object sender, EventArgs e)
        {
            var uCNavigationMenu = sender as HZH_Controls.Controls.UCNavigationMenu;
            string selectMenu = uCNavigationMenu.SelectItem.Text;
            Btn_Biaoti.BtnText = selectMenu;
            if (!string.IsNullOrEmpty(selectMenu))
            {
                panel_Control.Controls.Clear();

                switch (selectMenu)
                {
                    case "报备管理":
                        ProjectControl projectControl = new ProjectControl();
                        projectControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(projectControl);
                        break;
                    case "合同管理":
                        ContractControl contractControl = new ContractControl();
                        contractControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(contractControl);
                        break;
                    case "NC物料编码":
                        NCControl nCControl = new NCControl();
                        nCControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(nCControl);
                        break;
                    case "标段库管理":
                        BidSectionControl bidSectionControl = new BidSectionControl();
                        bidSectionControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(bidSectionControl);
                        break;
                    case "价格库管理":
                        PriceControl priceControl = new PriceControl();
                        priceControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(priceControl);
                        break;
                    case "供应商管理":
                        SupplierControl supplierControl = new SupplierControl();
                        supplierControl.Dock = DockStyle.Fill;
                        panel_Control.Controls.Add(supplierControl);
                        break;
                    default:
                        break;
                }
            }

        }




    }
}
