using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelEmpleados.Visible = false;
            panelNominas.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelEmpleados.Visible == true)
                panelEmpleados.Visible = false;
            if (panelNominas.Visible == true)
                panelNominas.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleados);
        }

        private void btnNominas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNominas);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
            Empleados em = new Empleados();
            em.MdiParent = this;
            em.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
            Departamento dep = new Departamento();
            dep.MdiParent = this;
            dep.Show();
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
            Puesto p = new Puesto();
            p.MdiParent = this;
            p.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnNominaFecha_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }
    }
}
