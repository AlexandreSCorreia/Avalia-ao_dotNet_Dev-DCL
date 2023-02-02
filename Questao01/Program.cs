const int DIAS_NO_ANO = 365;
const int DIAS_NO_MES = 30;

Console.WriteLine("Digite sua idade em anos: ");
int anos = 0;
int.TryParse(Console.ReadLine(), out anos);

Console.WriteLine("Digite a quantidade de meses (sem contabilizar o mês atual) a partir da data do seu último aniversário: ");
int meses = 0;
int.TryParse(Console.ReadLine(), out meses);

Console.WriteLine("Digite os dias do mês atual: ");
int dias = 0;
int.TryParse(Console.ReadLine(), out dias);

int idadeEmDias = (anos * DIAS_NO_ANO) + (meses * DIAS_NO_MES) + dias;
Console.WriteLine("Sua idade é de " + idadeEmDias + " dias.");

Console.ReadKey();
