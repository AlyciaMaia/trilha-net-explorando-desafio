using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        //Construtor vazio
        public Reserva() { }

        //Construtor parametrizado
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        //Cadastra os hóspesdes mediante a verificação da capacidade da suite.
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new ArgumentException("A suite não suporta a quantidade de hóspedes atual");
            }
        }

        //Faz o cadastro da suite
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        //Mostra a quantidade de hospedes da reserva
        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        //Faz o cálculo do valor total da reserva por meio do valor da diária e da quantidade de dias reservados
        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }
            return valor;
        }
    }
}