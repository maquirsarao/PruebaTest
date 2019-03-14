using PruebaTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTest
{
    public partial class FrmUsuarioMenu : Form
    {
        public FrmUsuarioMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            using (PruebaEntities db = new PruebaEntities())
            {
                var list = from a in db.Usuarios
                           where a.activo == true
                   select a;
                dataGridView1.DataSource = list.ToList();

            }
        }
        private int? getId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioNuevo FrmUsuarioNuevo = new FrmUsuarioNuevo();
            FrmUsuarioNuevo.ShowDialog();
            cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id!=null)
            {
                FrmUsuarioNuevo FrmUsuarioNuevo = new FrmUsuarioNuevo(id);
                FrmUsuarioNuevo.ShowDialog();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            using (PruebaEntities db = new PruebaEntities())
            {
                var list = from a in db.Usuarios
                           where a.Id == id
                           select a;
                foreach (var item in list)
                {
                    item.activo = false;
                    db.Entry(item).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            cargar();
        }
    }
}
