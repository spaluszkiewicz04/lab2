namespace sklep;

partial class Computer
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ComboBox cbProcesor;
    private System.Windows.Forms.RadioButton rb240;
    private System.Windows.Forms.RadioButton rb500;
    private System.Windows.Forms.RadioButton rb1000;
    private System.Windows.Forms.Label lblProc;
    private System.Windows.Forms.GroupBox gbDysk;
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
        lblProc = new Label();
        cbProcesor = new ComboBox();
        gbDysk = new GroupBox();
        rb1000 = new RadioButton();
        rb500 = new RadioButton();
        rb240 = new RadioButton();
        btnOk = new Button();
        btnAnuluj = new Button();
        gbDysk.SuspendLayout();
        SuspendLayout();

        lblProc.Location = new Point(20, 15);
        lblProc.Name = "lblProc";
        lblProc.Size = new Size(100, 23);
        lblProc.TabIndex = 0;
        lblProc.Text = "Procesor:";

        cbProcesor.DropDownStyle = ComboBoxStyle.DropDownList;
        cbProcesor.FormattingEnabled = true;
        cbProcesor.Items.AddRange(new object[] { "Intel Core i5 (800 zł)", "AMD Ryzen 5 (750 zł)", "Intel Core i7 (1200 zł)" });
        cbProcesor.Location = new Point(20, 40);
        cbProcesor.Name = "cbProcesor";
        cbProcesor.Size = new Size(268, 28);
        cbProcesor.TabIndex = 1;
 
        gbDysk.Controls.Add(rb1000);
        gbDysk.Controls.Add(rb500);
        gbDysk.Controls.Add(rb240);
        gbDysk.Location = new Point(20, 80);
        gbDysk.Name = "gbDysk";
        gbDysk.Size = new Size(268, 100);
        gbDysk.TabIndex = 2;
        gbDysk.TabStop = false;
        gbDysk.Text = "Dysk";

        rb1000.AutoSize = true;
        rb1000.Location = new Point(10, 70);
        rb1000.Name = "rb1000";
        rb1000.Size = new Size(176, 24);
        rb1000.TabIndex = 2;
        rb1000.Text = "1000 GB SATA (300 zł)";
        rb1000.UseVisualStyleBackColor = true;

        rb500.AutoSize = true;
        rb500.Location = new Point(10, 45);
        rb500.Name = "rb500";
        rb500.Size = new Size(168, 24);
        rb500.TabIndex = 1;
        rb500.Text = "500 GB SATA (200 zł)";
        rb500.UseVisualStyleBackColor = true;

        rb240.AutoSize = true;
        rb240.Checked = true;
        rb240.Location = new Point(10, 20);
        rb240.Name = "rb240";
        rb240.Size = new Size(161, 24);
        rb240.TabIndex = 0;
        rb240.TabStop = true;
        rb240.Text = "240 GB SSD (150 zł)";
        rb240.UseVisualStyleBackColor = true;

        btnOk.DialogResult = DialogResult.OK;
        btnOk.Location = new Point(20, 200);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(75, 30);
        btnOk.TabIndex = 3;
        btnOk.Text = "OK";
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += BtnOk_Click;

        btnAnuluj.DialogResult = DialogResult.Cancel;
        btnAnuluj.Location = new Point(213, 200);
        btnAnuluj.Name = "btnAnuluj";
        btnAnuluj.Size = new Size(75, 30);
        btnAnuluj.TabIndex = 4;
        btnAnuluj.Text = "Anuluj";
        btnAnuluj.UseVisualStyleBackColor = true;

        ClientSize = new Size(309, 247);
        Controls.Add(btnAnuluj);
        Controls.Add(btnOk);
        Controls.Add(gbDysk);
        Controls.Add(cbProcesor);
        Controls.Add(lblProc);
        Name = "Computer";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Komputer";
        gbDysk.ResumeLayout(false);
        gbDysk.PerformLayout();
        ResumeLayout(false);
    }
}