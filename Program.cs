
namespace atividadeexecutavel
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Formulario());
        }
    }

	public class Formulario : Form {

		Label lblNome;
        TextBox txtNome;
		Button btnImprimir;
		Button btnSair;

		int larguraTelaPixel = 400;
		int alturaTelaPixel = 300;
		public Formulario() {
			this.Text = "Atividade Executável";
			this.Controls.Add(this.criarLabelNome());
			this.Controls.Add(this.criarTextBoxNome());
			this.Controls.Add(this.criarButtonImprimir());			
			this.Controls.Add(this.criarButtonSair());
			this.Size = new Size(larguraTelaPixel,alturaTelaPixel);
		}

		private Label criarLabelNome(){
			lblNome = new Label();
			lblNome.Text = "Nome:";
			lblNome.AutoSize = true;
			lblNome.Location = new Point(100,60);
			return lblNome;
		}

		private TextBox criarTextBoxNome(){
			txtNome = new TextBox();
			txtNome.Location = new Point(150, 60);
			txtNome.Size = new Size(100, 18);
			return txtNome;
		}        

		private Button criarButtonImprimir() {
			btnImprimir = new Button();
			btnImprimir.Text = "Imprimir";
			btnImprimir.Size = new Size(100,30);
			btnImprimir.Location = new Point(150, 120);
			btnImprimir.Click += new EventHandler(this.btnImprimirClick);		
			return btnImprimir;		
		}

		private Button criarButtonSair() {
			btnSair = new Button();
			btnSair.Text = "Sair";
			btnSair.Size = new Size(100,30);
			btnSair.Location = new Point(150, 150);
			btnSair.Click += new EventHandler(this.btnSairClick);				
			return btnSair;	
		}

		private void btnImprimirClick(object sender, EventArgs e) {
            MessageBox.Show($"Olá, {txtNome.Text}");
		}

		private void btnSairClick(object sender, EventArgs e) {
			this.Close();
		}
        
    }
}