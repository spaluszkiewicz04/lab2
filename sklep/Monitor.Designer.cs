namespace sklep;

partial class Monitor
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox lbMonitory;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnAnuluj;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lbMonitory = new ListBox();
        btnOk = new Button();
        btnAnuluj = new Button();
        SuspendLayout();

        lbMonitory.FormattingEnabled = true;
        lbMonitory.Items.AddRange(new object[] { "Monitor 24 cale 1080p (500 zł)", "Monitor 27 cali 1080p (800 zł)", "Monitor 32 cale 4K (1500 zł)" });
        lbMonitory.Location = new Point(20, 20);
        lbMonitory.Name = "lbMonitory";
        lbMonitory.Size = new Size(240, 64);
        lbMonitory.TabIndex = 0;

        btnOk.DialogResult = DialogResult.OK;
        btnOk.Location = new Point(20, 100);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(75, 29);
        btnOk.TabIndex = 1;
        btnOk.Text = "OK";
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += BtnOk_Click;

        btnAnuluj.DialogResult = DialogResult.Cancel;
        btnAnuluj.Location = new Point(185, 100);
        btnAnuluj.Name = "btnAnuluj";
        btnAnuluj.Size = new Size(75, 29);
        btnAnuluj.TabIndex = 2;
        btnAnuluj.Text = "Anuluj";
        btnAnuluj.UseVisualStyleBackColor = true;

        ClientSize = new Size(278, 146);
        Controls.Add(btnAnuluj);
        Controls.Add(btnOk);
        Controls.Add(lbMonitory);
        Name = "Monitor";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Monitor";
        ResumeLayout(false);
    }
}