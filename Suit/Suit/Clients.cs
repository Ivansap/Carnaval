﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suit
{
    public partial class Clients : Form
    {
        Form1 form1;
        Order order;
        
        public Clients(Form1 f)
        {
            form1 = f;
            InitializeComponent();
            
        }
        public Clients(string f, Order r)
        {
            InitializeComponent();
            form = f;
            order = r;
        }
        string form = "start_form";
        private void changeForm(string formType)
        {
            switch(formType)
            {
                case "add":
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = false;
                        textBox1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break; 
                    }
                case "change":
                    {
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                        textBox1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "start_form":
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        textBox1.Enabled = true;
                        button3.Enabled = true;
                        button2.Enabled = true;
                        button4.Enabled = true;
                        break; }
            }
        }
        //Добавить
        private void button2_Click(object sender, EventArgs e)
        {
            changeForm("add");
        }
        //Изменить
        private void button3_Click(object sender, EventArgs e)
        {
            changeForm("change");
        }
        //Удалить
        private void button4_Click(object sender, EventArgs e)
        {

        }
        //Добавить_Ок
        private void button5_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //Добавить_отмена
        private void button6_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //Изменить_Ок
        private void button8_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //Изменить_отмена
        private void button7_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }


        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form1 != null) form1.Enabled = true;
            else if (order != null) order.Enabled = true;
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            changeForm(form);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                //вызов метода получения id клиента на order
                order.GetClient(id);
                this.Close();
            }
            catch { }
        }
    }
}
