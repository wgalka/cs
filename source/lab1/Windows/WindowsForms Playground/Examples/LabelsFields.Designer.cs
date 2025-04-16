namespace WindowsForms_Playground.kontrolki {
    partial class LabelsFields {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 90);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Etykiety";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(18, 52);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "klasa LinkLabel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "klasa Label";
            // 
            // LabelsFields
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 223);
            Controls.Add(groupBox1);
            Name = "LabelsFields";
            Text = "Etykiety";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}