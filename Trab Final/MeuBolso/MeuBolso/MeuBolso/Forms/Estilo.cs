using System.Globalization;

namespace MeuBolso.Forms
{
    /// <summary>
    /// Padroniza o visual das telas (grades, botões e formatação de moeda).
    /// </summary>
    public static class Estilo
    {
        public static readonly CultureInfo PtBr = new CultureInfo("pt-BR");

        public static readonly Color Azul = Color.FromArgb(37, 99, 235);
        public static readonly Color Verde = Color.FromArgb(22, 128, 61);
        public static readonly Color Vermelho = Color.FromArgb(200, 40, 40);

        public static string Moeda(decimal valor) => valor.ToString("C2", PtBr);

        public static void ConfigurarGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(230, 232, 236);
            dgv.RowTemplate.Height = 32;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
        }

        public static void BotaoPrimario(Button btn) => Pintar(btn, Azul, Color.White);
        public static void BotaoPerigo(Button btn) => Pintar(btn, Vermelho, Color.White);
        public static void BotaoNeutro(Button btn) => Pintar(btn, Color.FromArgb(235, 237, 240), Color.Black);

        private static void Pintar(Button btn, Color fundo, Color texto)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = fundo;
            btn.ForeColor = texto;
            btn.Cursor = Cursors.Hand;
        }

        /// <summary>Alinha à direita as colunas de valores.</summary>
        public static void AlinharDireita(DataGridViewColumn coluna)
        {
            coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public static void Erro(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool Confirmar(string mensagem) =>
            MessageBox.Show(mensagem, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
