namespace projektprogramowanie
{
    partial class MainForm
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCar.Location = new System.Drawing.Point(55, 37);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(123, 32);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "ADD CAR";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click_1);
            // 
            // btnShowCars
            // 
            this.btnShowCars.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowCars.Location = new System.Drawing.Point(55, 75);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(123, 31);
            this.btnShowCars.TabIndex = 2;
            this.btnShowCars.Text = "SHOW CARS";
            this.btnShowCars.UseVisualStyleBackColor = false;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAIN MENU";
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitMain.Location = new System.Drawing.Point(55, 112);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(123, 31);
            this.btnExitMain.TabIndex = 4;
            this.btnExitMain.Text = "EXIT";
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(247, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.btnAddCar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitMain;
    }
}