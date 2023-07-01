namespace _00_PRESENTACION_WINFORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NombreLabel = new Label();
            ApellidoLabel = new Label();
            EmailLabel = new Label();
            NombreTextBox = new TextBox();
            ApellidoTextBox = new TextBox();
            EmailTextBox = new TextBox();
            AgregarClienteBtn = new Button();
            EliminarClienteBtn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            BuscarBtn = new Button();
            IdTextBox = new TextBox();
            IdLabel = new Label();
            ActualizarEmailBtn = new Button();
            dbLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            EntityFrameworkBtn = new Button();
            MongoDBBtn = new Button();
            button2 = new Button();
            SQLServerBtn = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NombreLabel.Location = new Point(204, 113);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(64, 27);
            NombreLabel.TabIndex = 1;
            NombreLabel.Text = "Nombre";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApellidoLabel.ForeColor = SystemColors.ControlText;
            ApellidoLabel.Location = new Point(204, 156);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(65, 27);
            ApellidoLabel.TabIndex = 2;
            ApellidoLabel.Text = "Apellido";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(204, 199);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(48, 27);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NombreTextBox.Location = new Point(312, 108);
            NombreTextBox.Margin = new Padding(3, 2, 3, 2);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(476, 39);
            NombreTextBox.TabIndex = 3;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ApellidoTextBox.Location = new Point(312, 151);
            ApellidoTextBox.Margin = new Padding(3, 2, 3, 2);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(476, 39);
            ApellidoTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(312, 194);
            EmailTextBox.Margin = new Padding(3, 2, 3, 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(476, 39);
            EmailTextBox.TabIndex = 5;
            // 
            // AgregarClienteBtn
            // 
            AgregarClienteBtn.BackColor = Color.DarkSalmon;
            AgregarClienteBtn.FlatAppearance.BorderSize = 0;
            AgregarClienteBtn.Location = new Point(204, 253);
            AgregarClienteBtn.Margin = new Padding(3, 2, 3, 2);
            AgregarClienteBtn.Name = "AgregarClienteBtn";
            AgregarClienteBtn.Size = new Size(119, 28);
            AgregarClienteBtn.TabIndex = 5;
            AgregarClienteBtn.Text = "Agregar";
            AgregarClienteBtn.UseVisualStyleBackColor = false;
            AgregarClienteBtn.Click += AgregarClienteBtn_Click;
            // 
            // EliminarClienteBtn
            // 
            EliminarClienteBtn.BackColor = Color.DarkSalmon;
            EliminarClienteBtn.Location = new Point(439, 253);
            EliminarClienteBtn.Margin = new Padding(3, 2, 3, 2);
            EliminarClienteBtn.Name = "EliminarClienteBtn";
            EliminarClienteBtn.Size = new Size(119, 28);
            EliminarClienteBtn.TabIndex = 7;
            EliminarClienteBtn.Text = "Eliminar";
            EliminarClienteBtn.UseVisualStyleBackColor = false;
            EliminarClienteBtn.Click += EliminarClienteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(808, 65);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(583, 406);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(0, 0);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 23);
            BuscarBtn.TabIndex = 24;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Dubai", 14F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(312, 65);
            IdTextBox.Margin = new Padding(3, 2, 3, 2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(476, 39);
            IdTextBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(204, 75);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 27);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "Id";
            // 
            // ActualizarEmailBtn
            // 
            ActualizarEmailBtn.BackColor = Color.DarkSalmon;
            ActualizarEmailBtn.Location = new Point(669, 253);
            ActualizarEmailBtn.Margin = new Padding(3, 2, 3, 2);
            ActualizarEmailBtn.Name = "ActualizarEmailBtn";
            ActualizarEmailBtn.Size = new Size(119, 28);
            ActualizarEmailBtn.TabIndex = 14;
            ActualizarEmailBtn.Text = "Actualizar Email";
            ActualizarEmailBtn.UseVisualStyleBackColor = false;
            ActualizarEmailBtn.Click += ActualizarEmailBtn_Click;
            // 
            // dbLabel
            // 
            dbLabel.AutoSize = true;
            dbLabel.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dbLabel.Location = new Point(60, 42);
            dbLabel.Name = "dbLabel";
            dbLabel.Size = new Size(54, 29);
            dbLabel.TabIndex = 18;
            dbLabel.Text = "SQL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Colonna MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 19;
            label1.Text = "Base de Datos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(EntityFrameworkBtn);
            panel1.Controls.Add(MongoDBBtn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(SQLServerBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 541);
            panel1.TabIndex = 20;
            // 
            // EntityFrameworkBtn
            // 
            EntityFrameworkBtn.BackColor = Color.Transparent;
            EntityFrameworkBtn.Cursor = Cursors.Hand;
            EntityFrameworkBtn.Dock = DockStyle.Top;
            EntityFrameworkBtn.FlatAppearance.BorderSize = 0;
            EntityFrameworkBtn.FlatStyle = FlatStyle.Flat;
            EntityFrameworkBtn.Font = new Font("Copperplate Gothic Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EntityFrameworkBtn.Location = new Point(0, 188);
            EntityFrameworkBtn.Margin = new Padding(3, 2, 3, 2);
            EntityFrameworkBtn.Name = "EntityFrameworkBtn";
            EntityFrameworkBtn.Padding = new Padding(10, 0, 0, 0);
            EntityFrameworkBtn.Size = new Size(187, 44);
            EntityFrameworkBtn.TabIndex = 25;
            EntityFrameworkBtn.Text = "> Entity \nFramework";
            EntityFrameworkBtn.TextAlign = ContentAlignment.MiddleLeft;
            EntityFrameworkBtn.UseVisualStyleBackColor = false;
            EntityFrameworkBtn.Click += EntityFrameworkBtn_Click_1;
            // 
            // MongoDBBtn
            // 
            MongoDBBtn.BackColor = Color.Transparent;
            MongoDBBtn.Cursor = Cursors.Hand;
            MongoDBBtn.Dock = DockStyle.Top;
            MongoDBBtn.FlatAppearance.BorderSize = 0;
            MongoDBBtn.FlatStyle = FlatStyle.Flat;
            MongoDBBtn.Font = new Font("Copperplate Gothic Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MongoDBBtn.Location = new Point(0, 144);
            MongoDBBtn.Margin = new Padding(3, 2, 3, 2);
            MongoDBBtn.Name = "MongoDBBtn";
            MongoDBBtn.Padding = new Padding(10, 0, 0, 0);
            MongoDBBtn.Size = new Size(187, 44);
            MongoDBBtn.TabIndex = 24;
            MongoDBBtn.Text = "> MongoDB";
            MongoDBBtn.TextAlign = ContentAlignment.MiddleLeft;
            MongoDBBtn.UseVisualStyleBackColor = false;
            MongoDBBtn.Click += MongoDBBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(24, 180);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(119, 28);
            button2.TabIndex = 23;
            button2.Text = "NoSQL";
            button2.UseVisualStyleBackColor = false;
            // 
            // SQLServerBtn
            // 
            SQLServerBtn.BackColor = Color.Transparent;
            SQLServerBtn.Cursor = Cursors.Hand;
            SQLServerBtn.Dock = DockStyle.Top;
            SQLServerBtn.FlatAppearance.BorderSize = 0;
            SQLServerBtn.FlatStyle = FlatStyle.Flat;
            SQLServerBtn.Font = new Font("Copperplate Gothic Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SQLServerBtn.Location = new Point(0, 100);
            SQLServerBtn.Margin = new Padding(3, 2, 3, 2);
            SQLServerBtn.Name = "SQLServerBtn";
            SQLServerBtn.Padding = new Padding(10, 0, 0, 0);
            SQLServerBtn.Size = new Size(187, 44);
            SQLServerBtn.TabIndex = 22;
            SQLServerBtn.Text = "> SQL Server";
            SQLServerBtn.TextAlign = ContentAlignment.MiddleLeft;
            SQLServerBtn.UseVisualStyleBackColor = false;
            SQLServerBtn.Click += SQLServerBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dbLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 100);
            panel2.TabIndex = 21;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(406, 21);
            label2.Name = "label2";
            label2.Size = new Size(195, 29);
            label2.TabIndex = 21;
            label2.Text = "Registro - Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1039, 21);
            label3.Name = "label3";
            label3.Size = new Size(62, 29);
            label3.TabIndex = 22;
            label3.Text = "Vista";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(204, 458);
            label4.Name = "label4";
            label4.Size = new Size(551, 13);
            label4.TabIndex = 23;
            label4.Text = "* Para actualizar email, por favor, indique el Id (como se muestra en la tabla) y la nueva dirección de correo electrónico.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 541);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(ActualizarEmailBtn);
            Controls.Add(IdTextBox);
            Controls.Add(IdLabel);
            Controls.Add(BuscarBtn);
            Controls.Add(dataGridView1);
            Controls.Add(EliminarClienteBtn);
            Controls.Add(AgregarClienteBtn);
            Controls.Add(EmailTextBox);
            Controls.Add(ApellidoTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(ApellidoLabel);
            Controls.Add(NombreLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Clinica Veterinaria";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NombreLabel;
        private Label ApellidoLabel;
        private Label EmailLabel;
        private TextBox NombreTextBox;
        private TextBox ApellidoTextBox;
        private TextBox EmailTextBox;
        private Button AgregarClienteBtn;
        private Button ActualizarNombreBtn;
        private Button EliminarClienteBtn;
        private DataGridView dataGridView1;
        private Button BuscarBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox IdTextBox;
        private Label IdLabel;
        private Button ActualizarEmailBtn;
        private Label dbLabel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button EntityFrameworkBtn;
        private Button MongoDBBtn;
        private Button button2;
        private Button SQLServerBtn;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
