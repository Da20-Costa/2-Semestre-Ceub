namespace WebApiIMC.Model
{
    public class Pessoa
    {
        public string nomePessoa;
        public double alturaPessoa;
        public double pesoPessoa;

        public Int32 CalcularImc(double altura, double peso)
        {
            this.alturaPessoa = altura;
            this.pesoPessoa = peso;
            Int32 indiceImc = Convert.ToInt32(peso / (altura * altura));
            return indiceImc;
        }

        public string ClassificarImc(Int32 indiceImc)
        {
            string resultado;
            if (indiceImc <= 19)
            {
                resultado = "Abaixo do Peso.";
            }
            else if (indiceImc > 19 && indiceImc <= 25)
            {
                resultado = "Peso Ideal.";
            }
            else if (indiceImc > 25 && indiceImc <= 30)
            {
                resultado = "Acima do Peso.";
            }
            else if (indiceImc > 30 && indiceImc <= 35)
            {
                resultado = "Obesidade Leve.";
            }
            else
            {
                resultado = "Obesidade";
            }

            return resultado;
        }
    }
}
