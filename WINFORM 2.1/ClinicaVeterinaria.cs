using Autofac;
using Autofac.Core;
using System.ComponentModel;
using _00_PRESENTACION_WINFORM.IoC_Container;
using _01_APLICACION;
using _01_APLICACION.DTO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace _00_PRESENTACION_WINFORM;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CompletarDataGrid();
    }

    Autofac.IContainer container = _00_PRESENTACION_WINFORM.IoC_Container.Container.GetSQLContainer();

    private void AgregarClienteBtn_Click(object sender, EventArgs e)
    {
        try
        {
            CrearCliente creadorDeClientes = container.Resolve<CrearCliente>();
            string nombre = NombreTextBox.Text;
            string apellido = ApellidoTextBox.Text;
            string email = EmailTextBox.Text;
            validarNombre(nombre);
            validarApellido(apellido);
            validarEmail(email);
            creadorDeClientes.Ejecutar(new ClienteDTO(Guid.NewGuid(), nombre, apellido, email));
            CompletarDataGrid();
            VaciarTextBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ActualizarEmailBtn_Click(object sender, EventArgs e)
    {
        try
        {
            validarId(IdTextBox.Text);
            ActualizarEmail actualizadorDeMails = container.Resolve<ActualizarEmail>();
            string email = EmailTextBox.Text;
            validarEmail(email);
            Guid id = new Guid(IdTextBox.Text);
            actualizadorDeMails.Ejecutar(id, email);
            VaciarTextBoxes();
            CompletarDataGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CompletarDataGrid()
    {
        try
        {
            dataGridView1.Rows.Clear();
            ObtenerClientes obtenedorDeClientes = container.Resolve<ObtenerClientes>();
            List<ClienteDTO> clientes = obtenedorDeClientes.Ejecutar();

            foreach (ClienteDTO cliente in clientes)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = cliente.Id();
                row.Cells[1].Value = cliente.Nombre();
                row.Cells[2].Value = cliente.Apellido();
                row.Cells[3].Value = cliente.Email();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void EliminarClienteBtn_Click(object sender, EventArgs e)
    {
        try
        {
            validarId(IdTextBox.Text);
            EliminarCliente eliminadorDeCliente = container.Resolve<EliminarCliente>();
            Guid id = new Guid(IdTextBox.Text);
            eliminadorDeCliente.Ejecutar(id);
            CompletarDataGrid();
            VaciarTextBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            IdTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            NombreTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            ApellidoTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            EmailTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
        catch (Exception ex)
        {
            VaciarTextBoxes();
        }
    }

    private void EntityFrameworkBtn_Click_1(object sender, EventArgs e)
    {
        container = _00_PRESENTACION_WINFORM.IoC_Container.Container.GetEntityFrameworkContainer();
        dbLabel.Text = "Entity\nFramework";
        VaciarTextBoxes();
        CompletarDataGrid();
    }

    private void MongoDBBtn_Click(object sender, EventArgs e)
    {
        container = _00_PRESENTACION_WINFORM.IoC_Container.Container.GetMongoDBContainer();
        dbLabel.Text = "MongoDB";
        VaciarTextBoxes();
        CompletarDataGrid();
    }

    private void SQLServerBtn_Click(object sender, EventArgs e)
    {
        container = _00_PRESENTACION_WINFORM.IoC_Container.Container.GetSQLContainer();
        dbLabel.Text = "SQLServer";
        VaciarTextBoxes();
        CompletarDataGrid();
    }

    #region validaciones
    private void validarNombre(string nombre)
    {
        if (nombre.Length < 4)
        {
            throw new ArgumentException("El nombre debe contener, al menos, 4 caracteres.");
        }

        if (nombre.Length > 20)
        {
            throw new ArgumentException("El nombre debe contener un máximo de 20 caracteres.");
        }

        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }
    }

    private void validarApellido(string apellido)
    {
        if (apellido.Length < 4)
        {
            throw new ArgumentException("El apellido debe contener, al menos, 4 caracteres.");
        }

        if (apellido.Length > 20)
        {
            throw new ArgumentException("El apellido debe contener un máximo de 20 caracteres.");
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            throw new ArgumentException("El apellido no puede estar vacío.");
        }
    }

    private void validarEmail(string email)
    {
        var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        var regex = new Regex(pattern);
        if (!regex.IsMatch(email))
        {
            throw new ArgumentException("El email no es válido.");
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("El email no puede estar vacío.");
        }
    }

    private void validarId(string id)
    {
        if (id.Length <= 0)
        {
            throw new ArgumentException("El Id no es válido.");
        }
    }
    #endregion

    private void VaciarTextBoxes()
    {
        NombreTextBox.Clear();
        ApellidoTextBox.Clear();
        EmailTextBox.Clear();
        IdTextBox.Clear();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
}
