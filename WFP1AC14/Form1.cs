using p1ACrud13.Clases.entidades;
using p1ACrud13.Clases.Servicio;

namespace WFP1AC14
{
    public partial class form1 : Form
    {

        ServicioAlumno srvAlumno = new();
        MdAlumnos oAlumnos = new();


        public form1()
        {
            InitializeComponent();
        }


        private void DesplegarGrid()
        {
            var respuesta = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridViewAlumnos.DataSource = respuesta;
        }


        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }


        private void MapaoDatosFormulario(MdAlumnos _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBox1Parcial1.Text = Convert.ToString(_alumnos.parcial1);
            textBox1Parcial2.Text = Convert.ToString(_alumnos.parcial2);
            textBox1Parcial3.Text = Convert.ToString(_alumnos.parcial3);
        }


        private void LimpiarDatos()
        {
            oAlumnos = new();
            MapaoDatosFormulario(oAlumnos);
        }

        private void buscaAlumno(string carnet)
        {
            oAlumnos = null;
            oAlumnos = srvAlumno.ObtenerAlumno(carnet);
            if (oAlumnos == null)
            {
                MessageBox.Show("no existe este cuate");
                LimpiarDatos();
            } else
            {
                MapaoDatosFormulario(oAlumnos);
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }



        private MdAlumnos DatosFormulario()
        {
            MdAlumnos _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo =  textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = Convert.ToInt32(textBox1Parcial1.Text);
            _alumnos.parcial2=Convert.ToInt32(textBox1Parcial2.Text);   
            _alumnos.parcial3=Convert.ToInt32(textBox1Parcial3.Text);
            return _alumnos;

        }
        public void Validacion()
        {
            MessageBox.Show("La nota ingresada no es valida");
            LimpiarDatos();
            oAlumnos = DatosFormulario();
        }




        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();

            if (oAlumnos.parcial1 > 20)
            {
                Validacion();
            }
            else if (oAlumnos.parcial2 > 25)
            {
                Validacion();
            }
            else if (oAlumnos.parcial3 > 30)
            {
                Validacion();
            }
            else
            {


                int respuesta = srvAlumno.CrearAlumno(oAlumnos);

            if (respuesta > 0)
            {
                MessageBox.Show("Se creo con existo el Alumno");
                LimpiarDatos();
                DesplegarGrid();
            } else
            {
                MessageBox.Show("Perdon hay un problema con la Grabacion");
            }


            }
        }



        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text  != "")
            {
                oAlumnos = DatosFormulario();
            int respuesta = srvAlumno.actualizarAlumno(oAlumnos);

            if (respuesta > 0)
            {
                MessageBox.Show("Se compuso el Alumno");
                LimpiarDatos();
                DesplegarGrid();
            }
            else
            {
                MessageBox.Show("Perdon hay un problema con la Grabacion");
            }
            }

            else 
            {
                MessageBox.Show("Nombre no puede quedar vacio");
            }

        }







        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Desktop\alunos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Desktop\p1ACrud13\salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos where seccion='A'", archivo));
        }

        private void bottun1eli_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres eliminar a este alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                oAlumnos = DatosFormulario();
                int respuesta = srvAlumno.button1eli(oAlumnos);
                if (respuesta > 0)
                {
                    MessageBox.Show("Alumno eliminado exitosamente");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al eliminar el alumno");
                }
            }
            if (r == DialogResult.No)
            {
                LimpiarDatos();
            }
        }
    }
}