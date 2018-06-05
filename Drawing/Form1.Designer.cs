namespace Drawing
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TA_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TA_Lisa_CBx = new System.Windows.Forms.ComboBox();
            this.TA_Lisa = new System.Windows.Forms.Button();
            this.TA_Automaat_CBx = new System.Windows.Forms.ComboBox();
            this.TA_Puhasta = new System.Windows.Forms.Button();
            this.TA_JoonAutomaat = new System.Windows.Forms.Button();
            this.TA_Pindala1 = new System.Windows.Forms.PictureBox();
            this.TATimer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TA_Pindala1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TA_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TA_Status
            // 
            this.TA_Status.Name = "TA_Status";
            this.TA_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // TA_Lisa_CBx
            // 
            this.TA_Lisa_CBx.BackColor = System.Drawing.SystemColors.Window;
            this.TA_Lisa_CBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TA_Lisa_CBx.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TA_Lisa_CBx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TA_Lisa_CBx.FormattingEnabled = true;
            this.TA_Lisa_CBx.Items.AddRange(new object[] {
            "Joon",
            "Ellips",
            "Suvaline Joon",
            "Tühi Ristkülik",
            "Värvitud Ristkülik",
            "Kontuuriga Ristkülik"});
            this.TA_Lisa_CBx.Location = new System.Drawing.Point(12, 163);
            this.TA_Lisa_CBx.Name = "TA_Lisa_CBx";
            this.TA_Lisa_CBx.Size = new System.Drawing.Size(203, 30);
            this.TA_Lisa_CBx.TabIndex = 31;
            // 
            // TA_Lisa
            // 
            this.TA_Lisa.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TA_Lisa.Location = new System.Drawing.Point(12, 118);
            this.TA_Lisa.Name = "TA_Lisa";
            this.TA_Lisa.Size = new System.Drawing.Size(203, 39);
            this.TA_Lisa.TabIndex = 30;
            this.TA_Lisa.Text = "Lisa";
            this.TA_Lisa.UseVisualStyleBackColor = true;
            this.TA_Lisa.Click += new System.EventHandler(this.TA_Lisa_Click);
            // 
            // TA_Automaat_CBx
            // 
            this.TA_Automaat_CBx.BackColor = System.Drawing.SystemColors.Window;
            this.TA_Automaat_CBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TA_Automaat_CBx.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TA_Automaat_CBx.FormattingEnabled = true;
            this.TA_Automaat_CBx.Items.AddRange(new object[] {
            "Ellips",
            "Jooned",
            "Tühi Ristkülik",
            "Värvitud Ristkülik",
            "Kontuuriga Ristkülik"});
            this.TA_Automaat_CBx.Location = new System.Drawing.Point(12, 57);
            this.TA_Automaat_CBx.Name = "TA_Automaat_CBx";
            this.TA_Automaat_CBx.Size = new System.Drawing.Size(203, 30);
            this.TA_Automaat_CBx.TabIndex = 29;
            // 
            // TA_Puhasta
            // 
            this.TA_Puhasta.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TA_Puhasta.Location = new System.Drawing.Point(12, 401);
            this.TA_Puhasta.Name = "TA_Puhasta";
            this.TA_Puhasta.Size = new System.Drawing.Size(203, 39);
            this.TA_Puhasta.TabIndex = 28;
            this.TA_Puhasta.Text = "Puhasta";
            this.TA_Puhasta.UseVisualStyleBackColor = true;
            this.TA_Puhasta.Click += new System.EventHandler(this.TA_Puhasta_Click);
            // 
            // TA_JoonAutomaat
            // 
            this.TA_JoonAutomaat.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TA_JoonAutomaat.Location = new System.Drawing.Point(12, 12);
            this.TA_JoonAutomaat.Name = "TA_JoonAutomaat";
            this.TA_JoonAutomaat.Size = new System.Drawing.Size(203, 39);
            this.TA_JoonAutomaat.TabIndex = 27;
            this.TA_JoonAutomaat.Text = "Automaat Sisse";
            this.TA_JoonAutomaat.UseVisualStyleBackColor = true;
            this.TA_JoonAutomaat.Click += new System.EventHandler(this.TA_JoonAutomaat_Click);
            // 
            // TA_Pindala1
            // 
            this.TA_Pindala1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TA_Pindala1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TA_Pindala1.Location = new System.Drawing.Point(221, 6);
            this.TA_Pindala1.Name = "TA_Pindala1";
            this.TA_Pindala1.Size = new System.Drawing.Size(510, 434);
            this.TA_Pindala1.TabIndex = 26;
            this.TA_Pindala1.TabStop = false;
            this.TA_Pindala1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TA_Pindala1_MouseDown);
            this.TA_Pindala1.MouseLeave += new System.EventHandler(this.TA_Pindala1_MouseLeave);
            this.TA_Pindala1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TA_Pindala1_MouseMove);
            this.TA_Pindala1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TA_Pindala1_MouseUp);
            // 
            // TATimer1
            // 
            this.TATimer1.Tick += new System.EventHandler(this.TATimer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TA_Lisa_CBx);
            this.Controls.Add(this.TA_Lisa);
            this.Controls.Add(this.TA_Automaat_CBx);
            this.Controls.Add(this.TA_Puhasta);
            this.Controls.Add(this.TA_JoonAutomaat);
            this.Controls.Add(this.TA_Pindala1);
            this.Name = "Form1";
            this.Text = "Drawing";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TA_Pindala1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TA_Status;
        private System.Windows.Forms.ComboBox TA_Lisa_CBx;
        private System.Windows.Forms.Button TA_Lisa;
        private System.Windows.Forms.ComboBox TA_Automaat_CBx;
        private System.Windows.Forms.Button TA_Puhasta;
        private System.Windows.Forms.Button TA_JoonAutomaat;
        private System.Windows.Forms.PictureBox TA_Pindala1;
        private System.Windows.Forms.Timer TATimer1;
    }
}

