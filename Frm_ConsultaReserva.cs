﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Pim_3_Semestre
{
    public partial class Frm_ConsultaReserva : Form
    {
        Frm_Pagamento frm_Pagamento;
        public Frm_ConsultaReserva()
        {
            frm_Pagamento = new Frm_Pagamento();
            InitializeComponent();
        }

        private void Frm_ConsultaReserva_Load(object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            frm_Pagamento.ShowDialog();
        }
    }
}
