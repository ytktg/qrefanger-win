namespace QRefanger
{
    public partial class Form1 : Form
    {
        NotifyIcon notifyIcon;
        protected DotNetBarcode bcQR;

        public Form1()
        {
            InitializeComponent();

            this.Visible = true;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            this.bcQR = new()
            {
                Type = DotNetBarcode.Types.QRCode,
                PrintCheckDigitChar = true
            };

            this.notifyIcon = new()
            {
                Icon = new Icon(@"C:\Users\yutak\source\repos\QRefanger\QRefanger\ico\9350.ico"),
                Visible = true,
                Text = "QRefanger"
            };

            ToolStripMenuItem toolStripMenuItem = new() { Text = "&èIóπ" };
            toolStripMenuItem.Click += ToolStripMenuItem_Click;

            ContextMenuStrip contextMenuStrip = new();
            contextMenuStrip.Items.Add(toolStripMenuItem);

            this.notifyIcon.ContextMenuStrip = contextMenuStrip;

            this.notifyIcon.Click += NotifyIcon_Click;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.textBoxUrl.Text = Clipboard.GetText();
            this.panelQR.Refresh();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string url = this.textBoxUrl.Text.Normalize(System.Text.NormalizationForm.FormKC);
            url = url.Replace("[.]", ".").Replace("hxxp", "http");

            this.bcQR.WriteBar(url, 0, 0, this.panelQR.Size.Width, this.panelQR.Size.Height, e.Graphics);

            this.labelUrl.Text = url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelQR.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}