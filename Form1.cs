using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastrarVeiculosProva
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            rbONIBUS.Checked = true;
            rbCAMINHAO.Checked = false;
            gerarGradeListViewCaminhao();
            gerarGradesListViewOnibus();
        }

        private void rbONIBUS_CheckedChanged(object sender, EventArgs e)
        {
            lbASSENTOSEIXOS.Text = "Assentos";
            Limpar();

        }

        private void rbCAMINHAO_CheckedChanged(object sender, EventArgs e)
        {
            Limpar();
            lbASSENTOSEIXOS.Text = "Eixos";

        }

        private void btLIMPAR_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            txtPLACA.Text = string.Empty;
            txtANO.Text = string.Empty;
            txtASSENTOSEIXOS.Text = string.Empty;

        }
        private void gerarGradesListViewOnibus()
        {
            lvONIBUS.Columns.Add("Placa", 150).TextAlign = HorizontalAlignment.Center;
            lvONIBUS.Columns.Add("Ano", 100).TextAlign = HorizontalAlignment.Center;
            lvONIBUS.Columns.Add("Assentos", 100).TextAlign = HorizontalAlignment.Center;
            lvONIBUS.Columns.Add("Diária", 100).TextAlign = HorizontalAlignment.Center;
            lvONIBUS.View = View.Details;


        }
        private void gerarGradeListViewCaminhao()
        {
            lvCAMINHAO.Columns.Add("Placa", 150).TextAlign = HorizontalAlignment.Center;
            lvCAMINHAO.Columns.Add("Ano", 100).TextAlign = HorizontalAlignment.Center;
            lvCAMINHAO.Columns.Add("Eixos", 100).TextAlign = HorizontalAlignment.Center;
            lvCAMINHAO.Columns.Add("Diária", 100).TextAlign = HorizontalAlignment.Center;
            lvCAMINHAO.View = View.Details;
        }

        private void btCADASTRAR_Click(object sender, EventArgs e)

        {
            try
            {
                // Validação dos campos comuns
                if (string.IsNullOrWhiteSpace(txtPLACA.Text))
                {
                    MessageBox.Show("O campo 'Placa' é obrigatório.");
                    return;
                }
                if (!int.TryParse(txtANO.Text, out int ano))
                {
                    MessageBox.Show("Valor inválido para 'Ano'. Use apenas números.");
                    return;
                }

                //Logica para Onibus
                if (rbONIBUS.Checked)
                {
                    if (!int.TryParse(txtASSENTOSEIXOS.Text, out

                            int assentos) || assentos <= 0)
                    {
                        MessageBox.Show("Valor inválido para 'Assentos'. Use apenas números positivos.");
                        return;
                    }
                    Onibus onibus = new Onibus(assentos, txtPLACA.Text, ano);
                    ListViewItem item = new ListViewItem(onibus.Placa);
                    item.SubItems.Add(onibus.Ano.ToString());
                    item.SubItems.Add(onibus.Assentos.ToString());
                    item.SubItems.Add(onibus.Alugar().ToString("C2"));
                    lvONIBUS.Items.Add(item);

                    Limpar(); }
                //Logica para Caminhao
                else if (rbCAMINHAO.Checked)
                {
                    if (!int.TryParse(txtASSENTOSEIXOS.Text, out int eixos) || eixos <= 0)
                    {
                        MessageBox.Show("Valor inválido para 'Eixos'. Use apenas números positivos.");
                        return;
                    }
                    Caminhao caminhao = new Caminhao(eixos, txtPLACA.Text, ano);
                    ListViewItem item = new ListViewItem(caminhao.Placa);
                    item.SubItems.Add(caminhao.Ano.ToString());
                    item.SubItems.Add(caminhao.Eixos.ToString());
                    item.SubItems.Add(caminhao.Alugar().ToString("C2"));
                    lvCAMINHAO.Items.Add(item);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de veículo (Ônibus ou Caminhão)."); }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
