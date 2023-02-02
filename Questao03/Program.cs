const double COMISSAO = 0.05;

Console.WriteLine("Digite o número de carros vendidos: ");
int quantidadeCarrosVendidos = 0;
int.TryParse(Console.ReadLine(), out quantidadeCarrosVendidos);

Console.WriteLine("Digite o valor total de suas vendas: ");
double valorTotalVendas = 0;
double.TryParse(Console.ReadLine(), out valorTotalVendas);

Console.WriteLine("Digite o valor do salário fixo: ");
double salarioFixo = 0;
double.TryParse(Console.ReadLine(), out salarioFixo);

Console.WriteLine("Digite o valor que ele recebe por carro vendido: ");
double valorPorCarroVendido = 0;
double.TryParse(Console.ReadLine(), out valorPorCarroVendido);

double totalRecebidoCarroVendido = valorPorCarroVendido * quantidadeCarrosVendidos;
double comissaoVendasEfetuadas = valorTotalVendas * COMISSAO;
double salarioFinalVendedor = salarioFixo + totalRecebidoCarroVendido + comissaoVendasEfetuadas;

Console.WriteLine($"O salário final do vendedor é de R${salarioFinalVendedor} reais");

Console.ReadKey();
