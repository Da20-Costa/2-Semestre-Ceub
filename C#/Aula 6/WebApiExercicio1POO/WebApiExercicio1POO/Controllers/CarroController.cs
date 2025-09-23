using Microsoft.AspNetCore.Mvc;
using WebApiExercicio1POO.Model;

namespace WebApiExercicio1POO.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet("ImprimirDadosVeiculo")]
        public string ImprimirDadosVeiculo(string marcaCarro,string modeloCarro,string placaCarro,string corCarro,
                                            Int32 numeroMarchasCarro,Int32 anoFabricacaoCarro, Int32 anoModeloCarro)
        {
            Carro carro = new Carro();
            carro.marca = marcaCarro;
            carro.modelo = modeloCarro;
            carro.placa = placaCarro;
            carro.cor = corCarro;
            carro.numeroMarchas = numeroMarchasCarro;
            carro.anoFabricacao = anoFabricacaoCarro;
            carro.anoModelo = anoModeloCarro;

            return $"Marca: {carro.marca}\nModelo: {carro.modelo}\nPlaca: {carro.placa}\nCor: {carro.cor}\nNúmero de Marchas: " +
                $"{carro.numeroMarchas}\nAno de Fabricação: {carro.anoFabricacao}\nAno do modelo: {carro.anoModelo}";
        }

        [HttpGet("Buzinar")]
        public string Buzinar()
        {
            Carro carro = new Carro();
            return carro.Buzinar();
        }

        [HttpGet("LigarCarro")]
        public string LigarCarro()
        {
            string resultado;
            Carro carro = new Carro();
            if (carro.ligar)
            {
                resultado = "O carro já está ligado!";
            }
            else
            {
                resultado = "O carro foi ligado!";
            }
            return resultado;
        }

        [HttpGet("Acelerar")]
        public string AcelerarCarro()
        {
            string resultado;
            Carro carro = new Carro();
            carro.Acelerar();
            resultado = $"A velocidade após a aceleração é: {carro.velocidade}";
            return resultado;
        }
    }
}
