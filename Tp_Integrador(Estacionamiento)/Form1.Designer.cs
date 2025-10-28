namespace Tp_Integrador_Estacionamiento_
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
            dtgAutos = new DataGridView();
            label1 = new Label();
            btnAltaEstadia = new Button();
            btnBorrarEstadia = new Button();
            btnModificarEstadia = new Button();
            btnCerrarEstadia = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn13 = new Button();
            btn14 = new Button();
            btn10 = new Button();
            btn6 = new Button();
            btn15 = new Button();
            btn11 = new Button();
            btn7 = new Button();
            btn16 = new Button();
            btn12 = new Button();
            btn8 = new Button();
            btn1 = new Button();
            btnCerrarTurno = new Button();
            btnAbrirTurno = new Button();
            dtgTurnos = new DataGridView();
            label2 = new Label();
            dtgEstadias = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstadias).BeginInit();
            SuspendLayout();
            // 
            // dtgAutos
            // 
            dtgAutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAutos.Location = new Point(175, 38);
            dtgAutos.MultiSelect = false;
            dtgAutos.Name = "dtgAutos";
            dtgAutos.ReadOnly = true;
            dtgAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAutos.Size = new Size(297, 209);
            dtgAutos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Autos en cochera";
            // 
            // btnAltaEstadia
            // 
            btnAltaEstadia.Location = new Point(12, 38);
            btnAltaEstadia.Name = "btnAltaEstadia";
            btnAltaEstadia.Size = new Size(142, 23);
            btnAltaEstadia.TabIndex = 2;
            btnAltaEstadia.Text = "Ingreso";
            btnAltaEstadia.UseVisualStyleBackColor = true;
            btnAltaEstadia.Click += btnAltaEstadia_Click;
            // 
            // btnBorrarEstadia
            // 
            btnBorrarEstadia.Location = new Point(12, 78);
            btnBorrarEstadia.Name = "btnBorrarEstadia";
            btnBorrarEstadia.Size = new Size(142, 23);
            btnBorrarEstadia.TabIndex = 3;
            btnBorrarEstadia.Text = "Borrar ingreso";
            btnBorrarEstadia.UseVisualStyleBackColor = true;
            btnBorrarEstadia.Click += btnBorrarEstadia_Click;
            // 
            // btnModificarEstadia
            // 
            btnModificarEstadia.Location = new Point(12, 116);
            btnModificarEstadia.Name = "btnModificarEstadia";
            btnModificarEstadia.Size = new Size(142, 23);
            btnModificarEstadia.TabIndex = 4;
            btnModificarEstadia.Text = "Modificar ingreso";
            btnModificarEstadia.UseVisualStyleBackColor = true;
            btnModificarEstadia.Click += btnModificarEstadia_Click;
            // 
            // btnCerrarEstadia
            // 
            btnCerrarEstadia.Location = new Point(330, 253);
            btnCerrarEstadia.Name = "btnCerrarEstadia";
            btnCerrarEstadia.Size = new Size(142, 23);
            btnCerrarEstadia.TabIndex = 5;
            btnCerrarEstadia.Text = "Facturar estadia";
            btnCerrarEstadia.UseVisualStyleBackColor = true;
            btnCerrarEstadia.Click += btnCerrarEstadia_Click;
            // 
            // btn2
            // 
            btn2.Enabled = false;
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(49, 166);
            btn2.Name = "btn2";
            btn2.Size = new Size(31, 23);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Enabled = false;
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(86, 166);
            btn3.Name = "btn3";
            btn3.Size = new Size(31, 23);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Enabled = false;
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(123, 166);
            btn4.Name = "btn4";
            btn4.Size = new Size(31, 23);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Enabled = false;
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(12, 195);
            btn5.Name = "btn5";
            btn5.Size = new Size(31, 23);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Enabled = false;
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(12, 224);
            btn9.Name = "btn9";
            btn9.Size = new Size(31, 23);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            btn13.Enabled = false;
            btn13.ForeColor = SystemColors.Control;
            btn13.Location = new Point(12, 253);
            btn13.Name = "btn13";
            btn13.Size = new Size(31, 23);
            btn13.TabIndex = 12;
            btn13.Text = "13";
            btn13.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            btn14.Enabled = false;
            btn14.ForeColor = SystemColors.Control;
            btn14.Location = new Point(49, 253);
            btn14.Name = "btn14";
            btn14.Size = new Size(31, 23);
            btn14.TabIndex = 15;
            btn14.Text = "14";
            btn14.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Enabled = false;
            btn10.ForeColor = SystemColors.Control;
            btn10.Location = new Point(49, 224);
            btn10.Name = "btn10";
            btn10.Size = new Size(31, 23);
            btn10.TabIndex = 14;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Enabled = false;
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(49, 195);
            btn6.Name = "btn6";
            btn6.Size = new Size(31, 23);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            btn15.Enabled = false;
            btn15.ForeColor = SystemColors.Control;
            btn15.Location = new Point(86, 253);
            btn15.Name = "btn15";
            btn15.Size = new Size(31, 23);
            btn15.TabIndex = 18;
            btn15.Text = "15";
            btn15.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Enabled = false;
            btn11.ForeColor = SystemColors.Control;
            btn11.Location = new Point(86, 224);
            btn11.Name = "btn11";
            btn11.Size = new Size(31, 23);
            btn11.TabIndex = 17;
            btn11.Text = "11";
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Enabled = false;
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(86, 195);
            btn7.Name = "btn7";
            btn7.Size = new Size(31, 23);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            btn16.Enabled = false;
            btn16.ForeColor = SystemColors.Control;
            btn16.Location = new Point(123, 253);
            btn16.Name = "btn16";
            btn16.Size = new Size(31, 23);
            btn16.TabIndex = 21;
            btn16.Text = "16";
            btn16.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Enabled = false;
            btn12.ForeColor = SystemColors.Control;
            btn12.Location = new Point(123, 224);
            btn12.Name = "btn12";
            btn12.Size = new Size(31, 23);
            btn12.TabIndex = 20;
            btn12.Text = "12";
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Enabled = false;
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(123, 195);
            btn8.Name = "btn8";
            btn8.Size = new Size(31, 23);
            btn8.TabIndex = 19;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Enabled = false;
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(12, 166);
            btn1.Name = "btn1";
            btn1.Size = new Size(31, 23);
            btn1.TabIndex = 22;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnCerrarTurno
            // 
            btnCerrarTurno.Location = new Point(653, 186);
            btnCerrarTurno.Name = "btnCerrarTurno";
            btnCerrarTurno.Size = new Size(103, 52);
            btnCerrarTurno.TabIndex = 23;
            btnCerrarTurno.Text = "Cerrar turno actual";
            btnCerrarTurno.UseVisualStyleBackColor = true;
            btnCerrarTurno.Click += btnCerrarTurno_Click;
            // 
            // btnAbrirTurno
            // 
            btnAbrirTurno.Location = new Point(544, 186);
            btnAbrirTurno.Name = "btnAbrirTurno";
            btnAbrirTurno.Size = new Size(103, 52);
            btnAbrirTurno.TabIndex = 24;
            btnAbrirTurno.Text = "Abrir turno";
            btnAbrirTurno.UseVisualStyleBackColor = true;
            btnAbrirTurno.Click += btnAbrirTurno_Click;
            // 
            // dtgTurnos
            // 
            dtgTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTurnos.Location = new Point(544, 38);
            dtgTurnos.MultiSelect = false;
            dtgTurnos.Name = "dtgTurnos";
            dtgTurnos.ReadOnly = true;
            dtgTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTurnos.Size = new Size(440, 142);
            dtgTurnos.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 26;
            label2.Text = "Turnos";
            // 
            // dtgEstadias
            // 
            dtgEstadias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstadias.Location = new Point(12, 339);
            dtgEstadias.MultiSelect = false;
            dtgEstadias.Name = "dtgEstadias";
            dtgEstadias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEstadias.Size = new Size(972, 179);
            dtgEstadias.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 312);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 28;
            label3.Text = "Estadias facturadas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 544);
            Controls.Add(label3);
            Controls.Add(dtgEstadias);
            Controls.Add(label2);
            Controls.Add(dtgTurnos);
            Controls.Add(btnAbrirTurno);
            Controls.Add(btnCerrarTurno);
            Controls.Add(btn1);
            Controls.Add(btn16);
            Controls.Add(btn12);
            Controls.Add(btn8);
            Controls.Add(btn15);
            Controls.Add(btn11);
            Controls.Add(btn7);
            Controls.Add(btn14);
            Controls.Add(btn10);
            Controls.Add(btn6);
            Controls.Add(btn13);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnCerrarEstadia);
            Controls.Add(btnModificarEstadia);
            Controls.Add(btnBorrarEstadia);
            Controls.Add(btnAltaEstadia);
            Controls.Add(label1);
            Controls.Add(dtgAutos);
            Name = "Form1";
            Text = "Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)dtgAutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstadias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgAutos;
        private Label label1;
        private Button btnAltaEstadia;
        private Button btnBorrarEstadia;
        private Button btnModificarEstadia;
        private Button btnCerrarEstadia;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn9;
        private Button btn13;
        private Button btn14;
        private Button btn10;
        private Button btn6;
        private Button btn15;
        private Button btn11;
        private Button btn7;
        private Button btn16;
        private Button btn12;
        private Button btn8;
        private Button btn1;
        private Button btnCerrarTurno;
        private Button btnAbrirTurno;
        private DataGridView dtgTurnos;
        private Label label2;
        private DataGridView dtgEstadias;
        private Label label3;
    }
}
