using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma once
#include "Registro.cs"

namespace Alquiler_de_Vehiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Cartagena");
            comboBox1.Items.Add("Barranquilla");
            comboBox1.Items.Add("Bogota");

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("7:00");
            comboBox2.Items.Add("8:00");
            comboBox2.Items.Add("9:00");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("17:00");
            comboBox2.Items.Add("18:00");


            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox3.Items.Add("7:00");
            comboBox3.Items.Add("8:00");
            comboBox3.Items.Add("9:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            comboBox3.Items.Add("17:00");
            comboBox3.Items.Add("18:00");


            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox4.Items.Add("Ford Escape");
            comboBox4.Items.Add("Ford Ranger");
            comboBox4.Items.Add("Mazda 3 1ra Generación");
            comboBox4.Items.Add("Mitsubishi L200");
            comboBox4.Items.Add("Renault Logan");
            comboBox4.Items.Add("Volkswagen Jetta Automatico");
            comboBox4.Items.Add("Volkswagen Jetta Mecanico");
            comboBox4.Items.Add("Chevrolet Aveo");
            comboBox4.Items.Add("Dodge Ram 2500");
            comboBox4.Items.Add("Dodge Journey");


            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox5.Items.Add("Dia Alquiler 0%");
            comboBox5.Items.Add("Visa Empresarial 20%");
            comboBox5.Items.Add("Visa Gold 10%");
            comboBox5.Items.Add("Visa Infinite  20%");
            comboBox5.Items.Add("Visa Platinium  20%");
            comboBox5.Items.Add("Visa Signature  20%");



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         /// <summary>
         /// This is called when the button is clicked
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Registro form = new Registro();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
