namespace Task_manger
{
    partial class EnterTasks
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
            this.labelTask = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textTask = new System.Windows.Forms.TextBox();
            this.textDuration = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.Location = new System.Drawing.Point(79, 48);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(66, 29);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Task";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(79, 159);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(135, 29);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(79, 101);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(186, 29);
            this.labelDuration.TabIndex = 2;
            this.labelDuration.Text = "Duration in Hour";
            // 
            // textTask
            // 
            this.textTask.Location = new System.Drawing.Point(309, 54);
            this.textTask.Name = "textTask";
            this.textTask.Size = new System.Drawing.Size(392, 22);
            this.textTask.TabIndex = 3;
            this.textTask.TextChanged += new System.EventHandler(this.textTask_TextChanged);
            // 
            // textDuration
            // 
            this.textDuration.Location = new System.Drawing.Point(309, 108);
            this.textDuration.Name = "textDuration";
            this.textDuration.Size = new System.Drawing.Size(392, 22);
            this.textDuration.TabIndex = 4;
            this.textDuration.TextChanged += new System.EventHandler(this.textDuration_TextChanged);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(309, 166);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(392, 22);
            this.textDescription.TabIndex = 5;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(84, 324);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(145, 33);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(556, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 33);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // EnterTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.textTask);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTask);
            this.Name = "EnterTasks";
            this.Text = "EnterTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textTask;
        private System.Windows.Forms.TextBox textDuration;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
    }
}