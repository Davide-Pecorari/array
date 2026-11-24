using System;
using System.Collections;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            string[] parti = txtArray.Text.Split(',');
            int[] arrayOriginale = new int[parti.Length];


            for (int i = 0; i < parti.Length; i++)
            {

                if (!int.TryParse(parti[i].Trim(), out arrayOriginale[i]))
                {
                    MessageBox.Show("Inserisci solo numeri interi validi (es. 10, 20, 30).", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!int.TryParse(txtElemento.Text.Trim(), out int elementoDaRimuovere))
            {
                MessageBox.Show("Inserisci un numero intero valido da rimuovere.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int[] risultato = RimuoviElemento(arrayOriginale, elementoDaRimuovere);
            txtRisultato.Text = string.Join(", ", risultato);
        }
    }
}