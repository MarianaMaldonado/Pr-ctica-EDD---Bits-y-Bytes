using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace práctica_bitsybytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
           
            Int32 Mostrar = Convert.ToInt32(txtEntradaDeDatos.Text);
            Mostrar >>=1;

            //Dirección de movimiento
            switch(Mostrar & 3)
            {
                case 0:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechanorte;
                        break;
                    }
                case 1:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechanoroeste;
                        break;
                    }
                case 2:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechaeste;
                        break;
                    }
                case 3:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechasureste;
                        break;
                    }
                case 4:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechasur;
                        break;
                    }
                case 5:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechasuroeste;
                        break;
                    }
                case 6:
                    {
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechaoeste;
                        break;
                    }
                case 7:{
                        picboxDirecciónDeMovimiento.Image = Properties.Resources.flechanoroeste;
                        break;
                    }

            }
            //Llenado del tanque /Nivel del tanque
            Mostrar >>= 3;
            switch(Mostrar  & 3){
                case 0:
                    {
                        picboxNivel.Image = Properties.Resources.tanquevacío;
                        break;
                    }
                case 1:
                    {
                        picboxNivel.Image = Properties.Resources.tanquemedio;
                        break;
                    }
                case 2:
                    {
                        picboxNivel.Image = Properties.Resources.tanquelleno;
                        break;
                    }
                case 3:
                    {
                        picboxNivel.Image = Properties.Resources.tanqueprocesodellenado;
                        break;
                    }
            }

            
            // Sensor 1

            Mostrar >>= 1;
            switch(Mostrar & 1)
            {
                case 0:
                    {
                        picboxSensor1.Image = Properties.Resources.sensoroff;
                        break;
                    }
                case 1:
                    {
                        picboxSensor1.Image = Properties.Resources.sensoron;
                        break;
                    }

            }
            
            // Sensor 2
            Mostrar >>= 2;

            switch(Mostrar & 1)
            {
                case 0:
                    {
                        picboxSensor2.Image = Properties.Resources.sensoroff;
                        break;
                    }
                case 1:
                    {
                        picboxSensor2.Image = Properties.Resources.sensoron;
                        break;
                    }
            }

            Int32 Día;
            Int32 Mes;
            Int32 Año;

            Mostrar >>= 1;
            Día = Mostrar & 31;
            Mostrar >>= 5;
            Mes = Mostrar & 12;
            Mostrar >>= 4;
            Año = Mostrar & 127;
            Año = Año + 1900;

            lblFecha.Text = Año + "/" + Mes + "/" + Día.ToString();
        }
    }
}
