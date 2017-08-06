namespace TestTask_GL
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
            this.button_serialize = new System.Windows.Forms.Button();
            this.button_desirialize = new System.Windows.Forms.Button();
            this.label_notifications = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_serialize
            // 
            this.button_serialize.Location = new System.Drawing.Point(10, 14);
            this.button_serialize.Name = "button_serialize";
            this.button_serialize.Size = new System.Drawing.Size(144, 39);
            this.button_serialize.TabIndex = 0;
            this.button_serialize.Text = "Serialize directory";
            this.button_serialize.UseVisualStyleBackColor = true;
            this.button_serialize.Click += new System.EventHandler(this.button_serialize_Click);
            // 
            // button_desirialize
            // 
            this.button_desirialize.Location = new System.Drawing.Point(160, 14);
            this.button_desirialize.Name = "button_desirialize";
            this.button_desirialize.Size = new System.Drawing.Size(144, 39);
            this.button_desirialize.TabIndex = 1;
            this.button_desirialize.Text = "Deserialize directory";
            this.button_desirialize.UseVisualStyleBackColor = true;
            this.button_desirialize.Click += new System.EventHandler(this.button_desirialize_Click);
            // 
            // label_notifications
            // 
            this.label_notifications.AutoSize = true;
            this.label_notifications.Location = new System.Drawing.Point(12, 70);
            this.label_notifications.Name = "label_notifications";
            this.label_notifications.Size = new System.Drawing.Size(0, 13);
            this.label_notifications.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 111);
            this.Controls.Add(this.label_notifications);
            this.Controls.Add(this.button_desirialize);
            this.Controls.Add(this.button_serialize);
            this.Name = "Form1";
            this.Text = "Test task GlobalLogic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_serialize;
        private System.Windows.Forms.Button button_desirialize;
        private System.Windows.Forms.Label label_notifications;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

