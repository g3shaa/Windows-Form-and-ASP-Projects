namespace CalorieCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.sodaTextBox = new System.Windows.Forms.TextBox();
            this.friesTextBox = new System.Windows.Forms.TextBox();
            this.burgerTextBox = new System.Windows.Forms.TextBox();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изчисли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sodaTextBox
            // 
            this.sodaTextBox.Location = new System.Drawing.Point(12, 239);
            this.sodaTextBox.Name = "sodaTextBox";
            this.sodaTextBox.Size = new System.Drawing.Size(301, 20);
            this.sodaTextBox.TabIndex = 1;
            // 
            // friesTextBox
            // 
            this.friesTextBox.Location = new System.Drawing.Point(12, 138);
            this.friesTextBox.Name = "friesTextBox";
            this.friesTextBox.Size = new System.Drawing.Size(301, 20);
            this.friesTextBox.TabIndex = 2;
            // 
            // burgerTextBox
            // 
            this.burgerTextBox.Location = new System.Drawing.Point(12, 45);
            this.burgerTextBox.Name = "burgerTextBox";
            this.burgerTextBox.Size = new System.Drawing.Size(301, 20);
            this.burgerTextBox.TabIndex = 3;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCaloriesLabel.Location = new System.Drawing.Point(12, 321);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(86, 24);
            this.totalCaloriesLabel.TabIndex = 4;
            this.totalCaloriesLabel.Text = "Калории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Бургер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Картофки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.burgerTextBox);
            this.Controls.Add(this.friesTextBox);
            this.Controls.Add(this.sodaTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CaloriesCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sodaTextBox;
        private System.Windows.Forms.TextBox friesTextBox;
        private System.Windows.Forms.TextBox burgerTextBox;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

