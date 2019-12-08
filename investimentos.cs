
using System;
using System.IO;  

class investimentos : usuario // Herança 
{
  private double ativosfisicos;
  public double tesouro_direto;
  public double acoes;
  public double poupanca;
  private carteira cart;

  public void SetCarteira (carteira c){
    cart = c;}
  public void SetAtivosFisicos() {
   ativosfisicos = 0; 
  }
  public double GetAtivosFisicos(){
    return ativosfisicos;
  }
  public void SetTesouro() {
   tesouro_direto = 0; 
  }
  public double GetTesouro(){
    return tesouro_direto;
  }
  public void SetAllAcoes() {
   acoes = 0; 
  }
  public double GetAcoes(){
    return acoes;
  }
  public void SetPoupanca() {
   poupanca = 0; 
  }
  public double GetPoupanca(){
    return poupanca;
  }

  // Método Estático ( usado como parametro da taxa ipca nos titulos de tesouro direto)
  public static double GetIPCA(double TaxaIPCA){
    TaxaIPCA = 0.0035;
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
    Console.WriteLine("10 - FAZER TESTE DE PERFIL DE RISCO");
    Console.WriteLine("11 - EDUCAÇÃO FINANCEIRA");


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
      if (lerresposta == "10"){
        SetAnalise_de_perfil(); // Método Herdado da classe usuarios
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
        Menu_De_Investimentos();
      }
      if (lerresposta == "1"){
        Educacao();
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
        Menu_De_Investimentos();
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
  public void Educacao(){
    Console.WriteLine("Você deseja obter informações sobre:");
    Console.WriteLine();
    Console.WriteLine("1 - Poupança");
    Console.WriteLine("2 - Tesouro Direto");
    Console.WriteLine("3 - Ações");
    string info = Console.ReadLine();
    if ( info == "1"){
     Console.WriteLine("O rendimento da poupança hoje é de 3,5% ao ano. Ou seja: se você investir R$ 100 na poupança hoje, sem dúvida sacará R$ 103,50 no ano que vem. Já o rendimento mensal da caderneta fica em 0,28%");
    }
    if ( info == "2"){
     Console.WriteLine("É um programa criado em 2002 pelo Tesouro Nacional");
     Console.WriteLine("pode-se dizer que ao comprar um título do Tesouro Direto o investidor está emprestando dinheiro ao governo.");
     Console.WriteLine("Há três grupos de títulos públicos à venda no Tesouro Direto:");
     Console.WriteLine("PRÉFIXADOS");
      Console.WriteLine();
     Console.WriteLine("Nos prefixados, no momento da compra você sabe exatamente quanto vai receber de retorno, desde que faça o resgate apenas no vencimento do título.");
      Console.WriteLine();

     Console.WriteLine("PÓS-FIXADOS");
     Console.WriteLine();
     Console.WriteLine("nos papéis pós-fixados, você conhece os critérios de remuneração, mas só saberá o retorno total do investimento no momento do resgate, uma vez que esses papéis são atrelados a um indexador que pode variar.");
     Console.WriteLine();
     Console.WriteLine("HIBRIDOS");
     Console.WriteLine();
     Console.WriteLine("há também os títulos híbridos, que têm parte da remuneração definida no momento da compra e o restante atrelado à variação da inflação.");
     Console.WriteLine();

    


    }
    if ( info == "3"){
     Console.WriteLine("Ações representam uma fração do capital social de uma empresa. Ao comprar uma ação o investidor se torna sócio da empresa, ou seja, de um negócio. Passa a correr os riscos deste negócio bem como participa dos lucros e prejuízos como qualquer empresário.");
     Console.WriteLine("Quem compra uma ação na Bolsa de Valores está levando uma pequena parte de uma empresa de terceiros e passa a ser chamado de acionista minoritário. Ser sócio de uma empresa listada na bolsa de valores traz algumas vantagens. Um exemplo disso é que enquanto a entrada ou saída na sociedade de uma empresa limitada ou de capital fechado requer um processo burocrático de alterações de contratos sociais, comprar ou vender uma ação de uma empresa listada em bolsa é um ato feito eletronicamente com poucos clicks. A liquidez do mercado acionário também permite ao investidor ter a opção de se retirar da sociedade e migrar para outro negócio mais atraente, a qualquer momento.");
    }
  



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
      Console.WriteLine("USAREMOS O TESOURO IPCA COMO REFERENCIA MÉDIA!!");
      Console.WriteLine("Digite o valor que você quer fazer a simulação:");
      double valor = double.Parse(Console.ReadLine());
      Console.WriteLine("Por quanto tempo ( EM MESES ) você pretende deixar o seu dinheiro investido");
      double meses = double.Parse(Console.ReadLine());
      double result = GetIPCA(0)*meses*valor; // Usado a variavel estática TaxaIPCA
      Console.WriteLine("O SEU RENDIMENTO NA SERA: "+ result + " REAIS!");
      Console.WriteLine("***************************");
      Console.WriteLine("ATENÇÃO!! AS TAXAS MUDAM, ESTAMOS LEVANDO EM CONTA TAXAS DE SETEMBRO DE 2019");
      Console.WriteLine("***************************");
     // IPCA referente a setembro de 2019
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
