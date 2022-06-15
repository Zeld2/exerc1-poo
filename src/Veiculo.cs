namespace csharp_poo_exercises.Models
{
    public class Veiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }

        protected string Placa { get; set; }

        protected string Cor { get; set; }

        protected float Km { get; set; }

        protected Boolean IsLigado { get; set; } = false;

        protected int LitrosCombustivel { get; set; } = 0;

        protected int Velocidade { get; set; } = 0;

        protected double Preco { get; set; }

        public Veiculo(string Marca, string Modelo, string Placa, string Cor, float Km, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Km = Km;
            this.Preco = Preco;
        }

        public Veiculo()
        {
        }

        public void Abastecer(int litrosAbastecer)
        {
            int tanqueAtual = this.LitrosCombustivel;
            var tentativaAbastecer = tanqueAtual + litrosAbastecer;
            if (tentativaAbastecer <= 60 & litrosAbastecer > 0)
            {
                this.LitrosCombustivel = tentativaAbastecer;
                System.Console.WriteLine($"Tanque está com {this.LitrosCombustivel}l");
            }
            else if (litrosAbastecer <= 0)
            {
                System.Console.Write("Litros de combustível deve ser maior que 0");
            }
            else
            {
                this.LitrosCombustivel = 60;
                var litrosAbastecidos = this.LitrosCombustivel - tanqueAtual;
                System.Console.WriteLine($"Capacidade máxima de 60l do tanque atingida. Foi abastecido {litrosAbastecidos}l.");
            }

        }
        public void Acelerar()
        {
            if (!this.IsLigado)
            {
                System.Console.WriteLine("Carro desligado. Ligue o carro.");
            }
            else if (this.LitrosCombustivel <= 0)
            {
                System.Console.WriteLine("Tanque vazio, abastecer o veículo.");
            }
            else
            {
                this.Velocidade += 20;
                System.Console.WriteLine($"Velocidade aumentada em 20km/h. Velocidade atual de: {this.Velocidade}");
            }
        }
        public void Frear()
        {
            if (this.Velocidade == 0)
            {
                System.Console.WriteLine("Carro já está parado.");
            }
            else
                this.Velocidade -= 20;
            System.Console.WriteLine($"Velocidade diminuída em 20km/h. Velocidade atual de: {this.Velocidade}");
        }
        public void Pintar(string CorDesejada)
        {
            this.Cor = CorDesejada;
            System.Console.WriteLine($"Carro pintado. Cor atual: {this.Cor}");
        }
        public void Ligar()
        {
            this.IsLigado = true;
            System.Console.WriteLine("Carro ligado.");
        }
        public void Desligar()
        {
            if (this.Velocidade == 0)
            {
                this.IsLigado = false;
                System.Console.WriteLine("Carro desligado.");
            }
            else
            {
                System.Console.WriteLine("Carro em movimento, necessário frear o carro até velocidade ser igual a 0.");
            }
        }

        public override string ToString()
        {

            return "" +
                    "Marca: " + this.Marca +
                    "\nModelo: " + this.Modelo +
                    "\nPlaca: " + this.Placa +
                    "\nCor: " + this.Cor +
                    "\nKm: " + this.Km +
                    "\nLigado: " + this.IsLigado +
                    "\nTanque: " + this.LitrosCombustivel + "l" +
                    "\nVelocidade: " + this.Velocidade +
                    "\nPreco: " + this.Preco +
                    ""
            ;
        }
    }
}