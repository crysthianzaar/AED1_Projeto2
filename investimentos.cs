using System;
using System.IO;  

class investimentos
{
  private double ativosfisicos;
  public double tesouro_direto;
  public double acoes;
  public double poupanca;
  private double TaxaIPCA;
  private carteira cart;

  public void SetCarteira (carteira c){
    cart = c;
  }

  public void SetAtivosFisicos() {
  ativosfisicos = 0; // INICIAL
  }
  public double GetAtivosFisicos(){
    return ativosfisicos;
  }
  public void SetTesouro() {
  tesouro_direto = 0; // INICIAL
  }
  
  public double GetTesouro(){
    return tesouro_direto;
  }
  public void SetAllAcoes() {
  acoes = 0; // INICIAL
  }
  public double GetAcoes(){
    return acoes;
  }
  public void SetPoupanca() {
  poupanca = 0; // INICIAL
  }
  public double GetPoupanca(){
    return poupanca;
  }

  public double GetIPCA(double TaxaIPCA){
    TaxaIPCA = 3.59;
    return TaxaIPCA;
  }

  public void Recomendacao_Inicial(carteira b) {
    if (b.GetSaldo_inicial() <= 0){
      Console.WriteLine();
      Console.WriteLine("OK, não tem problema!");
      Console.WriteLine();
      Console.WriteLine("No Menu Principal você pode escolher a opção SIMULAÇÕES");
      Console.WriteLine();
      Console.WriteLine();
      Menu_De_Investimentos();
    }
    if (b.GetSaldo_inicial() > 0){
      Menu_De_Investimentos();
    }
  }

  public void Menu_De_Investimentos(){
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("******************************************");
    Console.WriteLine("************* MENU PRINCIPAL**************");
    Console.WriteLine("******************************************");
    Console.WriteLine("Escolha uma opção para adicionar ou retirar investimentos:");
    Console.WriteLine();
    Console.WriteLine("1 - Ativos físicos");
    Console.WriteLine("2 - Tesouro direto");
    Console.WriteLine("3 - Ações");
    Console.WriteLine("4 - Poupança");
    Console.WriteLine("6 - Fazer SIMULAÇÃO de investimentos");
    Console.WriteLine("7 - SAIR DO PROGRAMA");
    Console.WriteLine("8 - IR PARA SUA CARTEIRA");
    Console.WriteLine("9 - CALCULAR RENTABILIDADE DE INVESTIMENTOS");
    Console.WriteLine("10 - MODIFICAR VALORES DE RENTABILIDADE");

    string lerresposta = Console.ReadLine();

      if (lerresposta == "1"){
        AtivosFisicos();
      }
      if (lerresposta == "2"){
        TitulosTesouro();
      }
      if (lerresposta == "3"){
        SetAcoes();
      }
      if (lerresposta == "4"){
        Poupanca();
      }
      if (lerresposta == "6"){
        Simulacao();
      }
       if (lerresposta == "7"){
        Environment.Exit(0);
      }
      if (lerresposta == "8"){
       cart.menucarteira();
       }
       if (lerresposta == "9"){
        RentabilidadeSimula();
      }

  }
  public void RentabilidadeSimula(){
        Console.WriteLine("****CALCULAR RENTABILIDADE*****");
        Console.WriteLine("Digite o valor: ");
        double valorsimulado = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a rentabilidade Anual do invetimento: ");
        double rentabilidadesimulada = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tempo que deseja investir em ANOS: ");
        double tempo = double.Parse(Console.ReadLine());
        double rent = rentabilidadesimulada/100;
        double resultado = (valorsimulado*(Math.Pow(1+rent, tempo))-valorsimulado);

        Console.WriteLine("O LUCRO DESSE INVESTIMENTO SERÁ: R$ "+ resultado );
        double valorfinal = valorsimulado*(Math.Pow(1+rent, tempo));
        Console.WriteLine("O MONTANTE FINAL DESSE INVESTIMENTO SERÁ: R$ "+ valorfinal );
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
        Menu_De_Investimentos();
  }


