namespace array
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
            lbl_array = new Label();
            lbl_elemento = new Label();
            lbl_risultato = new Label();
            txt_array = new TextBox();
            txt_risultato = new TextBox();
            btn_rimuovi = new Button();
            txt_elemento = new TextBox();
            SuspendLayout();
            // 
            // lbl_array
            // 
            lbl_array.AutoSize = true;
            lbl_array.Location = new Point(12, 74);
            lbl_array.Name = "lbl_array";
            lbl_array.Size = new Size(266, 20);
            lbl_array.TabIndex = 0;
            lbl_array.Text = "Inserisci i numeri separati dalla virgola:";
            // 
            // lbl_elemento
            // 
            lbl_elemento.AutoSize = true;
            lbl_elemento.Location = new Point(12, 212);
            lbl_elemento.Name = "lbl_elemento";
            lbl_elemento.Size = new Size(167, 20);
            lbl_elemento.TabIndex = 1;
            lbl_elemento.Text = "elemento da rimuovere:";
            // 
            // lbl_risultato
            // 
            lbl_risultato.AutoSize = true;
            lbl_risultato.Location = new Point(105, 340);
            lbl_risultato.Name = "lbl_risultato";
            lbl_risultato.Size = new Size(90, 20);
            lbl_risultato.TabIndex = 2;
            lbl_risultato.Text = "nuovo array:";
            // 
            // txt_array
            // 
            txt_array.Location = new Point(284, 74);
            txt_array.Name = "txt_array";
            txt_array.Size = new Size(125, 27);
            txt_array.TabIndex = 3;
            // 
            // txt_risultato
            // 
            txt_risultato.Location = new Point(284, 337);
            txt_risultato.Name = "txt_risultato";
            txt_risultato.Size = new Size(125, 27);
            txt_risultato.TabIndex = 4;
            // 
            // btn_rimuovi
            // 
            btn_rimuovi.Location = new Point(564, 145);
            btn_rimuovi.Name = "btn_rimuovi";
            btn_rimuovi.Size = new Size(168, 29);
            btn_rimuovi.TabIndex = 5;
            btn_rimuovi.Text = "RIMUOVI ELEMENTO";
            btn_rimuovi.UseVisualStyleBackColor = true;
            // 
            // txt_elemento
            // 
            txt_elemento.Location = new Point(284, 205);
            txt_elemento.Name = "txt_elemento";
            txt_elemento.Size = new Size(125, 27);
            txt_elemento.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_elemento);
            Controls.Add(btn_rimuovi);
            Controls.Add(txt_risultato);
            Controls.Add(txt_array);
            Controls.Add(lbl_risultato);
            Controls.Add(lbl_elemento);
            Controls.Add(lbl_array);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_array;
        private Label lbl_elemento;
        private Label lbl_risultato;
        private TextBox txt_array;
        private TextBox txt_risultato;
        private Button btn_rimuovi;
        private TextBox txt_elemento;
    }
}
