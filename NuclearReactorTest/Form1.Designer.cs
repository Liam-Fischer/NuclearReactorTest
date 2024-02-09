namespace NuclearReactorTest
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.reactor1label = new System.Windows.Forms.Label();
            this.reactorlabel2 = new System.Windows.Forms.Label();
            this.reactorstatelabel1 = new System.Windows.Forms.Label();
            this.reactorstatelabel2 = new System.Windows.Forms.Label();
            this.runbutton = new System.Windows.Forms.Button();
            this.sitlabel = new System.Windows.Forms.TextBox();
            this.stopbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(12, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(638, 50);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Reactor Command Center";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor1label
            // 
            this.reactor1label.AutoSize = true;
            this.reactor1label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1label.Location = new System.Drawing.Point(62, 115);
            this.reactor1label.Name = "reactor1label";
            this.reactor1label.Size = new System.Drawing.Size(136, 21);
            this.reactor1label.TabIndex = 1;
            this.reactor1label.Text = "Reactor A";
            this.reactor1label.Click += new System.EventHandler(this.reactor1label_Click);
            // 
            // reactorlabel2
            // 
            this.reactorlabel2.AutoSize = true;
            this.reactorlabel2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorlabel2.Location = new System.Drawing.Point(415, 115);
            this.reactorlabel2.Name = "reactorlabel2";
            this.reactorlabel2.Size = new System.Drawing.Size(136, 21);
            this.reactorlabel2.TabIndex = 2;
            this.reactorlabel2.Text = "Reactor B";
            // 
            // reactorstatelabel1
            // 
            this.reactorstatelabel1.BackColor = System.Drawing.Color.Lime;
            this.reactorstatelabel1.Location = new System.Drawing.Point(63, 163);
            this.reactorstatelabel1.Name = "reactorstatelabel1";
            this.reactorstatelabel1.Size = new System.Drawing.Size(169, 110);
            this.reactorstatelabel1.TabIndex = 3;
            // 
            // reactorstatelabel2
            // 
            this.reactorstatelabel2.BackColor = System.Drawing.Color.Lime;
            this.reactorstatelabel2.Location = new System.Drawing.Point(382, 163);
            this.reactorstatelabel2.Name = "reactorstatelabel2";
            this.reactorstatelabel2.Size = new System.Drawing.Size(169, 110);
            this.reactorstatelabel2.TabIndex = 4;
            // 
            // runbutton
            // 
            this.runbutton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runbutton.Location = new System.Drawing.Point(163, 290);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(162, 57);
            this.runbutton.TabIndex = 5;
            this.runbutton.Text = "Activate reactor";
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // sitlabel
            // 
            this.sitlabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.sitlabel.Location = new System.Drawing.Point(66, 380);
            this.sitlabel.Name = "sitlabel";
            this.sitlabel.Size = new System.Drawing.Size(485, 45);
            this.sitlabel.TabIndex = 6;
            this.sitlabel.Text = "Reactors Stable";
            this.sitlabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sitlabel.TextChanged += new System.EventHandler(this.sitlabel_TextChanged);
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.Location = new System.Drawing.Point(452, 290);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(132, 70);
            this.stopbutton.TabIndex = 7;
            this.stopbutton.Text = "Inject Coolant";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.sitlabel);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.reactorstatelabel2);
            this.Controls.Add(this.reactorstatelabel1);
            this.Controls.Add(this.reactorlabel2);
            this.Controls.Add(this.reactor1label);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "Diablo Canyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label reactor1label;
        private System.Windows.Forms.Label reactorlabel2;
        private System.Windows.Forms.Label reactorstatelabel1;
        private System.Windows.Forms.Label reactorstatelabel2;
        private System.Windows.Forms.Button runbutton;
        private System.Windows.Forms.TextBox sitlabel;
        private System.Windows.Forms.Button stopbutton;
    }
}

