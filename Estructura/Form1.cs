namespace Estructura
{
    public partial class Structure : Form
    {
        public Structure()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Structure_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Enter";
        }

        private void Structure_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Leave";
        }

        private void Structure_MouseMove(object sender, MouseEventArgs e)
        { 
            label1.Text = $"{e.Location.X},{e.Location.Y}";  //Ver las coordenadas
        }
    }
}