  public void AtivosFisicos(){
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("*****Adicionar ou retirar um investimentos em ativos físicos***");
    Console.WriteLine("Digite o Valor que você deseja adicionar ou retirar em ativos físicos: ");
    // LENDO O VALOR ADICIONADO
    double lervalor = double.Parse(Console.ReadLine());
    // LENDO O ARQUIVO
    Stream entrada = File.Open("ativos_fisicos.txt", FileMode.Open);
    StreamReader leitor = new StreamReader(entrada);
    // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
    double linha = double.Parse(leitor.ReadLine());
    leitor.Close();
    entrada.Close();
    // ESCREVENDO NO ARQUIVO
    Stream saida = File.Open("ativos_fisicos.txt", FileMode.Create);
    StreamWriter escritor = new StreamWriter(saida);
    // VARIAVEL PARA SOMAR OS RESULTADOS
    double result = linha + lervalor;
    // GRAVANDO OS RESULTADOS
    escritor.WriteLine(result);
    escritor.Close();
    saida.Close();
    Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
    Menu_De_Investimentos();
  }
  public void Poupanca(){
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("*****Adicionar ou Retirar da poupança***");
    Console.WriteLine("Digite o Valor que você deseja adicionar ou Retirar da poupança ");
    // LENDO O VALOR ADICIONADO
    double lervalor = double.Parse(Console.ReadLine());
    // LENDO O ARQUIVO
    Stream entrada = File.Open("poupanca.txt", FileMode.Open);
    StreamReader leitor = new StreamReader(entrada);
    // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
    double linha = double.Parse(leitor.ReadLine());
    leitor.Close();
    entrada.Close();
    // ESCREVENDO NO ARQUIVO
    Stream saida = File.Open("poupanca.txt", FileMode.Create);
    StreamWriter escritor = new StreamWriter(saida);
    // VARIAVEL PARA SOMAR OS RESULTADOS
    double result = linha + lervalor;
    // GRAVANDO OS RESULTADOS
    escritor.WriteLine(result);
    escritor.Close();
    saida.Close();
    Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
    Menu_De_Investimentos();
  }

