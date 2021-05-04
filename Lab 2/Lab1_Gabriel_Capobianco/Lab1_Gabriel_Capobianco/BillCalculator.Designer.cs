namespace Lab1_Gabriel_Capobianco
{
    partial class BillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonResidential = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radioButtonCommercial = new System.Windows.Forms.RadioButton();
            this.radioButtonIndustrial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.industrialBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAccNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listCustomersBox = new System.Windows.Forms.ListBox();
            this.textBoxCustSum = new System.Windows.Forms.TextBox();
            this.textBoxResTotal = new System.Windows.Forms.TextBox();
            this.textBoxIndTotal = new System.Windows.Forms.TextBox();
            this.textBoxCommTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSumofAllCharges = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.industrialBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "HYDROMAX";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(165, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "kWh usage";
            // 
            // radioButtonResidential
            // 
            this.radioButtonResidential.AutoSize = true;
            this.radioButtonResidential.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResidential.ForeColor = System.Drawing.Color.White;
            this.radioButtonResidential.Location = new System.Drawing.Point(6, 33);
            this.radioButtonResidential.Name = "radioButtonResidential";
            this.radioButtonResidential.Size = new System.Drawing.Size(139, 29);
            this.radioButtonResidential.TabIndex = 0;
            this.radioButtonResidential.TabStop = true;
            this.radioButtonResidential.Text = "Residential";
            this.radioButtonResidential.UseVisualStyleBackColor = false;
            this.radioButtonResidential.CheckedChanged += new System.EventHandler(this.RadioButtonResidential_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Black;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(192, 576);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 52);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // radioButtonCommercial
            // 
            this.radioButtonCommercial.AutoSize = true;
            this.radioButtonCommercial.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCommercial.ForeColor = System.Drawing.Color.White;
            this.radioButtonCommercial.Location = new System.Drawing.Point(180, 33);
            this.radioButtonCommercial.Name = "radioButtonCommercial";
            this.radioButtonCommercial.Size = new System.Drawing.Size(147, 29);
            this.radioButtonCommercial.TabIndex = 1;
            this.radioButtonCommercial.TabStop = true;
            this.radioButtonCommercial.Text = "Commercial";
            this.radioButtonCommercial.UseVisualStyleBackColor = false;
            this.radioButtonCommercial.CheckedChanged += new System.EventHandler(this.RadioButtonCommercial_CheckedChanged);
            // 
            // radioButtonIndustrial
            // 
            this.radioButtonIndustrial.AutoSize = true;
            this.radioButtonIndustrial.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIndustrial.ForeColor = System.Drawing.Color.White;
            this.radioButtonIndustrial.Location = new System.Drawing.Point(345, 33);
            this.radioButtonIndustrial.Name = "radioButtonIndustrial";
            this.radioButtonIndustrial.Size = new System.Drawing.Size(121, 29);
            this.radioButtonIndustrial.TabIndex = 2;
            this.radioButtonIndustrial.TabStop = true;
            this.radioButtonIndustrial.Text = "Industrial";
            this.radioButtonIndustrial.UseVisualStyleBackColor = false;
            this.radioButtonIndustrial.CheckedChanged += new System.EventHandler(this.RadioButtonIndustrial_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radioButtonCommercial);
            this.groupBox1.Controls.Add(this.radioButtonIndustrial);
            this.groupBox1.Controls.Add(this.radioButtonResidential);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Customer";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(365, 576);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 52);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1139, 743);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "kWh usage:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(310, 519);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 30);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(170, 519);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 29);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Bill Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Please enter your electricity usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Peak hours kWh usage:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(293, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "Peak hours kWh usage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Off-peak kWh usage:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(293, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 30);
            this.textBox3.TabIndex = 19;
            this.textBox3.Tag = "Off-peak hours kWh usage";
            // 
            // industrialBox
            // 
            this.industrialBox.BackColor = System.Drawing.Color.Transparent;
            this.industrialBox.Controls.Add(this.label5);
            this.industrialBox.Controls.Add(this.textBox3);
            this.industrialBox.Controls.Add(this.label4);
            this.industrialBox.Controls.Add(this.textBox2);
            this.industrialBox.Location = new System.Drawing.Point(17, 372);
            this.industrialBox.Name = "industrialBox";
            this.industrialBox.Size = new System.Drawing.Size(450, 130);
            this.industrialBox.TabIndex = 21;
            this.industrialBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Account No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Please fill the following info for new users:";
            // 
            // textBoxAccNo
            // 
            this.textBoxAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccNo.Location = new System.Drawing.Point(175, 155);
            this.textBoxAccNo.Name = "textBoxAccNo";
            this.textBoxAccNo.Size = new System.Drawing.Size(152, 30);
            this.textBoxAccNo.TabIndex = 1;
            this.textBoxAccNo.Tag = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(175, 203);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 30);
            this.textBoxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1135, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listCustomersBox
            // 
            this.listCustomersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomersBox.FormattingEnabled = true;
            this.listCustomersBox.ItemHeight = 25;
            this.listCustomersBox.Location = new System.Drawing.Point(599, 99);
            this.listCustomersBox.Name = "listCustomersBox";
            this.listCustomersBox.Size = new System.Drawing.Size(634, 279);
            this.listCustomersBox.TabIndex = 28;
            // 
            // textBoxCustSum
            // 
            this.textBoxCustSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustSum.Location = new System.Drawing.Point(1080, 471);
            this.textBoxCustSum.Name = "textBoxCustSum";
            this.textBoxCustSum.ReadOnly = true;
            this.textBoxCustSum.Size = new System.Drawing.Size(153, 30);
            this.textBoxCustSum.TabIndex = 29;
            this.textBoxCustSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResTotal
            // 
            this.textBoxResTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResTotal.Location = new System.Drawing.Point(1080, 518);
            this.textBoxResTotal.Name = "textBoxResTotal";
            this.textBoxResTotal.ReadOnly = true;
            this.textBoxResTotal.Size = new System.Drawing.Size(153, 30);
            this.textBoxResTotal.TabIndex = 30;
            this.textBoxResTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIndTotal
            // 
            this.textBoxIndTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndTotal.Location = new System.Drawing.Point(1080, 611);
            this.textBoxIndTotal.Name = "textBoxIndTotal";
            this.textBoxIndTotal.ReadOnly = true;
            this.textBoxIndTotal.Size = new System.Drawing.Size(153, 30);
            this.textBoxIndTotal.TabIndex = 32;
            this.textBoxIndTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCommTotal
            // 
            this.textBoxCommTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommTotal.Location = new System.Drawing.Point(1080, 564);
            this.textBoxCommTotal.Name = "textBoxCommTotal";
            this.textBoxCommTotal.ReadOnly = true;
            this.textBoxCommTotal.Size = new System.Drawing.Size(153, 30);
            this.textBoxCommTotal.TabIndex = 31;
            this.textBoxCommTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(777, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total No of Customers:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(777, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Residential Charge Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(777, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Industrial Charge Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(777, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Commercial Charge Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(777, 657);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Sum of all Charges:";
            // 
            // textBoxSumofAllCharges
            // 
            this.textBoxSumofAllCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumofAllCharges.Location = new System.Drawing.Point(1080, 657);
            this.textBoxSumofAllCharges.Name = "textBoxSumofAllCharges";
            this.textBoxSumofAllCharges.ReadOnly = true;
            this.textBoxSumofAllCharges.Size = new System.Drawing.Size(153, 30);
            this.textBoxSumofAllCharges.TabIndex = 37;
            this.textBoxSumofAllCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BillCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1263, 799);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSumofAllCharges);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIndTotal);
            this.Controls.Add(this.textBoxCommTotal);
            this.Controls.Add(this.textBoxResTotal);
            this.Controls.Add(this.textBoxCustSum);
            this.Controls.Add(this.listCustomersBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAccNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.industrialBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BillCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HydroMax Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.industrialBox.ResumeLayout(false);
            this.industrialBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonResidential;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radioButtonCommercial;
        private System.Windows.Forms.RadioButton radioButtonIndustrial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox industrialBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAccNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listCustomersBox;
        private System.Windows.Forms.TextBox textBoxCustSum;
        private System.Windows.Forms.TextBox textBoxResTotal;
        private System.Windows.Forms.TextBox textBoxIndTotal;
        private System.Windows.Forms.TextBox textBoxCommTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSumofAllCharges;
    }
}

