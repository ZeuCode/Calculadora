
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxPantalla = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnCambiaSigno = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxPantalla
            // 
            this.tBoxPantalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBoxPantalla.Font = new System.Drawing.Font("Arial Narrow", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPantalla.Location = new System.Drawing.Point(0, 0);
            this.tBoxPantalla.Name = "tBoxPantalla";
            this.tBoxPantalla.ReadOnly = true;
            this.tBoxPantalla.Size = new System.Drawing.Size(504, 84);
            this.tBoxPantalla.TabIndex = 0;
            this.tBoxPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxPantalla.TextChanged += new System.EventHandler(this.tBoxPantalla_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPunto, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCero, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCambiaSigno, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSumar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTres, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnUno, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRestar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSeis, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCinco, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCuatro, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btMultiplicar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNueve, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOcho, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSiete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDividir, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRaiz, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCuadrado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInversa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPorcentaje, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnIgual
            // 
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(381, 408);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(120, 76);
            this.btnIgual.TabIndex = 23;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPunto.FlatAppearance.BorderSize = 0;
            this.btnPunto.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(255, 408);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(120, 76);
            this.btnPunto.TabIndex = 22;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCero.FlatAppearance.BorderSize = 0;
            this.btnCero.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(129, 408);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(120, 76);
            this.btnCero.TabIndex = 21;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnCambiaSigno
            // 
            this.btnCambiaSigno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiaSigno.FlatAppearance.BorderSize = 0;
            this.btnCambiaSigno.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiaSigno.Location = new System.Drawing.Point(3, 408);
            this.btnCambiaSigno.Name = "btnCambiaSigno";
            this.btnCambiaSigno.Size = new System.Drawing.Size(120, 76);
            this.btnCambiaSigno.TabIndex = 20;
            this.btnCambiaSigno.Text = "+/-";
            this.btnCambiaSigno.UseVisualStyleBackColor = true;
            this.btnCambiaSigno.Click += new System.EventHandler(this.btnCambiaSigno_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSumar.FlatAppearance.BorderSize = 0;
            this.btnSumar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(381, 327);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(120, 75);
            this.btnSumar.TabIndex = 19;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnTres
            // 
            this.btnTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(255, 327);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(120, 75);
            this.btnTres.TabIndex = 18;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDos.FlatAppearance.BorderSize = 0;
            this.btnDos.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(129, 327);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(120, 75);
            this.btnDos.TabIndex = 17;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUno.FlatAppearance.BorderSize = 0;
            this.btnUno.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(3, 327);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(120, 75);
            this.btnUno.TabIndex = 16;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestar.FlatAppearance.BorderSize = 0;
            this.btnRestar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(381, 246);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(120, 75);
            this.btnRestar.TabIndex = 15;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(255, 246);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(120, 75);
            this.btnSeis.TabIndex = 14;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(129, 246);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(120, 75);
            this.btnCinco.TabIndex = 13;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCuatro.FlatAppearance.BorderSize = 0;
            this.btnCuatro.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(3, 246);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(120, 75);
            this.btnCuatro.TabIndex = 12;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMultiplicar.FlatAppearance.BorderSize = 0;
            this.btMultiplicar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(381, 165);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(120, 75);
            this.btMultiplicar.TabIndex = 11;
            this.btMultiplicar.Text = "x";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNueve.FlatAppearance.BorderSize = 0;
            this.btnNueve.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(255, 165);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(120, 75);
            this.btnNueve.TabIndex = 10;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOcho.FlatAppearance.BorderSize = 0;
            this.btnOcho.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(129, 165);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(120, 75);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiete.FlatAppearance.BorderSize = 0;
            this.btnSiete.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(3, 165);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(120, 75);
            this.btnSiete.TabIndex = 8;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(381, 84);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(120, 75);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaiz.FlatAppearance.BorderSize = 0;
            this.btnRaiz.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(255, 84);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(120, 75);
            this.btnRaiz.TabIndex = 6;
            this.btnRaiz.Text = "√x";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCuadrado.FlatAppearance.BorderSize = 0;
            this.btnCuadrado.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(129, 84);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(120, 75);
            this.btnCuadrado.TabIndex = 5;
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnInversa
            // 
            this.btnInversa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInversa.FlatAppearance.BorderSize = 0;
            this.btnInversa.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversa.Location = new System.Drawing.Point(3, 84);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(120, 75);
            this.btnInversa.TabIndex = 4;
            this.btnInversa.Text = "1/x";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::Calculadora.Properties.Resources.icono_borrar;
            this.btnBorrar.Location = new System.Drawing.Point(381, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 75);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(255, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(120, 75);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(129, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(120, 75);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnPorcentaje.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(3, 3);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(120, 75);
            this.btnPorcentaje.TabIndex = 0;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tBoxPantalla);
            this.MaximumSize = new System.Drawing.Size(620, 710);
            this.MinimumSize = new System.Drawing.Size(520, 610);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxPantalla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnCambiaSigno;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPorcentaje;
    }
}