  public void SetAcoes(){
   Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*****Adicionar ou Retirar um investimento em Ações***");
        Console.WriteLine("Digite o Valor que você deseja Adicionar ou Retirar: ");
        // LENDO O VALOR ADICIONADO
        double lervalor = double.Parse(Console.ReadLine());
        // LENDO O ARQUIVO
        Stream entrada = File.Open("acoes.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        leitor.Close();
        entrada.Close();
        // ESCREVENDO NO ARQUIVO
        Stream saida = File.Open("acoes.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        // VARIAVEL PARA SOMAR OS RESULTADOS
        double result = linha + lervalor;
        // GRAVANDO OS RESULTADOS
        escritor.WriteLine(result);
        escritor.Close();
        saida.Close();
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
        Menu_De_Investimentos();
    }


  public void Simulacao(){
   Console.WriteLine("Qual o tipo de investimento você deseja simular? ");
   Console.WriteLine("1 - Poupança");
   Console.WriteLine("2 - CDB");
   Console.WriteLine("3 - Tesouro Direto");
   Console.WriteLine("4 - TODOS");
   string escolha = Console.ReadLine();
    if(escolha == "1"){
      Console.WriteLine("Digite o valor que você quer fazerma simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = (0.0037*valor*meses);
      Console.WriteLine("O SEU RENDIMENTO NA POUPANÇA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
      // Com base na TAXA SELIC do dia 21/10/2019
    }
    if(escolha == "2"){
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = 0.00458*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
      //Com base na TAXA SELIC e CDI do dia 21/10/2019
    }

    if(escolha == "3"){
      Console.WriteLine("USAREMOS O TESOURO SELIC COMO REFERENCIA MÉDIA!!");
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = 0.0047*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
     // SELIC referente a setembro de 2019
    }
    if(escolha == "4"){
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double poupresult = (0.0037*valor*meses);
      Console.WriteLine("O SEU RENDIMENTO NA POUPANÇA SERA: "+ poupresult + " REAIS!");
      double cdbresult = 0.00458*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NO CDB ( 100% CDI) SERA: "+ cdbresult + " REAIS!");
      double tesouroresult = 0.0047*meses*valor;
      Console.WriteLine("O SEU RENDIMENTO NO TESOURO SELIC SERA: "+ tesouroresult + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
     // SELIC referente a setembro de 2019
    }
      Console.WriteLine("Aperte qualquer tecla para continuar");
      Console.ReadKey();
    Menu_De_Investimentos();
  }

  public void TitulosTesouro(){
      Console.WriteLine("ESCOLHA A SUA OPÇÃO DO TESOURO DIRETO:");
      Console.WriteLine();
      Console.WriteLine("1 - Tesouro IPCA+ 2024	-	IPCA + 2,27% a.a");
      Console.WriteLine("2 - Tesouro IPCA+ 2035	-	IPCA + 3,17% a.a");
      Console.WriteLine("3 - Tesouro IPCA+ com Juros Semestrais 2026	-	IPCA + 2,52% a.a");
      Console.WriteLine("4 -  Tesouro Selic 2025 -	Selic + 0,  02 a.a");
      string escolha = Console.ReadLine();
      if(escolha == "1"){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*****Adicionando um investimentos***");
        Console.WriteLine("Digite o Valor que você deseja adicionar: ");
        // LENDO O VALOR ADICIONADO
        double lervalor = double.Parse(Console.ReadLine());
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCA2024.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        leitor.Close();
        entrada.Close();
        // ESCREVENDO NO ARQUIVO
        Stream saida = File.Open("IPCA2024.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        // VARIAVEL PARA SOMAR OS RESULTADOS
        double result = linha + lervalor;
        // GRAVANDO OS RESULTADOS
        escritor.WriteLine(result);
        escritor.Close();
        saida.Close();


        Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
        Menu_De_Investimentos();
      
      }
      if(escolha == "2"){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*****Adicionando um investimentos***");
        Console.WriteLine("Digite o Valor que você deseja adicionar: ");
        // LENDO O VALOR ADICIONADO
        double lervalor = double.Parse(Console.ReadLine());
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCA2035.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        leitor.Close();
        entrada.Close();
        // ESCREVENDO NO ARQUIVO
        Stream saida = File.Open("IPCA2035.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        // VARIAVEL PARA SOMAR OS RESULTADOS
        double result = linha + lervalor;
        // GRAVANDO OS RESULTADOS
        escritor.WriteLine(result);
        escritor.Close();
        saida.Close();


        Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
        Menu_De_Investimentos();
      

      }
      if(escolha == "3"){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*****Adicionando um investimentos***");
        Console.WriteLine("Digite o Valor que você deseja adicionar: ");
        // LENDO O VALOR ADICIONADO
        double lervalor = double.Parse(Console.ReadLine());
        // LENDO O ARQUIVO
        Stream entrada = File.Open("IPCAJS2026.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        leitor.Close();
        entrada.Close();
        // ESCREVENDO NO ARQUIVO
        Stream saida = File.Open("IPCAJS2026.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        // VARIAVEL PARA SOMAR OS RESULTADOS
        double result = linha + lervalor;
        // GRAVANDO OS RESULTADOS
        escritor.WriteLine(result);
        escritor.Close();
        saida.Close();


        Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
        Menu_De_Investimentos();

      }
      if(escolha == "4"){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*****Adicionando um investimentos***");
        Console.WriteLine("Digite o Valor que você deseja adicionar: ");
        // LENDO O VALOR ADICIONADO
        double lervalor = double.Parse(Console.ReadLine());
        // LENDO O ARQUIVO
        Stream entrada = File.Open("Selic.txt", FileMode.Open);
        StreamReader leitor = new StreamReader(entrada);
        // SALVANDO O QUE CONTEM NO ARQUIVO  ACIMA
        double linha = double.Parse(leitor.ReadLine());
        leitor.Close();
        entrada.Close();
        // ESCREVENDO NO ARQUIVO
        Stream saida = File.Open("Selic.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        // VARIAVEL PARA SOMAR OS RESULTADOS
        double result = linha + lervalor;
        // GRAVANDO OS RESULTADOS
        escritor.WriteLine(result);
        escritor.Close();
        saida.Close();
        Console.WriteLine("****ADICIONADO COM SUCESSO A SUA CARTEIRA*****");
        Menu_De_Investimentos();
      }
    }
}
