using System;

namespace Calculator
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
            this.pad1 = new System.Windows.Forms.Button();
            this.pad2 = new System.Windows.Forms.Button();
            this.pad4 = new System.Windows.Forms.Button();
            this.pad5 = new System.Windows.Forms.Button();
            this.pad3 = new System.Windows.Forms.Button();
            this.pad8 = new System.Windows.Forms.Button();
            this.pad10 = new System.Windows.Forms.Button();
            this.pad9 = new System.Windows.Forms.Button();
            this.pad7 = new System.Windows.Forms.Button();
            this.pad6 = new System.Windows.Forms.Button();
            this.operationPlus = new System.Windows.Forms.Button();
            this.operationResult = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.operationClear = new System.Windows.Forms.Button();
            this.operationMinus = new System.Windows.Forms.Button();
            this.operationmultiply = new System.Windows.Forms.Button();
            this.operationdivide = new System.Windows.Forms.Button();
            this.operationplusminus = new System.Windows.Forms.Button();
            this.operationDot = new System.Windows.Forms.Button();
            this.operationCE = new System.Windows.Forms.Button();
            this.operationBack = new System.Windows.Forms.Button();
            this.operationOnedtox = new System.Windows.Forms.Button();
            this.operationPercent = new System.Windows.Forms.Button();
            this.operationsqrt = new System.Windows.Forms.Button();
            this.operationMC = new System.Windows.Forms.Button();
            this.operationMR = new System.Windows.Forms.Button();
            this.operationMS = new System.Windows.Forms.Button();
            this.operationMplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pad1
            // 
            this.pad1.Location = new System.Drawing.Point(71, 271);
            this.pad1.Margin = new System.Windows.Forms.Padding(2);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(50, 48);
            this.pad1.TabIndex = 0;
            this.pad1.Text = "1";
            this.pad1.UseVisualStyleBackColor = true;
            this.pad1.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad2
            // 
            this.pad2.Location = new System.Drawing.Point(138, 271);
            this.pad2.Margin = new System.Windows.Forms.Padding(2);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(50, 48);
            this.pad2.TabIndex = 1;
            this.pad2.Text = "2";
            this.pad2.UseVisualStyleBackColor = true;
            this.pad2.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad4
            // 
            this.pad4.Location = new System.Drawing.Point(71, 210);
            this.pad4.Margin = new System.Windows.Forms.Padding(2);
            this.pad4.Name = "pad4";
            this.pad4.Size = new System.Drawing.Size(50, 48);
            this.pad4.TabIndex = 2;
            this.pad4.Text = "4";
            this.pad4.UseVisualStyleBackColor = true;
            this.pad4.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad5
            // 
            this.pad5.Location = new System.Drawing.Point(138, 210);
            this.pad5.Margin = new System.Windows.Forms.Padding(2);
            this.pad5.Name = "pad5";
            this.pad5.Size = new System.Drawing.Size(50, 48);
            this.pad5.TabIndex = 3;
            this.pad5.Text = "5";
            this.pad5.UseVisualStyleBackColor = true;
            this.pad5.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad3
            // 
            this.pad3.Location = new System.Drawing.Point(203, 271);
            this.pad3.Margin = new System.Windows.Forms.Padding(2);
            this.pad3.Name = "pad3";
            this.pad3.Size = new System.Drawing.Size(50, 48);
            this.pad3.TabIndex = 4;
            this.pad3.Text = "3";
            this.pad3.UseVisualStyleBackColor = true;
            this.pad3.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad8
            // 
            this.pad8.Location = new System.Drawing.Point(138, 154);
            this.pad8.Margin = new System.Windows.Forms.Padding(2);
            this.pad8.Name = "pad8";
            this.pad8.Size = new System.Drawing.Size(50, 48);
            this.pad8.TabIndex = 9;
            this.pad8.Text = "8";
            this.pad8.UseVisualStyleBackColor = true;
            this.pad8.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad10
            // 
            this.pad10.Location = new System.Drawing.Point(71, 331);
            this.pad10.Margin = new System.Windows.Forms.Padding(2);
            this.pad10.Name = "pad10";
            this.pad10.Size = new System.Drawing.Size(50, 48);
            this.pad10.TabIndex = 8;
            this.pad10.Text = "0";
            this.pad10.UseVisualStyleBackColor = true;
            this.pad10.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad9
            // 
            this.pad9.Location = new System.Drawing.Point(203, 154);
            this.pad9.Margin = new System.Windows.Forms.Padding(2);
            this.pad9.Name = "pad9";
            this.pad9.Size = new System.Drawing.Size(50, 48);
            this.pad9.TabIndex = 7;
            this.pad9.Text = "9";
            this.pad9.UseVisualStyleBackColor = true;
            this.pad9.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad7
            // 
            this.pad7.Location = new System.Drawing.Point(71, 154);
            this.pad7.Margin = new System.Windows.Forms.Padding(2);
            this.pad7.Name = "pad7";
            this.pad7.Size = new System.Drawing.Size(50, 48);
            this.pad7.TabIndex = 6;
            this.pad7.Text = "7";
            this.pad7.UseVisualStyleBackColor = true;
            this.pad7.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad6
            // 
            this.pad6.Location = new System.Drawing.Point(203, 210);
            this.pad6.Margin = new System.Windows.Forms.Padding(2);
            this.pad6.Name = "pad6";
            this.pad6.Size = new System.Drawing.Size(50, 48);
            this.pad6.TabIndex = 5;
            this.pad6.Text = "6";
            this.pad6.UseVisualStyleBackColor = true;
            this.pad6.Click += new System.EventHandler(this.pad_Click);
            // 
            // operationPlus
            // 
            this.operationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationPlus.Location = new System.Drawing.Point(263, 331);
            this.operationPlus.Margin = new System.Windows.Forms.Padding(2);
            this.operationPlus.Name = "operationPlus";
            this.operationPlus.Size = new System.Drawing.Size(50, 48);
            this.operationPlus.TabIndex = 10;
            this.operationPlus.Text = "+";
            this.operationPlus.UseVisualStyleBackColor = true;
            this.operationPlus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationResult
            // 
            this.operationResult.Location = new System.Drawing.Point(328, 331);
            this.operationResult.Margin = new System.Windows.Forms.Padding(2);
            this.operationResult.Name = "operationResult";
            this.operationResult.Size = new System.Drawing.Size(50, 48);
            this.operationResult.TabIndex = 11;
            this.operationResult.Text = "=";
            this.operationResult.UseVisualStyleBackColor = true;
            this.operationResult.Click += new System.EventHandler(this.operationResult_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(35, 32);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(312, 32);
            this.display.TabIndex = 12;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_KeyPress);
            this.display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.display_KeyPress);
            // 
            // operationClear
            // 
            this.operationClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationClear.Location = new System.Drawing.Point(11, 91);
            this.operationClear.Margin = new System.Windows.Forms.Padding(2);
            this.operationClear.Name = "operationClear";
            this.operationClear.Size = new System.Drawing.Size(80, 48);
            this.operationClear.TabIndex = 13;
            this.operationClear.Text = "C";
            this.operationClear.UseVisualStyleBackColor = true;
            this.operationClear.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationMinus
            // 
            this.operationMinus.Location = new System.Drawing.Point(263, 271);
            this.operationMinus.Margin = new System.Windows.Forms.Padding(2);
            this.operationMinus.Name = "operationMinus";
            this.operationMinus.Size = new System.Drawing.Size(50, 48);
            this.operationMinus.TabIndex = 14;
            this.operationMinus.Text = "-";
            this.operationMinus.UseVisualStyleBackColor = true;
            this.operationMinus.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationmultiply
            // 
            this.operationmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationmultiply.Location = new System.Drawing.Point(263, 210);
            this.operationmultiply.Margin = new System.Windows.Forms.Padding(2);
            this.operationmultiply.Name = "operationmultiply";
            this.operationmultiply.Size = new System.Drawing.Size(50, 48);
            this.operationmultiply.TabIndex = 15;
            this.operationmultiply.Text = "*";
            this.operationmultiply.UseVisualStyleBackColor = true;
            this.operationmultiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationdivide
            // 
            this.operationdivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationdivide.Location = new System.Drawing.Point(263, 154);
            this.operationdivide.Margin = new System.Windows.Forms.Padding(2);
            this.operationdivide.Name = "operationdivide";
            this.operationdivide.Size = new System.Drawing.Size(50, 48);
            this.operationdivide.TabIndex = 16;
            this.operationdivide.Text = "/";
            this.operationdivide.UseVisualStyleBackColor = true;
            this.operationdivide.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationplusminus
            // 
            this.operationplusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationplusminus.Location = new System.Drawing.Point(138, 331);
            this.operationplusminus.Margin = new System.Windows.Forms.Padding(2);
            this.operationplusminus.Name = "operationplusminus";
            this.operationplusminus.Size = new System.Drawing.Size(50, 48);
            this.operationplusminus.TabIndex = 17;
            this.operationplusminus.Text = "+/-";
            this.operationplusminus.UseVisualStyleBackColor = true;
            this.operationplusminus.Click += new System.EventHandler(this.Click);
            // 
            // operationDot
            // 
            this.operationDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationDot.Location = new System.Drawing.Point(203, 331);
            this.operationDot.Margin = new System.Windows.Forms.Padding(2);
            this.operationDot.Name = "operationDot";
            this.operationDot.Size = new System.Drawing.Size(50, 48);
            this.operationDot.TabIndex = 18;
            this.operationDot.Text = ",";
            this.operationDot.UseVisualStyleBackColor = true;
            this.operationDot.Click += new System.EventHandler(this.operationDot_Click);
            // 
            // operationCE
            // 
            this.operationCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationCE.Location = new System.Drawing.Point(95, 91);
            this.operationCE.Margin = new System.Windows.Forms.Padding(2);
            this.operationCE.Name = "operationCE";
            this.operationCE.Size = new System.Drawing.Size(64, 48);
            this.operationCE.TabIndex = 19;
            this.operationCE.Text = "CE";
            this.operationCE.UseVisualStyleBackColor = true;
            this.operationCE.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationBack
            // 
            this.operationBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBack.Location = new System.Drawing.Point(163, 91);
            this.operationBack.Margin = new System.Windows.Forms.Padding(2);
            this.operationBack.Name = "operationBack";
            this.operationBack.Size = new System.Drawing.Size(90, 48);
            this.operationBack.TabIndex = 20;
            this.operationBack.Text = "BACK";
            this.operationBack.UseVisualStyleBackColor = true;
            this.operationBack.Click += new System.EventHandler(this.operationBack_Click);
            // 
            // operationOnedtox
            // 
            this.operationOnedtox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationOnedtox.Location = new System.Drawing.Point(328, 271);
            this.operationOnedtox.Margin = new System.Windows.Forms.Padding(2);
            this.operationOnedtox.Name = "operationOnedtox";
            this.operationOnedtox.Size = new System.Drawing.Size(50, 48);
            this.operationOnedtox.TabIndex = 21;
            this.operationOnedtox.Text = "1/x";
            this.operationOnedtox.UseVisualStyleBackColor = true;
            this.operationOnedtox.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationPercent
            // 
            this.operationPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationPercent.Location = new System.Drawing.Point(328, 206);
            this.operationPercent.Margin = new System.Windows.Forms.Padding(2);
            this.operationPercent.Name = "operationPercent";
            this.operationPercent.Size = new System.Drawing.Size(50, 48);
            this.operationPercent.TabIndex = 22;
            this.operationPercent.Text = "%";
            this.operationPercent.UseVisualStyleBackColor = true;
            this.operationPercent.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationsqrt
            // 
            this.operationsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsqrt.Location = new System.Drawing.Point(328, 154);
            this.operationsqrt.Margin = new System.Windows.Forms.Padding(2);
            this.operationsqrt.Name = "operationsqrt";
            this.operationsqrt.Size = new System.Drawing.Size(50, 48);
            this.operationsqrt.TabIndex = 23;
            this.operationsqrt.Text = "sqrt";
            this.operationsqrt.UseVisualStyleBackColor = true;
            this.operationsqrt.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationMC
            // 
            this.operationMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operationMC.Location = new System.Drawing.Point(11, 154);
            this.operationMC.Margin = new System.Windows.Forms.Padding(2);
            this.operationMC.Name = "operationMC";
            this.operationMC.Size = new System.Drawing.Size(50, 48);
            this.operationMC.TabIndex = 24;
            this.operationMC.Text = "MC";
            this.operationMC.UseVisualStyleBackColor = true;
            this.operationMC.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMR
            // 
            this.operationMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMR.Location = new System.Drawing.Point(11, 210);
            this.operationMR.Margin = new System.Windows.Forms.Padding(2);
            this.operationMR.Name = "operationMR";
            this.operationMR.Size = new System.Drawing.Size(50, 48);
            this.operationMR.TabIndex = 25;
            this.operationMR.Text = "MR";
            this.operationMR.UseVisualStyleBackColor = true;
            this.operationMR.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMS
            // 
            this.operationMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMS.Location = new System.Drawing.Point(11, 271);
            this.operationMS.Margin = new System.Windows.Forms.Padding(2);
            this.operationMS.Name = "operationMS";
            this.operationMS.Size = new System.Drawing.Size(50, 48);
            this.operationMS.TabIndex = 26;
            this.operationMS.Text = "MS";
            this.operationMS.UseVisualStyleBackColor = true;
            this.operationMS.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMplus
            // 
            this.operationMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMplus.Location = new System.Drawing.Point(11, 331);
            this.operationMplus.Margin = new System.Windows.Forms.Padding(2);
            this.operationMplus.Name = "operationMplus";
            this.operationMplus.Size = new System.Drawing.Size(50, 48);
            this.operationMplus.TabIndex = 27;
            this.operationMplus.Text = "M+";
            this.operationMplus.UseVisualStyleBackColor = true;
            this.operationMplus.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(413, 430);
            this.Controls.Add(this.operationMplus);
            this.Controls.Add(this.operationMS);
            this.Controls.Add(this.operationMR);
            this.Controls.Add(this.operationMC);
            this.Controls.Add(this.operationsqrt);
            this.Controls.Add(this.operationPercent);
            this.Controls.Add(this.operationOnedtox);
            this.Controls.Add(this.operationBack);
            this.Controls.Add(this.operationCE);
            this.Controls.Add(this.operationDot);
            this.Controls.Add(this.operationplusminus);
            this.Controls.Add(this.operationdivide);
            this.Controls.Add(this.operationmultiply);
            this.Controls.Add(this.operationMinus);
            this.Controls.Add(this.operationClear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.operationResult);
            this.Controls.Add(this.operationPlus);
            this.Controls.Add(this.pad8);
            this.Controls.Add(this.pad10);
            this.Controls.Add(this.pad9);
            this.Controls.Add(this.pad7);
            this.Controls.Add(this.pad6);
            this.Controls.Add(this.pad3);
            this.Controls.Add(this.pad5);
            this.Controls.Add(this.pad4);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button pad1;
        private System.Windows.Forms.Button pad2;
        private System.Windows.Forms.Button pad4;
        private System.Windows.Forms.Button pad5;
        private System.Windows.Forms.Button pad3;
        private System.Windows.Forms.Button pad8;
        private System.Windows.Forms.Button pad10;
        private System.Windows.Forms.Button pad9;
        private System.Windows.Forms.Button pad7;
        private System.Windows.Forms.Button pad6;
        private System.Windows.Forms.Button operationPlus;
        private System.Windows.Forms.Button operationResult;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button operationClear;
        private System.Windows.Forms.Button operationMinus;
        private System.Windows.Forms.Button operationmultiply;
        private System.Windows.Forms.Button operationdivide;
        private System.Windows.Forms.Button operationplusminus;
        private System.Windows.Forms.Button operationDot;
        private System.Windows.Forms.Button operationCE;
        private System.Windows.Forms.Button operationBack;
        private System.Windows.Forms.Button operationOnedtox;
        private System.Windows.Forms.Button operationPercent;
        private System.Windows.Forms.Button operationsqrt;
        private System.Windows.Forms.Button operationMC;
        private System.Windows.Forms.Button operationMR;
        private System.Windows.Forms.Button operationMS;
        private System.Windows.Forms.Button operationMplus;
    }
}

