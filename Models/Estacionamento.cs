namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
     {
        Console.WriteLine("Digite a placa do veículo para estacionar:");

        // 1. Leia a placa e armazene-a em uma variável
        string placa = Console.ReadLine();

        // 2. Adicione a placa à lista de veículos estacionados
        if (!string.IsNullOrWhiteSpace(placa)) // Verifica se a placa não é nula ou vazia
        {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa '{placa}' adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Placa inválida. O veículo não foi adicionado.");
        }
    }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Quantidade de horas:");
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas ; 

                // TODO: Remover a placa digitada da lista de veículos
                int RemoverVeiculo = veiculos.RemoveAll(item => item.ToLowerInvariant() == placa.ToLowerInvariant());


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
           {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo estacionado.");
            return;
        }

        Console.WriteLine("\nVeículos Estacionados:");
        foreach (var placa in veiculos)
        {
            Console.WriteLine($"- {placa}");
        }
    }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
