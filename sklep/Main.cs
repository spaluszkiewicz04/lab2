using System;
using System.Windows.Forms;

namespace sklep;

public partial class Main : Form
{
    private decimal sumaCen = 0m;

    public Main()
    {
        InitializeComponent();
    }

    private void BtnKomputer_Click(object sender, EventArgs e)
    {
        using (var form = new Computer())
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                DodajDoKoszyka(form.Nazwa, form.Cena);
            }
        }
    }

    private void BtnMonitor_Click(object sender, EventArgs e)
    {
        using (var form = new Monitor())
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                DodajDoKoszyka(form.Nazwa, form.Cena);
            }
        }
    }

    private void BtnUsun_Click(object sender, EventArgs e)
    {
        if (lvKoszyk.SelectedItems.Count > 0)
        {
            foreach (ListViewItem select in lvKoszyk.SelectedItems)
            {
                if (select.Tag is decimal minus)
                {
                    sumaCen -= minus;
                }

                lvKoszyk.Items.Remove(select);
            }

            updSuma();
        }
        else
        {
            MessageBox.Show("Brak zaznaczenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void DodajDoKoszyka(string nazwa, decimal cena)
    {
        var item = new ListViewItem(nazwa);
        item.SubItems.Add(cena.ToString("C"));
        item.Tag = cena;

        lvKoszyk.Items.Add(item);

        sumaCen += cena;
        updSuma();
    }

    private void updSuma()
    {
        lblSuma.Text = $"Suma: {sumaCen} zł";
    }
}