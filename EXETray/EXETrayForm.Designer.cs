namespace EXETray
{
    partial class EXETrayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXETrayForm));
            this.EXETray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // EXETray
            // 
            resources.ApplyResources(this.EXETray, "EXETray");
            this.EXETray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EXETray_MouseClick);
            // 
            // EXETrayForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "EXETrayForm";
            this.Load += new System.EventHandler(this.EXETrayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon EXETray;
    }
}