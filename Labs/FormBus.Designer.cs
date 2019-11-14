namespace Labs
{
    partial class FormBus
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.createBusButton = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // createBusButton
            // 
            this.createBusButton.Location = new System.Drawing.Point(12, 12);
            this.createBusButton.Name = "createBusButton";
            this.createBusButton.Size = new System.Drawing.Size(82, 23);
            this.createBusButton.TabIndex = 1;
            this.createBusButton.Text = "Create";
            this.createBusButton.UseVisualStyleBackColor = true;
            this.createBusButton.Click += new System.EventHandler(this.createBusButton_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(702, 379);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(29, 26);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "W";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(667, 411);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(29, 26);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.Text = "A";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(737, 412);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(29, 26);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.Text = "D";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(702, 411);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(29, 26);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "S";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.createBusButton);
            this.Controls.Add(this.pictureBoxBus);
            this.Name = "FormBus";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.Button createBusButton;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
    }
}

