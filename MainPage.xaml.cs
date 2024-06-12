namespace ProjetoD12M06
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }



        private void GirarButton_Clicket(object sender, EventArgs e)
        {
            //Pegar o que o ususario selecionou 
            //Girar a moeda (sortear o lado que "caiu" a moeda 0 = cara e 1 = coroa
            // comparar o que o usuario selecionou com o que foi sorteado
            // Exibir se ele venceu ou se perdeu 
            //trocar imagem
            string resultado;
            string ladoSelecionado = SelecaoPicker.SelectedItem.ToString();
            string ladoSorteado = new Random().Next(2).ToString();
            if (ladoSorteado == "0")
            {
                ladoSorteado = "cara";
                MoedaImage.Source = ladoSorteado + ".png";
            }else
            {
                ladoSorteado = "coroa";
                MoedaImage.Source = ladoSorteado + ".png";

            }

            if (ladoSelecionado == ladoSorteado)
            {
                resultado = "Parabens, voce venceu!";
            }
            else
            {
                resultado = "Que pena, voce perdeu!";
            }
            ResultadoLabel.Text = resultado;
        }
    }

}
