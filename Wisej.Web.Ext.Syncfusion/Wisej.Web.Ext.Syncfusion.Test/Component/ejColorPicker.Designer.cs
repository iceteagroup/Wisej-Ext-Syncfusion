namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
    partial class ejColorPicker
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ejColorPicker1 = new Wisej.Web.Ext.Syncfusion.ejColorPicker();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://help.syncfusion.com/js/colorpicker/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejcolorpicker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.ejColorPicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/colorpicker";
            // 
            // ejColorPicker1
            // 
            this.ejColorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejColorPicker1.Location = new System.Drawing.Point(192, 147);
            this.ejColorPicker1.Name = "ejColorPicker1";
            this.ejColorPicker1.Size = new System.Drawing.Size(113, 37);
            this.ejColorPicker1.TabIndex = 2;
            this.ejColorPicker1.Text = "Choose Color";
            this.ejColorPicker1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejColorPicker1_WidgetEvent);            
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.Label.Text = "Value (prefix with #)";
            this.textBox1.Location = new System.Drawing.Point(28, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 60);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose Color";
            // 
            // ejColorPicker
            // 
            this.Name = "ejColorPicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EjColorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private Syncfusion.ejColorPicker ejColorPicker1;

        #endregion

        private TextBox textBox1;
        private Label label4;
    }
}
