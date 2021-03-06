﻿using eNutrideal_desktop.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNutrideal_desktop
{
    public partial class CalculadoraPesoIdeal : Form
    {
       

        private class Item
        {
            public string Name;

            public Item(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }

        }

        public CalculadoraPesoIdeal()
        {
            InitializeComponent();
            comboBox_genero.Items.Add(new Item("Masculino"));
            comboBox_genero.Items.Add(new Item("Feminino"));

        }

        private void CalculadoraPesoIdeal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new eNutrideal().Show();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(numericUpDown_idade.Value);

            int altura = Convert.ToInt32(numericUpDown_altura.Value);
            string genero = comboBox_genero.Text;


            ServiceClient client = new ServiceClient();
            //double resultado_final = client.CalcularPesoIdeal(idade, altura, genero);
            //textBox_resultado.Text = Convert.ToString(resultado_final);

            //double resultado_final = 0;
            //Robinson Formula:
            //Men: Ideal Body Weight(kg) = 52 kg + 1.9 kg per inch over 5 feet.
            //Women: Ideal Body Weight(kg) = 49 kg + 1.7 kg per inch over 5 feet.


            /*
            if (genero.Equals("Masculino"))
            {

                if (altura <= 152.4)
                {
                    resultado_final = 52;
                }
                else
                {
                    resultado_final = 52 + (0.7480) * (altura - 152.4);
                }
            }

            if (genero.Equals("Feminino"))
            {

                if (altura <= 152.4)
                {
                    resultado_final = 49;
                }
                else
                {
                    resultado_final = 49 + (0.66929) * (altura - 152.4);
                }
            }

            textBox_resultado.Text = Convert.ToString(resultado_final);
            */


        }

        

        private void textBox_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_idade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
