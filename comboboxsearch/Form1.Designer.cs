namespace comboboxsearch
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
            this.statecomboBox = new System.Windows.Forms.ComboBox();
            this.inttextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.decimaltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statecomboBox
            // 
            this.statecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statecomboBox.FormattingEnabled = true;
            this.statecomboBox.Location = new System.Drawing.Point(89, 70);
            this.statecomboBox.Name = "statecomboBox";
            this.statecomboBox.Size = new System.Drawing.Size(566, 39);
            this.statecomboBox.TabIndex = 0;
            // 
            // inttextbox
            // 
            this.inttextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inttextbox.Location = new System.Drawing.Point(12, 186);
            this.inttextbox.Name = "inttextbox";
            this.inttextbox.Size = new System.Drawing.Size(365, 45);
            this.inttextbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // decimaltextBox
            // 
            this.decimaltextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decimaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimaltextBox.Location = new System.Drawing.Point(401, 186);
            this.decimaltextBox.Name = "decimaltextBox";
            this.decimaltextBox.Size = new System.Drawing.Size(365, 45);
            this.decimaltextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decimaltextBox);
            this.Controls.Add(this.inttextbox);
            this.Controls.Add(this.statecomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statecomboBox;
        private System.Windows.Forms.TextBox inttextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox decimaltextBox;
    }
}

