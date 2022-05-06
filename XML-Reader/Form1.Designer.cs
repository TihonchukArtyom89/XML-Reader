
namespace XML_Reader
{
    partial class Form1
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
            this.NameWorker = new System.Windows.Forms.ListBox();
            this.WorkerDetails = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // NameWorker
            // 
            this.NameWorker.FormattingEnabled = true;
            this.NameWorker.Location = new System.Drawing.Point(12, 29);
            this.NameWorker.Name = "NameWorker";
            this.NameWorker.Size = new System.Drawing.Size(380, 407);
            this.NameWorker.TabIndex = 0;
            // 
            // WorkerDetails
            // 
            this.WorkerDetails.Location = new System.Drawing.Point(415, 29);
            this.WorkerDetails.Name = "WorkerDetails";
            this.WorkerDetails.Size = new System.Drawing.Size(373, 407);
            this.WorkerDetails.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkerDetails);
            this.Controls.Add(this.NameWorker);
            this.Name = "Form1";
            this.Text = "XML-Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox NameWorker;
        private System.Windows.Forms.PropertyGrid WorkerDetails;
    }
}

