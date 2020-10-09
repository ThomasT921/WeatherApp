namespace WeatherApp
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.txtCity = new System.Windows.Forms.TextBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblWhere = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.pbDescrip = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescrip)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(98, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(121, 20);
            this.txtCity.TabIndex = 0;
            // 
            // comboState
            // 
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboState.FormattingEnabled = true;
            this.comboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboState.Location = new System.Drawing.Point(98, 160);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 21);
            this.comboState.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "State:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(246, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get Weather";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.BackColor = System.Drawing.Color.Transparent;
            this.lblWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhere.ForeColor = System.Drawing.Color.White;
            this.lblWhere.Location = new System.Drawing.Point(56, 18);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(152, 25);
            this.lblWhere.TabIndex = 6;
            this.lblWhere.Text = "Knoxville, TN";
            this.lblWhere.Visible = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(78, 155);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(87, 61);
            this.lblTemp.TabIndex = 7;
            this.lblTemp.Text = "43";
            this.lblTemp.Visible = false;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.lblFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeelsLike.ForeColor = System.Drawing.Color.White;
            this.lblFeelsLike.Location = new System.Drawing.Point(74, 216);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(113, 18);
            this.lblFeelsLike.TabIndex = 8;
            this.lblFeelsLike.Text = "Feels Like: 43";
            this.lblFeelsLike.Visible = false;
            // 
            // pbDescrip
            // 
            this.pbDescrip.BackColor = System.Drawing.Color.Transparent;
            this.pbDescrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDescrip.Location = new System.Drawing.Point(77, 61);
            this.pbDescrip.Name = "pbDescrip";
            this.pbDescrip.Size = new System.Drawing.Size(110, 91);
            this.pbDescrip.TabIndex = 9;
            this.pbDescrip.TabStop = false;
            this.pbDescrip.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(210, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(274, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pbDescrip);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblWhere);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.txtCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherForm";
            this.Text = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.pbDescrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.PictureBox pbDescrip;
        private System.Windows.Forms.Button button3;
    }
}

