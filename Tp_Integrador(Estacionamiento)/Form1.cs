using Business;
using Entitys;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Tp_Integrador_Estacionamiento_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TraerTurnos();
            ChequearTurno();
            TraerVehiculos();
            ChequearPlazas(PlazaBss.TraerPlazas());
            TraerEstadias();
        }
        public TurnoBss TurnoBss = new TurnoBss();
        public PlazaBss PlazaBss = new PlazaBss();
        public VehiculoBss VehiculoBss = new VehiculoBss();
        public EstadiaBss EstadiaBss = new EstadiaBss();
        public Turno TurnoEstacionamiento = new Turno();
        public Estadia EstadiaEstacionamiento = new Estadia();

        public void TraerTurnos()
        {
            dtgTurnos.DataSource = null;
            dtgTurnos.DataSource = TurnoBss.TraerTurnos();
        }
        public void ChequearTurno()
        {
            try
            {
                if (TurnoBss.ChequearTurno())
                {
                    TurnoEstacionamiento = TurnoBss.TraerTurnos().LastOrDefault();
                    btnAltaEstadia.Enabled = true;
                    btnBorrarEstadia.Enabled = true;
                    btnModificarEstadia.Enabled = true;
                    btnCerrarEstadia.Enabled = true;
                    btnCerrarTurno.Enabled = true;
                    dtgAutos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay ning�n turno abierto. Por favor, abra uno nuevo", "Notificacion de sistema");
                    btnAltaEstadia.Enabled = false;
                    btnBorrarEstadia.Enabled = false;
                    btnModificarEstadia.Enabled = false;
                    btnCerrarEstadia.Enabled = false;
                    btnCerrarTurno.Enabled = false;
                    dtgAutos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void TraerVehiculos()
        {
            dtgAutos.DataSource = null;
            dtgAutos.DataSource = VehiculoBss.TraerVehiculos();
            dtgAutos.Columns["Plaza"].Visible = false;
            dtgAutos.Columns["Turno"].Visible = false;
        }
        public void TraerEstadias()
        {
            dtgEstadias.DataSource = null;
            dtgEstadias.DataSource = EstadiaBss.TraerEstadias()
                .Select(e => new
                {
                    e.Id,
                    Plaza = e.PlazaId,
                    TurnoEntrada = e.TurnoEntradaNombre,
                    e.Entrada,
                    e.Salida,
                    e.PrecioHora,
                    e.ImporteTotal
                }).ToList();
        }
        public void ChequearPlazas(List<Plaza> plazas)
        {
            foreach (var plaza in plazas)
            {
                Button btn = this.Controls.Find("btn" + plaza.Id, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.BackColor = plaza.Estado ? Color.Red : Color.Green;
                }
            }
        }

        public void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (TurnoBss.ChequearTurno())
                {
                    MessageBox.Show("Ya hay un turno abierto", "Notificacion de sistema");
                }
                else
                {
                    TurnoEstacionamiento.EncargadoTurno = Interaction.InputBox("Ingresar Nombre de encargado de turno", "Abir turno", "");
                    TurnoEstacionamiento.MontoApertura = Convert.ToDouble(Interaction.InputBox("Ingrese monto de caja", "Abrir turno", ""));
                    TurnoBss.AbrirTurno(TurnoEstacionamiento);
                    TraerTurnos();
                    ChequearTurno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoEstacionamiento.MontoCierre += TurnoEstacionamiento.MontoApertura;
                TurnoEstacionamiento.TotalGenerado = TurnoEstacionamiento.CalcularTotal();
                TurnoBss.CerrarTurno(TurnoEstacionamiento);
                TraerTurnos();
                MessageBox.Show("El turno fue cerrado con exito");
                ChequearTurno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAltaEstadia_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Patente = Convert.ToInt32(Interaction.InputBox("Ingrese los 3 numeros de la patente", "ingreso de vehiculo"));
                vehiculo.Plaza = PlazaBss.TraerPlazas().FirstOrDefault(p => !p.Estado);
                vehiculo.Turno = TurnoEstacionamiento;
                vehiculo.TipoVehiculo = Interaction.InputBox("Ingrese el tipo de vehiculo", "ingreso de vehiculo");
                vehiculo.Marca = Interaction.InputBox("Ingrese marca del vehiculo", "ingreso de vehiculo");
                vehiculo.Modelo = Interaction.InputBox("Ingrese modelo del vehiculo", "ingreso de vehiculo");
                vehiculo.Color = Interaction.InputBox("Ingrese color del vehiculo", "ingreso de vehiculo");
                VehiculoBss.CargarVehiculo(vehiculo);
                PlazaBss.ModificarEstadoPlaza(vehiculo.Plaza);
                TraerVehiculos();
                ChequearPlazas(PlazaBss.TraerPlazas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarEstadia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgAutos.SelectedRows.Count > 0)
                {
                    Vehiculo vehiculo = (Vehiculo)dtgAutos.SelectedRows[0].DataBoundItem;
                    vehiculo.Plaza.Estado = false;
                    VehiculoBss.BorrarVehiculo(vehiculo);
                    PlazaBss.ModificarEstadoPlaza(vehiculo.Plaza);
                    TraerVehiculos();
                    ChequearPlazas(PlazaBss.TraerPlazas());
                }
                else
                {
                    throw new Exception("Seleccione un auto para borrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarEstadia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgAutos.SelectedRows.Count > 0)
                {
                    Vehiculo vehiculo = (Vehiculo)dtgAutos.SelectedRows[0].DataBoundItem;
                    vehiculo.Patente = Convert.ToInt32(Interaction.InputBox("Ingrese los 3 numeros de la patente", "ingreso de vehiculo", $"{vehiculo.Patente.ToString()}"));
                    vehiculo.TipoVehiculo = Interaction.InputBox("Ingrese el tipo de vehiculo", "ingreso de vehiculo", $"{vehiculo.TipoVehiculo}");
                    vehiculo.Marca = Interaction.InputBox("Ingrese marca del vehiculo", "ingreso de vehiculo", $"{vehiculo.Marca}");
                    vehiculo.Modelo = Interaction.InputBox("Ingrese modelo del vehiculo", "ingreso de vehiculo", $"{vehiculo.Modelo}");
                    vehiculo.Color = Interaction.InputBox("Ingrese color del vehiculo", "ingreso de vehiculo", $"{vehiculo.Color}");
                    VehiculoBss.ModificarVehiculo(vehiculo);
                    TraerVehiculos();
                }
                else
                {
                    throw new Exception("Seleccione un auto para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarEstadia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgAutos.SelectedRows.Count > 0)
                {
                    Vehiculo vehiculo = (Vehiculo)dtgAutos.SelectedRows[0].DataBoundItem;
                    EstadiaEstacionamiento.Plaza = vehiculo.Plaza;
                    EstadiaEstacionamiento.TurnoEntrada = vehiculo.Turno;
                    EstadiaEstacionamiento.TurnoSalida = TurnoEstacionamiento;
                    EstadiaEstacionamiento.Entrada = vehiculo.Entrada;
                    EstadiaEstacionamiento.Salida = DateTime.Now;
                    EstadiaEstacionamiento.ImporteTotal = EstadiaEstacionamiento.CalcularImporte();
                    MessageBox.Show($"El total a pagar es {EstadiaEstacionamiento.ImporteTotal}");
                    TurnoEstacionamiento.MontoCierre = +EstadiaEstacionamiento.ImporteTotal;
                    EstadiaBss.CargarEstadia(EstadiaEstacionamiento);

                    vehiculo.Plaza.Estado = false;
                    VehiculoBss.BorrarVehiculo(vehiculo);
                    PlazaBss.ModificarEstadoPlaza(vehiculo.Plaza);
                    TraerVehiculos();
                    ChequearPlazas(PlazaBss.TraerPlazas());
                    TraerEstadias();
                }
                else
                {
                    throw new Exception("Seleccione un auto para generar facturacion de estadia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
