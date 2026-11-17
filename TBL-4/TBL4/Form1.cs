using System.Runtime.InteropServices;

namespace TBL4
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        // Permite arrastar a janela pelo cabeçalho (panel1)
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Abre qualquer formulário do sistema
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

        // ===== Cabeçalho: Fechar, Maximizar e Restaurar =====

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Exercício 1 - Maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // Sem a borda padrão o Windows maximizaria por cima da barra de tarefas;
            // esta linha limita a janela à área útil da tela.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        // Exercício 1 - Restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        // ===== Menu lateral =====

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        // Exercício 2 - novos botões
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();
        }
    }
}
