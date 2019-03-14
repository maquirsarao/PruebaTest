using CurpValidator;
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
    public partial class FrmUsuarioNuevo : Form
    {
        public int? id;
        public Usuario usuario;
        public FrmUsuarioNuevo(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            using (PruebaEntities db= new PruebaEntities()) {
                    usuario = new Usuario();
                    usuario.Nombres = txtNombres.Text;
                    usuario.PrimerApellido = txtApellidoP.Text;
                    usuario.SegundoApellido = txtApellidoM.Text;
                    usuario.FechaNacimiento = dpNacimiento.Value;
                    usuario.EstadoNacimiento = (int) cbEstadoNacimiento.SelectedValue;
                    usuario.Estado = (int)cbEstado.SelectedValue;
                    usuario.Telefono = Convert.ToInt64(txtTelefono.Text);
                    if (rbMasc.Checked)
                        usuario.Sexo = false;
                    if (rbFem.Checked)
                        usuario.Sexo = true;
                    usuario.Municipio = txtMunicipio.Text;
                    usuario.Colonia = txtColonia.Text;
                    usuario.CalleNumero = txtCalleNum.Text;
                    usuario.CURP = txtCURP.Text;
                    usuario.activo = true;
                    try
                    {
                        if (this.id!=null)
                        {
                            usuario.Id = id;
                            db.Entry(usuario).State=EntityState.Modified;
                        }
                        else
                        {
                            usuario = db.Usuarios.Add(usuario);
                        }
                        db.SaveChanges();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al capturar");
                        throw;
                    }
                
            }
            else
            {
                MessageBox.Show("Alguno de los campos requerido, está vacío.");
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            validar();
            FederalEntities estadoNacimiento=buscarEntidad((int)cbEstadoNacimiento.SelectedValue);
            Genres genero=0;
            if (rbMasc.Checked)
                genero = Genres.Male;
            if (rbFem.Checked)
                genero = Genres.Female;
            dpNacimiento.Format = DateTimePickerFormat.Custom;
            dpNacimiento.CustomFormat = "dd/MM/yyyy";
            var fechaN= dpNacimiento.Value;
            string curp = CurpClass.CreateCURP(txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, fechaN,genero, estadoNacimiento);
            txtCURP.Text = curp;
        }
        private FederalEntities buscarEntidad(int id)
        {
            switch (id)
            {
                case 1:
                    return FederalEntities.Aguascalientes;
                    break;
                case 2:
                    return FederalEntities.BajaCalifornia;
                    break;
                case 3:
                    return FederalEntities.BajaCaliforniaSur;
                    break;
                case 4:
                    return FederalEntities.Campeche;
                    break;
                case 5:
                    return FederalEntities.Chiapas;
                    break;
                case 6:
                    return FederalEntities.Chihuaha;
                    break;
                case 7:
                    return FederalEntities.Coahuila;
                    break;
                case 8:
                    return FederalEntities.Colima;
                    break;
                case 9:
                    return FederalEntities.DistritoFederal;
                    break;
                case 10:
                    return FederalEntities.Durango;
                    break;
                case 11:
                    return FederalEntities.Guanajuato;
                    break;
                case 12:
                    return FederalEntities.Guerrero;
                    break;
                case 13:
                    return FederalEntities.Hidalgo;
                    break;
                case 14:
                    return FederalEntities.Jalisco;
                    break;
                case 15:
                    return FederalEntities.Mexico;
                    break;
                case 16:
                    return FederalEntities.Michoacan;
                    break;
                case 17:
                    return FederalEntities.Morelos;
                    break;
                case 18:
                    return FederalEntities.Nayarit;
                    break;
                case 19:
                    return FederalEntities.NuevoLeon;
                    break;
                case 20:
                    return FederalEntities.Oaxaca;
                    break;
                case 21:
                    return FederalEntities.Puebla;
                    break;
                case 22:
                    return FederalEntities.Queretaro;
                    break;
                case 23:
                    return FederalEntities.QuintanaRoo;
                    break;
                case 24:
                    return FederalEntities.SanLuisPotosi;
                    break;
                case 25:
                    return FederalEntities.Sinaloa;
                    break;
                case 26:
                    return FederalEntities.Sonora;
                    break;
                case 27:
                    return FederalEntities.Tabasco;
                    break;
                case 28:
                    return FederalEntities.Tamaulipas;
                    break;
                case 29:
                    return FederalEntities.Tlaxcala;
                    break;
                case 30:
                    return FederalEntities.Veracruz;
                    break;
                case 31:
                    return FederalEntities.Yucatan;
                    break;
                case 32:
                    return FederalEntities.Zacatecas;
                    break;
                default: return FederalEntities.NacidoExtranjero;
            }
        }
        private Boolean validar()
        {
            bool success = true;
            if (txtNombres.Text.Equals("")
                || txtApellidoP.Text.Equals("")
                || txtApellidoM.Text.Equals("")
                || txtCalleNum.Text.Equals("")
                || txtColonia.Text.Equals("")
                || txtCURP.Text.Equals("")
                || txtMunicipio.Text.Equals("")
                || txtTelefono.Text.Equals(""))
            {
                success = false;
            }
            return success;
        }
        private void cargar()
        {
            using (PruebaEntities db = new PruebaEntities())
            {
                var list = from a in db.Estadoes
                           select a;

                cbEstadoNacimiento.DisplayMember = "nombre";
                cbEstadoNacimiento.ValueMember = "id";
                cbEstadoNacimiento.DataSource = list.ToList();
                cbEstado.DisplayMember = "nombre";
                cbEstado.ValueMember = "id";
                cbEstado.DataSource = list.ToList();
                if (this.id != 0) {
                var usariosList = from a in db.Usuarios
                                  where a.Id == this.id
                                  select a;
                    foreach (var item in usariosList)
                    {
                        txtNombres.Text = item.Nombres;
                        txtApellidoP.Text = item.PrimerApellido;
                        txtApellidoM.Text = item.SegundoApellido;
                        dpNacimiento.Value = item.FechaNacimiento;
                        cbEstadoNacimiento.SelectedIndex= cbEstadoNacimiento.FindStringExact(item.Estado1.nombre);
                        cbEstado.SelectedIndex = cbEstado.FindStringExact(item.Estado2.nombre);
                        txtTelefono.Text = item.Telefono.ToString();
                        if (item.Sexo)
                        {
                            rbFem.Checked = true;
                            rbMasc.Checked = false;
                        }
                        else {
                            rbMasc.Checked = true;
                            rbFem.Checked = false;
                        }
                        txtMunicipio.Text= item.Municipio;
                        txtColonia.Text= item.Colonia;
                        txtCalleNum.Text= item.CalleNumero;
                        txtCURP.Text= item.CURP;
                    }
                }
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
