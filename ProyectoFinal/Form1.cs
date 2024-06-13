using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private List<string> equipos = new List<string> { "Equipo A", "Equipo B", "Equipo C", "Equipo D" };
        private Dictionary<string, int> puntajes = new Dictionary<string, int>();
        private List<string> historialResultados = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InicializarPuntajes();
        }

        private void InicializarPuntajes()
        {
            foreach (var equipo in equipos)
            {
                puntajes[equipo] = 0;
            }
        }

        private void btnGenerarResultado_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var equipo1 = equipos[random.Next(equipos.Count)];
            var equipo2 = equipos[random.Next(equipos.Count)];

            // Asegurarse de que no sean el mismo equipo
            while (equipo1 == equipo2)
            {
                equipo2 = equipos[random.Next(equipos.Count)];
            }

            int puntaje1 = random.Next(0, 6);
            int puntaje2 = random.Next(0, 6);

            string resultado = $"{equipo1} {puntaje1} - {puntaje2} {equipo2}";
            historialResultados.Add(resultado);

            // Sumar puntos
            if (puntaje1 > puntaje2)
            {
                puntajes[equipo1] += 3;
            }
            else if (puntaje1 < puntaje2)
            {
                puntajes[equipo2] += 3;
            }
            else
            {
                puntajes[equipo1] += 1;
                puntajes[equipo2] += 1;
            }

            MessageBox.Show(resultado);
        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();
            foreach (var resultado in historialResultados)
            {
                lstHistorial.Items.Add(resultado);
            }

            lstHistorial.Items.Add("Puntajes:");
            foreach (var equipo in equipos)
            {
                lstHistorial.Items.Add($"{equipo}: {puntajes[equipo]} puntos");
            }
        }

        private void btnBorrarHistorial_Click(object sender, EventArgs e)
        {
            historialResultados.Clear();
            lstHistorial.Items.Clear();
            InicializarPuntajes();
            MessageBox.Show("El historial ha sido borrado.");
        }
    }
}