﻿namespace SHOP.UI
{
    partial class cadPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btProcurar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.tbCep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCpfcnpj = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.btPesquisarProd = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tbValorTotalPedido = new System.Windows.Forms.TextBox();
            this.btApagar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbValortotal = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbCodigoProd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerar Pedido";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCliente);
            this.tabControl.Controls.Add(this.tabProduto);
            this.tabControl.Location = new System.Drawing.Point(12, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 465);
            this.tabControl.TabIndex = 1;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.btProcurar);
            this.tabCliente.Controls.Add(this.tbCodigo);
            this.tabCliente.Controls.Add(this.label14);
            this.tabCliente.Controls.Add(this.rbInativo);
            this.tabCliente.Controls.Add(this.rbAtivo);
            this.tabCliente.Controls.Add(this.tbCep);
            this.tabCliente.Controls.Add(this.label11);
            this.tabCliente.Controls.Add(this.label13);
            this.tabCliente.Controls.Add(this.label12);
            this.tabCliente.Controls.Add(this.label10);
            this.tabCliente.Controls.Add(this.label9);
            this.tabCliente.Controls.Add(this.label8);
            this.tabCliente.Controls.Add(this.label7);
            this.tabCliente.Controls.Add(this.label6);
            this.tabCliente.Controls.Add(this.label5);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Controls.Add(this.tbCpfcnpj);
            this.tabCliente.Controls.Add(this.tbBairro);
            this.tabCliente.Controls.Add(this.tbNumero);
            this.tabCliente.Controls.Add(this.tbTelefone);
            this.tabCliente.Controls.Add(this.tbEmail);
            this.tabCliente.Controls.Add(this.tbEndereco);
            this.tabCliente.Controls.Add(this.tbNome);
            this.tabCliente.Controls.Add(this.cbCidade);
            this.tabCliente.Controls.Add(this.cbEstado);
            this.tabCliente.Controls.Add(this.cbSexo);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(912, 439);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente/Destinatário";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(484, 87);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(107, 23);
            this.btProcurar.TabIndex = 37;
            this.btProcurar.Text = "Procurar cliente";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(297, 84);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(167, 31);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(205, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Código:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Enabled = false;
            this.rbInativo.Location = new System.Drawing.Point(525, 290);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 11;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Enabled = false;
            this.rbAtivo.Location = new System.Drawing.Point(470, 290);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 10;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // tbCep
            // 
            this.tbCep.Enabled = false;
            this.tbCep.Location = new System.Drawing.Point(534, 235);
            this.tbCep.Mask = "00000-000";
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(84, 20);
            this.tbCep.TabIndex = 5;
            this.tbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Status:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(525, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Telefone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "CPF/CNPJ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome/Razão Social:";
            // 
            // tbCpfcnpj
            // 
            this.tbCpfcnpj.Enabled = false;
            this.tbCpfcnpj.Location = new System.Drawing.Point(565, 262);
            this.tbCpfcnpj.Name = "tbCpfcnpj";
            this.tbCpfcnpj.Size = new System.Drawing.Size(186, 20);
            this.tbCpfcnpj.TabIndex = 8;
            // 
            // tbBairro
            // 
            this.tbBairro.Enabled = false;
            this.tbBairro.Location = new System.Drawing.Point(297, 236);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(194, 20);
            this.tbBairro.TabIndex = 4;
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(677, 210);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(74, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(581, 316);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(170, 20);
            this.tbTelefone.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(297, 316);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(222, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(297, 210);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(321, 20);
            this.tbEndereco.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(297, 184);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(454, 20);
            this.tbNome.TabIndex = 1;
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Enabled = false;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(297, 262);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(194, 21);
            this.cbCidade.TabIndex = 7;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(685, 235);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(66, 21);
            this.cbEstado.TabIndex = 6;
            this.cbEstado.SelectionChangeCommitted += new System.EventHandler(this.cbEstado_SelectionChangeCommitted);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(297, 289);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 9;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.btPesquisarProd);
            this.tabProduto.Controls.Add(this.label20);
            this.tabProduto.Controls.Add(this.tbValorTotalPedido);
            this.tabProduto.Controls.Add(this.btApagar);
            this.tabProduto.Controls.Add(this.dgvItens);
            this.tabProduto.Controls.Add(this.btAdd);
            this.tabProduto.Controls.Add(this.label19);
            this.tabProduto.Controls.Add(this.label18);
            this.tabProduto.Controls.Add(this.label17);
            this.tabProduto.Controls.Add(this.lbNome);
            this.tabProduto.Controls.Add(this.tbValortotal);
            this.tabProduto.Controls.Add(this.tbValor);
            this.tabProduto.Controls.Add(this.tbQuantidade);
            this.tabProduto.Controls.Add(this.tbCodigoProd);
            this.tabProduto.Controls.Add(this.label16);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(912, 439);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // btPesquisarProd
            // 
            this.btPesquisarProd.Location = new System.Drawing.Point(6, 31);
            this.btPesquisarProd.Name = "btPesquisarProd";
            this.btPesquisarProd.Size = new System.Drawing.Size(140, 46);
            this.btPesquisarProd.TabIndex = 20;
            this.btPesquisarProd.Text = "Pesquisar Produto";
            this.btPesquisarProd.UseVisualStyleBackColor = true;
            this.btPesquisarProd.Click += new System.EventHandler(this.btPesquisarProd_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(551, 400);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total do pedido:";
            // 
            // tbValorTotalPedido
            // 
            this.tbValorTotalPedido.Enabled = false;
            this.tbValorTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorTotalPedido.ForeColor = System.Drawing.Color.Red;
            this.tbValorTotalPedido.Location = new System.Drawing.Point(724, 397);
            this.tbValorTotalPedido.Name = "tbValorTotalPedido";
            this.tbValorTotalPedido.Size = new System.Drawing.Size(182, 31);
            this.tbValorTotalPedido.TabIndex = 6;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(798, 55);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 19;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 98);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(900, 288);
            this.dgvItens.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(717, 55);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(519, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Valor total:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(343, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Valor:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(152, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Quantidade:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(343, 34);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // tbValortotal
            // 
            this.tbValortotal.Enabled = false;
            this.tbValortotal.Location = new System.Drawing.Point(582, 57);
            this.tbValortotal.Name = "tbValortotal";
            this.tbValortotal.Size = new System.Drawing.Size(130, 20);
            this.tbValortotal.TabIndex = 17;
            this.tbValortotal.Leave += new System.EventHandler(this.tbValortotal_Leave);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(383, 57);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(114, 20);
            this.tbValor.TabIndex = 16;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(223, 57);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(114, 20);
            this.tbQuantidade.TabIndex = 15;
            this.tbQuantidade.TextChanged += new System.EventHandler(this.tbQuantidade_TextChanged);
            this.tbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantidade_KeyPress);
            // 
            // tbCodigoProd
            // 
            this.tbCodigoProd.Location = new System.Drawing.Point(223, 31);
            this.tbCodigoProd.Name = "tbCodigoProd";
            this.tbCodigoProd.Size = new System.Drawing.Size(114, 20);
            this.tbCodigoProd.TabIndex = 14;
            this.tbCodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProd_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(174, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Código:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(772, 519);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 30);
            this.btCadastrar.TabIndex = 20;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(853, 519);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 30);
            this.btLimpar.TabIndex = 21;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // cadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Name = "cadPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.cadPedido_Load);
            this.tabControl.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.MaskedTextBox tbCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCpfcnpj;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigoProd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbValortotal;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbValorTotalPedido;
        private System.Windows.Forms.Button btPesquisarProd;
    }
}