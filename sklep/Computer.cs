using System;
using System.Windows.Forms;

namespace sklep;

public partial class Computer : Form
{
    public string Nazwa { get; private set; } = "";
    public decimal Cena { get; private set; } = 0;

    public Computer()
    {
        InitializeComponent();
        cbProcesor.SelectedIndex = 0;
    }

    private void BtnOk_Click(object sender, EventArgs e)
    {
        decimal cena = 0;
        string nazwa = "PC: " + cbProcesor.SelectedItem.ToString().Split('(')[0].Trim() + " + ";

        if (cbProcesor.SelectedIndex == 0) cena += 800;
        else if (cbProcesor.SelectedIndex == 1) cena += 750;
        else if (cbProcesor.SelectedIndex == 2) cena += 1200;

        if (rb240.Checked) { cena += 150; nazwa += "240GB"; }
        else if (rb500.Checked) { cena += 200; nazwa += "500GB"; }
        else if (rb1000.Checked) { cena += 300; nazwa += "1000GB"; }

        Cena = cena;
        Nazwa = nazwa;
    }
}