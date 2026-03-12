using System;
using System.Windows.Forms;

namespace sklep;

public partial class Monitor : Form
{
    public string Nazwa { get; private set; } = "";
    public decimal Cena { get; private set; } = 0;

    public Monitor()
    {
        InitializeComponent();
        lbMonitory.SelectedIndex = 0;
    }

    private void BtnOk_Click(object sender, EventArgs e)
    {
        decimal cena = 0;
        string nazwa = "Monitor: ";

        if (lbMonitory.SelectedIndex == 0) { cena += 500; nazwa += "24\""; }
        else if (lbMonitory.SelectedIndex == 1) { cena += 800; nazwa += "27\""; }
        else if (lbMonitory.SelectedIndex == 2) { cena += 1500; nazwa += "32\""; }

        Nazwa = nazwa;
        Cena = cena;
    }
}