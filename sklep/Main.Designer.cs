namespace sklep;

partial class Main
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListView lvKoszyk;
    private System.Windows.Forms.Button btnKomputer;
    private System.Windows.Forms.Button btnMonitor;
    private System.Windows.Forms.Button btnUsun;
    private System.Windows.Forms.Label lblSuma;
    private System.Windows.Forms.ColumnHeader chProdukt;
    private System.Windows.Forms.ColumnHeader chCena;

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
        lvKoszyk = new ListView();
        chProdukt = new ColumnHeader();
        chCena = new ColumnHeader();
        btnKomputer = new Button();
        btnMonitor = new Button();
        btnUsun = new Button();
        lblSuma = new Label();
        SuspendLayout();

        lvKoszyk.Columns.AddRange(new ColumnHeader[] { chProdukt, chCena });
        lvKoszyk.FullRowSelect = true;
        lvKoszyk.Location = new Point(20, 20);
        lvKoszyk.Name = "lvKoszyk";
        lvKoszyk.Size = new Size(342, 250);
        lvKoszyk.TabIndex = 0;
        lvKoszyk.UseCompatibleStateImageBehavior = false;
        lvKoszyk.View = View.Details;

        chProdukt.Text = "Produkt";
        chProdukt.Width = 200;
 
        chCena.Text = "Cena";
        chCena.Width = 80;

        btnKomputer.Location = new Point(368, 20);
        btnKomputer.Name = "btnKomputer";
        btnKomputer.Size = new Size(120, 40);
        btnKomputer.TabIndex = 1;
        btnKomputer.Text = "Komputer";
        btnKomputer.UseVisualStyleBackColor = true;
        btnKomputer.Click += BtnKomputer_Click;

        btnMonitor.Location = new Point(368, 66);
        btnMonitor.Name = "btnMonitor";
        btnMonitor.Size = new Size(120, 40);
        btnMonitor.TabIndex = 2;
        btnMonitor.Text = "Monitor";
        btnMonitor.UseVisualStyleBackColor = true;
        btnMonitor.Click += BtnMonitor_Click;

        btnUsun.Location = new Point(368, 112);
        btnUsun.Name = "btnUsun";
        btnUsun.Size = new Size(120, 40);
        btnUsun.TabIndex = 3;
        btnUsun.Text = "Usuń";
        btnUsun.UseVisualStyleBackColor = true;
        btnUsun.Click += BtnUsun_Click;

        lblSuma.Location = new Point(368, 248);
        lblSuma.Name = "lblSuma";
        lblSuma.Size = new Size(150, 40);
        lblSuma.TabIndex = 4;
        lblSuma.Text = "Suma: 0 zł";

        ClientSize = new Size(509, 287);
        Controls.Add(lblSuma);
        Controls.Add(btnUsun);
        Controls.Add(btnMonitor);
        Controls.Add(btnKomputer);
        Controls.Add(lvKoszyk);
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sklep Komputerowy";
        ResumeLayout(false);
    }
}