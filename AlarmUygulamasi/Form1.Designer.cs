namespace AlarmUygulamasi
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
            dtpZaman = new DateTimePicker();
            btnKur = new Button();
            statusStrip1 = new StatusStrip();
            lblDurum = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpZaman
            // 
            dtpZaman.Format = DateTimePickerFormat.Time;
            dtpZaman.Location = new Point(49, 47);
            dtpZaman.Margin = new Padding(6);
            dtpZaman.Name = "dtpZaman";
            dtpZaman.Size = new Size(197, 39);
            dtpZaman.TabIndex = 0;
            // 
            // btnKur
            // 
            btnKur.Location = new Point(49, 98);
            btnKur.Margin = new Padding(6);
            btnKur.Name = "btnKur";
            btnKur.Size = new Size(197, 49);
            btnKur.TabIndex = 1;
            btnKur.Text = "Alarm Kur";
            btnKur.UseVisualStyleBackColor = true;
            btnKur.Click += btnKur_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDurum });
            statusStrip1.Location = new Point(0, 188);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(306, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum
            // 
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(108, 17);
            lblDurum.Text = "Alarm kurulu değil.";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 210);
            Controls.Add(statusStrip1);
            Controls.Add(btnKur);
            Controls.Add(dtpZaman);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm Uygulaması";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpZaman;
        private Button btnKur;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDurum;
        private System.Windows.Forms.Timer timer1;
    }
}