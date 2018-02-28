namespace INziftr
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.numberofcores = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.CheckBox();
            this.dl = new System.Windows.Forms.Button();
            this.processor = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.Label();
            this.linktext = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ziftrlink = new System.Windows.Forms.LinkLabel();
            this.where = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(187, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(45, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Run";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(238, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(45, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // numberofcores
            // 
            this.numberofcores.AutoSize = true;
            this.numberofcores.Location = new System.Drawing.Point(12, 17);
            this.numberofcores.Name = "numberofcores";
            this.numberofcores.Size = new System.Drawing.Size(40, 13);
            this.numberofcores.TabIndex = 2;
            this.numberofcores.Text = "Cores: " + Global.coreCount;
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Location = new System.Drawing.Point(77, 16);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(89, 17);
            this.hide.TabIndex = 3;
            this.hide.Text = "Hide Console";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.CheckedChanged += new System.EventHandler(this.hide_CheckedChanged);
            // 
            // dl
            // 
            this.dl.Location = new System.Drawing.Point(12, 76);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(104, 23);
            this.dl.TabIndex = 4;
            this.dl.Text = "Download Files";
            this.dl.UseVisualStyleBackColor = true;
            this.dl.Click += new System.EventHandler(this.dl_Click);
            // 
            // processor
            // 
            this.processor.AutoSize = true;
            this.processor.Location = new System.Drawing.Point(12, 48);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(60, 13);
            this.processor.TabIndex = 5;
            this.processor.Text = "Processor: " + Global.processorname;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(179, 76);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete Files";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(15, 155);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(268, 20);
            this.address.TabIndex = 7;
            this.address.Text = "ZW7WatsbHpjoMiWjjqh6mmxC94SXR53wyQ";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // addresstext
            // 
            this.addresstext.AutoSize = true;
            this.addresstext.Location = new System.Drawing.Point(74, 126);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(148, 13);
            this.addresstext.TabIndex = 8;
            this.addresstext.Text = "Enter your Ziftr Address below";
            // 
            // linktext
            // 
            this.linktext.AutoSize = true;
            this.linktext.Location = new System.Drawing.Point(97, 178);
            this.linktext.Name = "linktext";
            this.linktext.Size = new System.Drawing.Size(105, 13);
            this.linktext.TabIndex = 9;
            this.linktext.Text = "Enter pool link below";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "stratum+tcp://ziftrpool.io:3032";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ziftrlink
            // 
            this.ziftrlink.AutoSize = true;
            this.ziftrlink.Location = new System.Drawing.Point(74, 139);
            this.ziftrlink.Name = "ziftrlink";
            this.ziftrlink.Size = new System.Drawing.Size(135, 13);
            this.ziftrlink.TabIndex = 11;
            this.ziftrlink.TabStop = true;
            this.ziftrlink.Text = "No address? Get one here!";
            this.ziftrlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ziftrlink_LinkClicked);
            // 
            // where
            // 
            this.where.AutoSize = true;
            this.where.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.where.Location = new System.Drawing.Point(0, 102);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(150, 12);
            this.where.TabIndex = 12;
            this.where.Text = "(/CURRENT LOCATION/temp_folder)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 224);
            this.Controls.Add(this.where);
            this.Controls.Add(this.ziftrlink);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linktext);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.address);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.start);
            this.Controls.Add(this.processor);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.numberofcores);
            this.Controls.Add(this.stop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(319, 263);
            this.MinimumSize = new System.Drawing.Size(319, 263);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INziftr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label numberofcores;
        private System.Windows.Forms.CheckBox hide;
        private System.Windows.Forms.Button dl;
        private System.Windows.Forms.Label processor;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label addresstext;
        private System.Windows.Forms.Label linktext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel ziftrlink;
        private System.Windows.Forms.Label where;
    }
}

