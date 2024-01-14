namespace BasicBrowser
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStrip1 = new ToolStrip();
            BTHome = new ToolStripButton();
            BTBack = new ToolStripButton();
            BTForward = new ToolStripButton();
            UrlBox = new ToolStripTextBox();
            BTGo = new ToolStripButton();
            WBView = new Microsoft.Web.WebView2.WinForms.WebView2();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WBView).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Font = new Font("Javanese Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BTHome, BTBack, BTForward, UrlBox, BTGo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(978, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // BTHome
            // 
            BTHome.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BTHome.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTHome.ImageTransparentColor = Color.Magenta;
            BTHome.Name = "BTHome";
            BTHome.Size = new Size(45, 51);
            BTHome.Text = "⌂";
            BTHome.Click += BTHome_Click;
            // 
            // BTBack
            // 
            BTBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BTBack.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTBack.ImageTransparentColor = Color.Magenta;
            BTBack.Name = "BTBack";
            BTBack.Size = new Size(45, 51);
            BTBack.Text = "↶";
            BTBack.Click += BTBack_Click;
            // 
            // BTForward
            // 
            BTForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BTForward.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTForward.ImageTransparentColor = Color.Magenta;
            BTForward.Name = "BTForward";
            BTForward.Size = new Size(45, 51);
            BTForward.Text = "↷";
            BTForward.Click += BTForward_Click;
            // 
            // UrlBox
            // 
            UrlBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UrlBox.Name = "UrlBox";
            UrlBox.Size = new Size(684, 54);
            UrlBox.KeyDown += UrlBox_KeyDown;
            // 
            // BTGo
            // 
            BTGo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BTGo.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTGo.ImageTransparentColor = Color.Magenta;
            BTGo.Name = "BTGo";
            BTGo.Size = new Size(48, 51);
            BTGo.Text = "➥";
            BTGo.Click += BTGo_Click;
            // 
            // WBView
            // 
            WBView.AllowExternalDrop = true;
            WBView.CreationProperties = null;
            WBView.DefaultBackgroundColor = Color.White;
            WBView.Dock = DockStyle.Fill;
            WBView.Location = new Point(0, 54);
            WBView.Margin = new Padding(4, 7, 4, 7);
            WBView.Name = "WBView";
            WBView.Size = new Size(978, 506);
            WBView.TabIndex = 1;
            WBView.ZoomFactor = 1D;
            WBView.NavigationCompleted += WBView_NavigationCompleted;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 560);
            Controls.Add(WBView);
            Controls.Add(toolStrip1);
            Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 7, 4, 7);
            Name = "Form1";
            Text = "Basic Browser |";
            TopMost = true;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WBView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStrip toolStrip1;
        private ToolStripButton BTBack;
        private ToolStripButton BTForward;
        private ToolStripButton BTGo;
        private Microsoft.Web.WebView2.WinForms.WebView2 WBView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox UrlBox;
        private ToolStripButton BTHome;
    }
}