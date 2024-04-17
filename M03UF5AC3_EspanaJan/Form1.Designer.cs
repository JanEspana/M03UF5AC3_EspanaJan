namespace M03UF5AC3_EspanaJan
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            total = new TextBox();
            consumDomestic = new TextBox();
            activitats = new TextBox();
            domesticXarxa = new TextBox();
            population = new TextBox();
            comarca = new ComboBox();
            year = new ComboBox();
            groupBox2 = new GroupBox();
            lowerCons = new Label();
            higherCons = new Label();
            avgConsum = new Label();
            morethan20000 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveEntry = new Button();
            clean = new Button();
            grid = new DataGridView();
            errorAny = new ErrorProvider(components);
            errorComarca = new ErrorProvider(components);
            errorPoblacio = new ErrorProvider(components);
            errorXarxa = new ErrorProvider(components);
            errorActivitats = new ErrorProvider(components);
            errorConsumCapita = new ErrorProvider(components);
            errorTotal = new ErrorProvider(components);
            persistButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorComarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPoblacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorXarxa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorActivitats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorConsumCapita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTotal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(total);
            groupBox1.Controls.Add(consumDomestic);
            groupBox1.Controls.Add(activitats);
            groupBox1.Controls.Add(domesticXarxa);
            groupBox1.Controls.Add(population);
            groupBox1.Controls.Add(comarca);
            groupBox1.Controls.Add(year);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(313, 174);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 14;
            label13.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(313, 139);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 13;
            label12.Text = "per càpita";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(270, 124);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 12;
            label11.Text = "Consum domèstic";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(147, 156);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 11;
            label10.Text = "i fonts pròpies";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(147, 141);
            label9.Name = "label9";
            label9.Size = new Size(137, 15);
            label9.TabIndex = 10;
            label9.Text = "Activitats econòmiques";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(27, 151);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 9;
            label8.Text = "Domèstic xarxa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(220, 47);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 8;
            label7.Text = "Població";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(110, 47);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 7;
            label6.Text = "Comarca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(27, 47);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "Any";
            // 
            // total
            // 
            total.Location = new Point(381, 171);
            total.Name = "total";
            total.Size = new Size(100, 23);
            total.TabIndex = 6;
            // 
            // consumDomestic
            // 
            consumDomestic.Location = new Point(381, 124);
            consumDomestic.Name = "consumDomestic";
            consumDomestic.Size = new Size(100, 23);
            consumDomestic.TabIndex = 5;
            // 
            // activitats
            // 
            activitats.Location = new Point(147, 171);
            activitats.Name = "activitats";
            activitats.Size = new Size(126, 23);
            activitats.TabIndex = 4;
            // 
            // domesticXarxa
            // 
            domesticXarxa.Location = new Point(27, 171);
            domesticXarxa.Name = "domesticXarxa";
            domesticXarxa.Size = new Size(100, 23);
            domesticXarxa.TabIndex = 3;
            // 
            // population
            // 
            population.Location = new Point(220, 65);
            population.Name = "population";
            population.Size = new Size(100, 23);
            population.TabIndex = 2;
            // 
            // comarca
            // 
            comarca.FormattingEnabled = true;
            comarca.Location = new Point(110, 65);
            comarca.Name = "comarca";
            comarca.Size = new Size(89, 23);
            comarca.TabIndex = 1;
            // 
            // year
            // 
            year.FormattingEnabled = true;
            year.Location = new Point(27, 65);
            year.Name = "year";
            year.Size = new Size(61, 23);
            year.TabIndex = 0;
            year.SelectedIndexChanged += year_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lowerCons);
            groupBox2.Controls.Add(higherCons);
            groupBox2.Controls.Add(avgConsum);
            groupBox2.Controls.Add(morethan20000);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(539, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 166);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // lowerCons
            // 
            lowerCons.AutoSize = true;
            lowerCons.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowerCons.ForeColor = SystemColors.MenuHighlight;
            lowerCons.Location = new Point(240, 124);
            lowerCons.Name = "lowerCons";
            lowerCons.Size = new Size(12, 15);
            lowerCons.TabIndex = 7;
            lowerCons.Text = "?";
            // 
            // higherCons
            // 
            higherCons.AutoSize = true;
            higherCons.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            higherCons.ForeColor = SystemColors.MenuHighlight;
            higherCons.Location = new Point(231, 94);
            higherCons.Name = "higherCons";
            higherCons.Size = new Size(12, 15);
            higherCons.TabIndex = 6;
            higherCons.Text = "?";
            // 
            // avgConsum
            // 
            avgConsum.AutoSize = true;
            avgConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avgConsum.ForeColor = SystemColors.MenuHighlight;
            avgConsum.Location = new Point(161, 65);
            avgConsum.Name = "avgConsum";
            avgConsum.Size = new Size(12, 15);
            avgConsum.TabIndex = 5;
            avgConsum.Text = "?";
            // 
            // morethan20000
            // 
            morethan20000.AutoSize = true;
            morethan20000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            morethan20000.ForeColor = SystemColors.MenuHighlight;
            morethan20000.Location = new Point(153, 35);
            morethan20000.Name = "morethan20000";
            morethan20000.Size = new Size(12, 15);
            morethan20000.TabIndex = 4;
            morethan20000.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 124);
            label3.Name = "label3";
            label3.Size = new Size(218, 15);
            label3.TabIndex = 3;
            label3.Text = "Consum domèstic per càpita més baix:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 94);
            label4.Name = "label4";
            label4.Size = new Size(209, 15);
            label4.TabIndex = 2;
            label4.Text = "Consum domèstic per càpita més alt:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 1;
            label2.Text = "Consum domèstic mitjà:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Població > 20000 hab.:";
            // 
            // saveEntry
            // 
            saveEntry.Location = new Point(539, 183);
            saveEntry.Name = "saveEntry";
            saveEntry.Size = new Size(147, 39);
            saveEntry.TabIndex = 2;
            saveEntry.Text = "Agrega";
            saveEntry.UseVisualStyleBackColor = true;
            saveEntry.Click += saveEntry_Click;
            // 
            // clean
            // 
            clean.Location = new Point(539, 228);
            clean.Name = "clean";
            clean.Size = new Size(147, 39);
            clean.TabIndex = 3;
            clean.Text = "Neteja";
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(26, 273);
            grid.Name = "grid";
            grid.Size = new Size(813, 263);
            grid.TabIndex = 4;
            grid.CellClick += grid_CellClick;
            // 
            // errorAny
            // 
            errorAny.ContainerControl = this;
            // 
            // errorComarca
            // 
            errorComarca.ContainerControl = this;
            // 
            // errorPoblacio
            // 
            errorPoblacio.ContainerControl = this;
            // 
            // errorXarxa
            // 
            errorXarxa.ContainerControl = this;
            // 
            // errorActivitats
            // 
            errorActivitats.ContainerControl = this;
            // 
            // errorConsumCapita
            // 
            errorConsumCapita.ContainerControl = this;
            // 
            // errorTotal
            // 
            errorTotal.ContainerControl = this;
            // 
            // persistButton
            // 
            persistButton.Location = new Point(706, 206);
            persistButton.Name = "persistButton";
            persistButton.Size = new Size(147, 39);
            persistButton.TabIndex = 5;
            persistButton.Text = "Persistir";
            persistButton.UseVisualStyleBackColor = true;
            persistButton.Click += persistButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 548);
            Controls.Add(persistButton);
            Controls.Add(grid);
            Controls.Add(clean);
            Controls.Add(saveEntry);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAny).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorComarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPoblacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorXarxa).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorActivitats).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorConsumCapita).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTotal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private ComboBox comarca;
        private ComboBox year;
        private Button saveEntry;
        private Button clean;
        private DataGridView grid;
        private Label label6;
        private Label label5;
        private TextBox total;
        private TextBox consumDomestic;
        private TextBox activitats;
        private TextBox domesticXarxa;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label lowerCons;
        private Label higherCons;
        private Label avgConsum;
        private Label morethan20000;
        private ErrorProvider errorAny;
        private ErrorProvider errorComarca;
        private ErrorProvider errorPoblacio;
        private ErrorProvider errorXarxa;
        private ErrorProvider errorActivitats;
        private ErrorProvider errorConsumCapita;
        private ErrorProvider errorTotal;
        private TextBox population;
        private Button persistButton;
    }
}
