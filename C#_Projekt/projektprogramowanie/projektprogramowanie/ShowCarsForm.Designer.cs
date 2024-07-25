namespace projektprogramowanie
{
    partial class ShowCarsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.availableCarsListBox = new System.Windows.Forms.ListBox();
            this.btnExitShowCars = new System.Windows.Forms.Button();
            this.btnBackToMenuShowCars = new System.Windows.Forms.Button();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVAILABLE CARS ";
            // 
            // availableCarsListBox
            // 
            this.availableCarsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.availableCarsListBox.FormattingEnabled = true;
            this.availableCarsListBox.Location = new System.Drawing.Point(17, 52);
            this.availableCarsListBox.Name = "availableCarsListBox";
            this.availableCarsListBox.Size = new System.Drawing.Size(771, 368);
            this.availableCarsListBox.TabIndex = 1;
            // 
            // btnExitShowCars
            // 
            this.btnExitShowCars.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitShowCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitShowCars.Location = new System.Drawing.Point(653, 424);
            this.btnExitShowCars.Name = "btnExitShowCars";
            this.btnExitShowCars.Size = new System.Drawing.Size(135, 23);
            this.btnExitShowCars.TabIndex = 2;
            this.btnExitShowCars.Text = "EXIT";
            this.btnExitShowCars.UseVisualStyleBackColor = false;
            this.btnExitShowCars.Click += new System.EventHandler(this.btnExitShowCars_Click);
            // 
            // btnBackToMenuShowCars
            // 
            this.btnBackToMenuShowCars.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMenuShowCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackToMenuShowCars.Location = new System.Drawing.Point(512, 424);
            this.btnBackToMenuShowCars.Name = "btnBackToMenuShowCars";
            this.btnBackToMenuShowCars.Size = new System.Drawing.Size(135, 23);
            this.btnBackToMenuShowCars.TabIndex = 3;
            this.btnBackToMenuShowCars.Text = "BACK TO MENU";
            this.btnBackToMenuShowCars.UseVisualStyleBackColor = false;
            this.btnBackToMenuShowCars.Click += new System.EventHandler(this.btnBackToMenuShowCars_Click);
            // 
            // btnSellCar
            // 
            this.btnSellCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSellCar.Location = new System.Drawing.Point(17, 426);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(135, 23);
            this.btnSellCar.TabIndex = 4;
            this.btnSellCar.Text = "SELL CAR";
            this.btnSellCar.UseVisualStyleBackColor = false;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click_1);
            // 
            // ShowCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSellCar);
            this.Controls.Add(this.btnBackToMenuShowCars);
            this.Controls.Add(this.btnExitShowCars);
            this.Controls.Add(this.availableCarsListBox);
            this.Controls.Add(this.label1);
            this.Name = "ShowCarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowCarsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox availableCarsListBox;
        private System.Windows.Forms.Button btnExitShowCars;
        private System.Windows.Forms.Button btnBackToMenuShowCars;
        private System.Windows.Forms.Button btnSellCar;
    }
}