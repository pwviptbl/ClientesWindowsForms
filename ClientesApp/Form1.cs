using ClientesApp.Controllers;
using ClientesApp.Models;
using ClientesApp.Repository;
using System;
using System.Windows.Forms;

namespace ClientesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        * public id = int ou null
        */
        public int? id = null;

        /*
        * Carrega a Grig com todos os registros
        */
        public void load()
        {
            reset();
            dataGridView2.DataSource = ClienteRepository.selectAll();
            dataGridView2.DataMember = "clientes";
           
        }

        /*
        * Form pronto
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        /*
        * button Cadastrar e Alterar
        * Valida os dados antes de enviar
        */
        private void insert_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.id = id;
            cliente.nome = textBox_nome.Text;
            cliente.email = textBox_email.Text;
            cliente.cpf = textBox_cpf.Text;
            cliente.telefone = textBox_tel.Text;

            Response response = ClienteController.isvalid(cliente);
            if (response.Success) {
                int i = ClienteRepository.insert(cliente);
                if (i != 0) {
                    if (id == null)
                        MessageBox.Show("Cadastrado com Sucesso!");
                    else
                        MessageBox.Show("Alterado com Sucesso!");
                    load();
                } else {
                    MessageBox.Show("Erro ao Cadastrar!");
                }
            } else {
                MessageBox.Show(response.Message);
            }
        }

        /*
        * button reset formulario
        */
        private void button_reset_Click(object sender, EventArgs e)
        {
            load();
        }

        /*
        * button delete
        */
        private void button_deletar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                int i = ClienteRepository.deletar((int)id);
            }
            load();
        }

        /*
        * Zera todo Formulario
        */
        private void reset()
        {
            button_insert.Text = "Cadastrar";
            id = null;
            textBox_nome.Clear();
            textBox_email.Clear();
            textBox_cpf.Clear();
            textBox_tel.Clear();
            textBox_pesquisar.Clear();
        }

        /*
        * seleciona a linnha da Grid para alterar ou deletar
        */
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            textBox_nome.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox_email.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox_cpf.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox_tel.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            button_insert.Text = "Alterar";
        }

        /*
        * Aplica formatação CPF
        */
        private void textBox_cpf_TextChanged(object sender, EventArgs e)
        {
            string format = Format.FormatCPF((string)textBox_cpf.Text);
            textBox_cpf.Text = format;
        }

        /*
        * Aplica formatação no telefone
        */
        private void textBox_tel_TextChanged(object sender, EventArgs e)
        {
            string format = Format.FormatTelefone((string)textBox_tel.Text);
            textBox_tel.Text = format;
        }

        private void textBox_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_pesquisar.Text != string.Empty) 
                dataGridView2.DataSource = ClienteRepository.select(textBox_pesquisar.Text);
            else
                dataGridView2.DataSource = ClienteRepository.selectAll();
            dataGridView2.DataMember = "clientes";
        }
    }
}
