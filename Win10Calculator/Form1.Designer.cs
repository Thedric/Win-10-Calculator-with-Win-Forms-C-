
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.RESULTbutton = new System.Windows.Forms.Button();
            this.DOTbutton = new System.Windows.Forms.Button();
            this.ZERObutton = new System.Windows.Forms.Button();
            this.DIVINVERSbutton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.THREEbutton = new System.Windows.Forms.Button();
            this.TWObutton = new System.Windows.Forms.Button();
            this.ONEbutton = new System.Windows.Forms.Button();
            this.SUBbutton = new System.Windows.Forms.Button();
            this.SIXbutton = new System.Windows.Forms.Button();
            this.FIVEbutton = new System.Windows.Forms.Button();
            this.FOURbutton = new System.Windows.Forms.Button();
            this.MULTbutton = new System.Windows.Forms.Button();
            this.NINEbutton = new System.Windows.Forms.Button();
            this.EIGHTbutton = new System.Windows.Forms.Button();
            this.SEVENbutton = new System.Windows.Forms.Button();
            this.DIVIDEbutton = new System.Windows.Forms.Button();
            this.DELbutton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Table1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(15, 29);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(358, 27);
            this.UserInput.TabIndex = 0;
            this.UserInput.Text = "0";
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(15, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(358, 17);
            this.Label1.TabIndex = 1;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Table1
            // 
            this.Table1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table1.BackColor = System.Drawing.Color.DimGray;
            this.Table1.ColumnCount = 4;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.Table1.Controls.Add(this.RESULTbutton, 3, 4);
            this.Table1.Controls.Add(this.DOTbutton, 2, 4);
            this.Table1.Controls.Add(this.ZERObutton, 1, 4);
            this.Table1.Controls.Add(this.DIVINVERSbutton, 0, 4);
            this.Table1.Controls.Add(this.ADDbutton, 3, 3);
            this.Table1.Controls.Add(this.THREEbutton, 2, 3);
            this.Table1.Controls.Add(this.TWObutton, 1, 3);
            this.Table1.Controls.Add(this.ONEbutton, 0, 3);
            this.Table1.Controls.Add(this.SUBbutton, 3, 2);
            this.Table1.Controls.Add(this.SIXbutton, 2, 2);
            this.Table1.Controls.Add(this.FIVEbutton, 1, 2);
            this.Table1.Controls.Add(this.FOURbutton, 0, 2);
            this.Table1.Controls.Add(this.MULTbutton, 3, 1);
            this.Table1.Controls.Add(this.NINEbutton, 2, 1);
            this.Table1.Controls.Add(this.EIGHTbutton, 1, 1);
            this.Table1.Controls.Add(this.SEVENbutton, 0, 1);
            this.Table1.Controls.Add(this.DIVIDEbutton, 3, 0);
            this.Table1.Controls.Add(this.DELbutton, 2, 0);
            this.Table1.Controls.Add(this.CEbutton, 1, 0);
            this.Table1.Controls.Add(this.textBox1, 0, 0);
            this.Table1.Location = new System.Drawing.Point(12, 62);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 5;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table1.Size = new System.Drawing.Size(361, 317);
            this.Table1.TabIndex = 2;
            // 
            // RESULTbutton
            // 
            this.RESULTbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.RESULTbutton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.RESULTbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RESULTbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RESULTbutton.Location = new System.Drawing.Point(273, 255);
            this.RESULTbutton.Name = "RESULTbutton";
            this.RESULTbutton.Size = new System.Drawing.Size(85, 59);
            this.RESULTbutton.TabIndex = 19;
            this.RESULTbutton.Text = "=";
            this.RESULTbutton.UseVisualStyleBackColor = false;
            this.RESULTbutton.Click += new System.EventHandler(this.RESULTbutton_Click);
            // 
            // DOTbutton
            // 
            this.DOTbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOTbutton.Location = new System.Drawing.Point(183, 255);
            this.DOTbutton.Name = "DOTbutton";
            this.DOTbutton.Size = new System.Drawing.Size(84, 59);
            this.DOTbutton.TabIndex = 18;
            this.DOTbutton.Text = ".";
            this.DOTbutton.UseVisualStyleBackColor = true;
            this.DOTbutton.Click += new System.EventHandler(this.DOTbutton_Click);
            // 
            // ZERObutton
            // 
            this.ZERObutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZERObutton.Location = new System.Drawing.Point(93, 255);
            this.ZERObutton.Name = "ZERObutton";
            this.ZERObutton.Size = new System.Drawing.Size(84, 59);
            this.ZERObutton.TabIndex = 17;
            this.ZERObutton.Text = "0";
            this.ZERObutton.UseVisualStyleBackColor = true;
            this.ZERObutton.Click += new System.EventHandler(this.ZERObutton_Click);
            // 
            // DIVINVERSbutton
            // 
            this.DIVINVERSbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DIVINVERSbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIVINVERSbutton.Location = new System.Drawing.Point(3, 255);
            this.DIVINVERSbutton.Name = "DIVINVERSbutton";
            this.DIVINVERSbutton.Size = new System.Drawing.Size(84, 59);
            this.DIVINVERSbutton.TabIndex = 16;
            this.DIVINVERSbutton.Text = "1/x";
            this.DIVINVERSbutton.UseVisualStyleBackColor = true;
            this.DIVINVERSbutton.Click += new System.EventHandler(this.DIVINVERSECbutton_Click);
            // 
            // ADDbutton
            // 
            this.ADDbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADDbutton.Location = new System.Drawing.Point(273, 192);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(85, 57);
            this.ADDbutton.TabIndex = 15;
            this.ADDbutton.Text = "+";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // THREEbutton
            // 
            this.THREEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.THREEbutton.Location = new System.Drawing.Point(183, 192);
            this.THREEbutton.Name = "THREEbutton";
            this.THREEbutton.Size = new System.Drawing.Size(84, 57);
            this.THREEbutton.TabIndex = 14;
            this.THREEbutton.Text = "3";
            this.THREEbutton.UseVisualStyleBackColor = true;
            this.THREEbutton.Click += new System.EventHandler(this.THREEbutton_Click);
            // 
            // TWObutton
            // 
            this.TWObutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWObutton.Location = new System.Drawing.Point(93, 192);
            this.TWObutton.Name = "TWObutton";
            this.TWObutton.Size = new System.Drawing.Size(84, 57);
            this.TWObutton.TabIndex = 13;
            this.TWObutton.Text = "2";
            this.TWObutton.UseVisualStyleBackColor = true;
            this.TWObutton.Click += new System.EventHandler(this.TWObutton_Click);
            // 
            // ONEbutton
            // 
            this.ONEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ONEbutton.Location = new System.Drawing.Point(3, 192);
            this.ONEbutton.Name = "ONEbutton";
            this.ONEbutton.Size = new System.Drawing.Size(84, 57);
            this.ONEbutton.TabIndex = 12;
            this.ONEbutton.Text = "1";
            this.ONEbutton.UseVisualStyleBackColor = true;
            this.ONEbutton.Click += new System.EventHandler(this.ONEbutton_Click);
            // 
            // SUBbutton
            // 
            this.SUBbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUBbutton.Location = new System.Drawing.Point(273, 129);
            this.SUBbutton.Name = "SUBbutton";
            this.SUBbutton.Size = new System.Drawing.Size(85, 57);
            this.SUBbutton.TabIndex = 11;
            this.SUBbutton.Text = "—";
            this.SUBbutton.UseVisualStyleBackColor = true;
            this.SUBbutton.Click += new System.EventHandler(this.SUBbutton_Click);
            // 
            // SIXbutton
            // 
            this.SIXbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SIXbutton.Location = new System.Drawing.Point(183, 129);
            this.SIXbutton.Name = "SIXbutton";
            this.SIXbutton.Size = new System.Drawing.Size(84, 57);
            this.SIXbutton.TabIndex = 10;
            this.SIXbutton.Text = "6";
            this.SIXbutton.UseVisualStyleBackColor = true;
            this.SIXbutton.Click += new System.EventHandler(this.SIXbutton_Click);
            // 
            // FIVEbutton
            // 
            this.FIVEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FIVEbutton.Location = new System.Drawing.Point(93, 129);
            this.FIVEbutton.Name = "FIVEbutton";
            this.FIVEbutton.Size = new System.Drawing.Size(84, 57);
            this.FIVEbutton.TabIndex = 9;
            this.FIVEbutton.Text = "5";
            this.FIVEbutton.UseVisualStyleBackColor = true;
            this.FIVEbutton.Click += new System.EventHandler(this.FIVEbutton_Click);
            // 
            // FOURbutton
            // 
            this.FOURbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOURbutton.Location = new System.Drawing.Point(3, 129);
            this.FOURbutton.Name = "FOURbutton";
            this.FOURbutton.Size = new System.Drawing.Size(84, 57);
            this.FOURbutton.TabIndex = 8;
            this.FOURbutton.Text = "4";
            this.FOURbutton.UseVisualStyleBackColor = true;
            this.FOURbutton.Click += new System.EventHandler(this.FOURbutton_Click);
            // 
            // MULTbutton
            // 
            this.MULTbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MULTbutton.Location = new System.Drawing.Point(273, 66);
            this.MULTbutton.Name = "MULTbutton";
            this.MULTbutton.Size = new System.Drawing.Size(85, 57);
            this.MULTbutton.TabIndex = 7;
            this.MULTbutton.Text = "X";
            this.MULTbutton.UseVisualStyleBackColor = true;
            this.MULTbutton.Click += new System.EventHandler(this.MULTbutton_Click);
            // 
            // NINEbutton
            // 
            this.NINEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NINEbutton.Location = new System.Drawing.Point(183, 66);
            this.NINEbutton.Name = "NINEbutton";
            this.NINEbutton.Size = new System.Drawing.Size(84, 57);
            this.NINEbutton.TabIndex = 6;
            this.NINEbutton.Text = "9";
            this.NINEbutton.UseVisualStyleBackColor = true;
            this.NINEbutton.Click += new System.EventHandler(this.NINEbutton_Click);
            // 
            // EIGHTbutton
            // 
            this.EIGHTbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EIGHTbutton.Location = new System.Drawing.Point(93, 66);
            this.EIGHTbutton.Name = "EIGHTbutton";
            this.EIGHTbutton.Size = new System.Drawing.Size(84, 57);
            this.EIGHTbutton.TabIndex = 5;
            this.EIGHTbutton.Text = "8";
            this.EIGHTbutton.UseVisualStyleBackColor = true;
            this.EIGHTbutton.Click += new System.EventHandler(this.EIGHTbutton_Click);
            // 
            // SEVENbutton
            // 
            this.SEVENbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SEVENbutton.Location = new System.Drawing.Point(3, 66);
            this.SEVENbutton.Name = "SEVENbutton";
            this.SEVENbutton.Size = new System.Drawing.Size(84, 57);
            this.SEVENbutton.TabIndex = 4;
            this.SEVENbutton.Text = "7";
            this.SEVENbutton.UseVisualStyleBackColor = true;
            this.SEVENbutton.Click += new System.EventHandler(this.SEVENbutton_Click);
            // 
            // DIVIDEbutton
            // 
            this.DIVIDEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DIVIDEbutton.Location = new System.Drawing.Point(273, 3);
            this.DIVIDEbutton.Name = "DIVIDEbutton";
            this.DIVIDEbutton.Size = new System.Drawing.Size(85, 57);
            this.DIVIDEbutton.TabIndex = 3;
            this.DIVIDEbutton.Text = "/";
            this.DIVIDEbutton.UseVisualStyleBackColor = true;
            this.DIVIDEbutton.Click += new System.EventHandler(this.DIVIDEbutton_Click);
            // 
            // DELbutton
            // 
            this.DELbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DELbutton.Location = new System.Drawing.Point(183, 3);
            this.DELbutton.Name = "DELbutton";
            this.DELbutton.Size = new System.Drawing.Size(84, 57);
            this.DELbutton.TabIndex = 2;
            this.DELbutton.Text = "DEL";
            this.DELbutton.UseVisualStyleBackColor = true;
            this.DELbutton.Click += new System.EventHandler(this.DELbutton_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(93, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(84, 57);
            this.CEbutton.TabIndex = 20;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 27);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Mikail";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.RESULTbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(385, 384);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UserInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(403, 431);
            this.Name = "Form1";
            this.Text = "Calculator by Mika Shah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.CEbutton_Click);
            this.Table1.ResumeLayout(false);
            this.Table1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TableLayoutPanel Table1;
        private System.Windows.Forms.Button RESULTbutton;
        private System.Windows.Forms.Button DOTbutton;
        private System.Windows.Forms.Button ZERObutton;
        private System.Windows.Forms.Button DIVINVERSbutton;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button THREEbutton;
        private System.Windows.Forms.Button TWObutton;
        private System.Windows.Forms.Button ONEbutton;
        private System.Windows.Forms.Button SUBbutton;
        private System.Windows.Forms.Button SIXbutton;
        private System.Windows.Forms.Button FIVEbutton;
        private System.Windows.Forms.Button FOURbutton;
        private System.Windows.Forms.Button MULTbutton;
        private System.Windows.Forms.Button NINEbutton;
        private System.Windows.Forms.Button EIGHTbutton;
        private System.Windows.Forms.Button SEVENbutton;
        private System.Windows.Forms.Button DIVIDEbutton;
        private System.Windows.Forms.Button DELbutton;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

