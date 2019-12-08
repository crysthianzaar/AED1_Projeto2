using System;
using System.IO;  

class carteira : investimentos // Herança
{
  public double lucro_prejuizo= 0;
  public double rentabilidade = 0;
  private double saldo_inicial = 0;
  public string saldo = "";
  private investimentos total;


  public void SetInvestimento (investimentos c){
    total = c;
  }

  public  void SetSaldo_inicial() {
  Console.WriteLine("Quanto de saldo disponível você tem para investir?");
  saldo_inicial = double.Parse(Console.ReadLine());
  }
  public double GetSaldo_inicial(){
    return saldo_inicial;
  }
  public double GetRentabilidade(){
    return rentabilidade;
  }

  
  public void menucarteira (){
    Console.WriteLine("*************************************");
    Console.WriteLine("************* CARTEIRA **************");
    Console.WriteLine("*************************************");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1 - CAPITAL TOTAL INVESTIDO");
    Console.WriteLine("2 - Saldo Tesouro Direto");
    Console.WriteLine("3 - Saldo Ações");
    Console.WriteLine("4 - Saldo Poupança");
    Console.WriteLine("5 - Voltar para Menu de Investimentos");
    Console.WriteLine("6 - Sair");

    string leropcao = Console.ReadLine();
      if(leropcao =="1"){
        if(leropcao == "1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("Selic.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO NO TESOURO SELIC É: R$ "+ linha);
        leitor.Close();
        entrada.Close();

      }
      if(leropcao == "1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCA2024.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO NO TESOURO IPCA 2024 É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
      }
      if(leropcao == "1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCA2035.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO NO TESOURO IPCA 2035 É: R$ "+ linha);
        leitor.Close();
        entrada.Close();

      }
      if(leropcao == "1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCAJS2023.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO NO TESOURO IPCA Com Juros Semestrais 2023 É: R$ "+ linha);
        leitor.Close();
        entrada.Close();

      }
      if(leropcao =="1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("acoes.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO EM AÇÕES É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
        
      }
      if(leropcao =="1"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("poupanca.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO EM POUPANÇA É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
      }
      Console.WriteLine("Aperte qualquer tecla para continuar");
       Console.ReadKey();
       menucarteira ();
      }
      if(leropcao == "2"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("Selic.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO NO TESOURO DIRETO É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
        Console.WriteLine("Aperte qualquer tecla para continuar");
       Console.ReadKey();
       menucarteira ();
      }
      if(leropcao =="3"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("acoes.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO EM AÇÕES É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
        Console.WriteLine("Aperte qualquer tecla para continuar");
       Console.ReadKey();
       menucarteira ();
        
      }
      if(leropcao =="4"){
        // LENDO O ARQUIVO
        Stream entrada = File.Open("poupanca.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        Console.WriteLine("SEU SALDO EM POUPANÇA É: R$ "+ linha);
        leitor.Close();
        entrada.Close();
        Console.WriteLine("Aperte qualquer tecla para continuar");
       Console.ReadKey();
       menucarteira ();
      }
      if(leropcao =="5"){
      Menu_De_Investimentos(); // Herança Da Classe Investimentos
      }
      if(leropcao =="6"){
        Environment.Exit(0);
      }
  }
}

