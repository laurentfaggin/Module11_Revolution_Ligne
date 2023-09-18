namespace POOII_Module11_Revolution_Lignes
{
    partial class fRevolutionDesLignes
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
            this.nudLongueurDepart = new System.Windows.Forms.NumericUpDown();
            this.pControles = new System.Windows.Forms.Panel();
            this.btnDessiner = new System.Windows.Forms.Button();
            this.nudPasLongueur = new System.Windows.Forms.NumericUpDown();
            this.lbPas = new System.Windows.Forms.Label();
            this.nudNombreLignes = new System.Windows.Forms.NumericUpDown();
            this.lbNombreLignes = new System.Windows.Forms.Label();
            this.lbLongueurDepart = new System.Windows.Forms.Label();
            this.nudPasAngle = new System.Windows.Forms.NumericUpDown();
            this.lbAngle = new System.Windows.Forms.Label();
            this.pCanvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).BeginInit();
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLongueurDepart
            // 
            this.nudLongueurDepart.Location = new System.Drawing.Point(249, 15);
            this.nudLongueurDepart.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLongueurDepart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongueurDepart.Name = "nudLongueurDepart";
            this.nudLongueurDepart.Size = new System.Drawing.Size(50, 27);
            this.nudLongueurDepart.TabIndex = 3;
            this.nudLongueurDepart.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pControles
            // 
            this.pControles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pControles.Controls.Add(this.btnDessiner);
            this.pControles.Controls.Add(this.nudPasLongueur);
            this.pControles.Controls.Add(this.lbPas);
            this.pControles.Controls.Add(this.nudNombreLignes);
            this.pControles.Controls.Add(this.lbNombreLignes);
            this.pControles.Controls.Add(this.nudLongueurDepart);
            this.pControles.Controls.Add(this.lbLongueurDepart);
            this.pControles.Controls.Add(this.nudPasAngle);
            this.pControles.Controls.Add(this.lbAngle);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(800, 61);
            this.pControles.TabIndex = 2;
            // 
            // btnDessiner
            // 
            this.btnDessiner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDessiner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDessiner.Location = new System.Drawing.Point(621, 17);
            this.btnDessiner.Name = "btnDessiner";
            this.btnDessiner.Size = new System.Drawing.Size(111, 25);
            this.btnDessiner.TabIndex = 8;
            this.btnDessiner.Text = "Dessiner";
            this.btnDessiner.UseVisualStyleBackColor = false;
            // 
            // nudPasLongueur
            // 
            this.nudPasLongueur.Location = new System.Drawing.Point(542, 15);
            this.nudPasLongueur.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPasLongueur.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudPasLongueur.Name = "nudPasLongueur";
            this.nudPasLongueur.Size = new System.Drawing.Size(49, 27);
            this.nudPasLongueur.TabIndex = 7;
            // 
            // lbPas
            // 
            this.lbPas.AutoSize = true;
            this.lbPas.Location = new System.Drawing.Point(506, 17);
            this.lbPas.Name = "lbPas";
            this.lbPas.Size = new System.Drawing.Size(30, 20);
            this.lbPas.TabIndex = 6;
            this.lbPas.Text = "Pas";
            // 
            // nudNombreLignes
            // 
            this.nudNombreLignes.Location = new System.Drawing.Point(439, 15);
            this.nudNombreLignes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNombreLignes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNombreLignes.Name = "nudNombreLignes";
            this.nudNombreLignes.Size = new System.Drawing.Size(52, 27);
            this.nudNombreLignes.TabIndex = 5;
            this.nudNombreLignes.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lbNombreLignes
            // 
            this.lbNombreLignes.AutoSize = true;
            this.lbNombreLignes.Location = new System.Drawing.Point(305, 17);
            this.lbNombreLignes.Name = "lbNombreLignes";
            this.lbNombreLignes.Size = new System.Drawing.Size(128, 20);
            this.lbNombreLignes.TabIndex = 4;
            this.lbNombreLignes.Text = "Nombre de lignes";
            // 
            // lbLongueurDepart
            // 
            this.lbLongueurDepart.AutoSize = true;
            this.lbLongueurDepart.Location = new System.Drawing.Point(124, 17);
            this.lbLongueurDepart.Name = "lbLongueurDepart";
            this.lbLongueurDepart.Size = new System.Drawing.Size(119, 20);
            this.lbLongueurDepart.TabIndex = 2;
            this.lbLongueurDepart.Text = "Longueur depart";
            // 
            // nudPasAngle
            // 
            this.nudPasAngle.Location = new System.Drawing.Point(66, 15);
            this.nudPasAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudPasAngle.Name = "nudPasAngle";
            this.nudPasAngle.Size = new System.Drawing.Size(52, 27);
            this.nudPasAngle.TabIndex = 1;
            this.nudPasAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lbAngle
            // 
            this.lbAngle.AutoSize = true;
            this.lbAngle.Location = new System.Drawing.Point(12, 17);
            this.lbAngle.Name = "lbAngle";
            this.lbAngle.Size = new System.Drawing.Size(48, 20);
            this.lbAngle.TabIndex = 0;
            this.lbAngle.Text = "Angle";
            // 
            // pCanvas
            // 
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCanvas.Location = new System.Drawing.Point(0, 0);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(800, 450);
            this.pCanvas.TabIndex = 3;
            // 
            // fRevolutionDesLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pControles);
            this.Controls.Add(this.pCanvas);
            this.Name = "fRevolutionDesLignes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).EndInit();
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown nudLongueurDepart;
        private Panel pControles;
        private Button btnDessiner;
        private NumericUpDown nudPasLongueur;
        private Label lbPas;
        private NumericUpDown nudNombreLignes;
        private Label lbNombreLignes;
        private Label lbLongueurDepart;
        private NumericUpDown nudPasAngle;
        private Label lbAngle;
        private Panel pCanvas;
    }
}