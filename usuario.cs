using System;
using System.IO;

class usuario
{
  private int idade;
  private string nome;
  private string cpf;
  private string Perfil_Risco;
  private string senha;


  public void SetIdade(int idade){
   this.idade = idade;
  }
  public int GetIdade(){
   return idade;
  }
  public void SetNome(string nome){
   this.nome = nome;
  }
  public string GetNome(){
   return nome;
  }
  public void Set_cpf(string cpf){
   this.cpf = cpf;
  }
  public string Get_cpf(){
    return cpf;
  }
  public void SetSenha(string senha){   
   this.senha = senha;
  }
  public string GetSenha(){
   return senha;
  }

  // Método responsável por criar a conta do usuário
  public void criarconta() { 
    Console.Write("Digite o seu nome: ");
    string nome = Console.ReadLine();
    // abre o stream
    Console.Write("Digite a sua Idade: ");
    idade= int.Parse(Console.ReadLine());
    Console.Write("Digite o seu CPF:");
    cpf= Console.ReadLine();
    Console.Write("Digite uma senha: ");
    string lersenha = Console.ReadLine();
    TextWriter criar = new StreamWriter("Database/Usuarios/senha.txt", append: true);
    criar.WriteLine($"{cpf};{lersenha};{nome};{idade};");
    // fecha o stream
    criar.Close();
    Console.Clear();
    Console.WriteLine("*****************************");
    Console.WriteLine("CONTA CRIADA COM SUCESSO! ");
    Console.WriteLine("Vamos para o próximo passo.");
    Console.WriteLine("*****************************");
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
  }
  // Método responsável por analisar o perfil de investidor   do usuário
  public void SetAnalise_de_perfil() {
    int soma=0;
    double result;
    Console.WriteLine("Vamos fazer um pequeno teste de perfil sobre você");
      if(idade <= 25){
      soma = soma+3;
     }
      if (idade > 25 && idade <= 50){
       soma = soma+2;
     }
      if (idade > 50 ){
       soma = soma+1;
      }  
    // Pergunta 1
    Console.WriteLine("O que você deseja conquistar com seus investimentos? (DIGITE O NÚMERO DA SUA RESPOSTA)");
    Console.WriteLine();
    Console.WriteLine("1 - Comprar algo daqui 1 ano ( Viagem, carro , começar um curso)");
    Console.WriteLine("2 - Comprar algo entre 1 e 3 anos(entrada em imovel, festa de casamento)");
    Console.WriteLine("3- Guardar por bastante tempo (Aposentadoria, Faculdade dos filhos)");
    int resposta = int.Parse(Console.ReadLine());
    if(resposta == 1){
      soma = soma+1;
    }
    if(resposta == 2){
      soma = soma +2;
    }
    if(resposta ==3){
      soma = soma+3;
    }
    Console.WriteLine();
    // Pergunta 2
    Console.WriteLine("Independente do prazo que você vai investir, você acredita que precisaria de parte do seu investimento antecipadamente? (DIGITE O NÚMERO DA SUA RESPOSTA)");
    Console.WriteLine();
    Console.WriteLine("1 - Sim, é importante ter boa parte do meu dinheiro a disposiçaõ, caso eu precise");
    Console.WriteLine("2 - Não precisarei desse dinheiro tão cedo, pode ficar um bom tempo aplicado");
    int resposta2 = int.Parse(Console.ReadLine());
    if(resposta2 == 1){
      soma= soma+1;
    }  
    if(resposta2 == 2){
      soma= soma+3;
    }  
   Console.WriteLine();
   // Pergunta 3
   Console.WriteLine("O que vem na sua cabeça quando você pensa em um invetsimento arriscado? (DIGITE O NÚMERO DA SUA RESPOSTA)");
   Console.WriteLine();
   Console.WriteLine("1 - Arriscar perder meu dinheiro?! nem pensar, prefiro algo certeiro. ");
   Console.WriteLine("2 - Uma pitadinha de risco em parte do meu dinheiro não faria mal...");
   Console.WriteLine("3 - Excelente, oportunidade de grande valorização!!");
   int resposta3 = int.Parse(Console.ReadLine());
    if(resposta3 == 1){
      soma= soma+1;
    }
     if(resposta3 == 2){
      soma= soma+2;
    }
    if(resposta3 == 3){
      soma= soma+3;
    }
    Console.WriteLine();
    // Pergunta 4
    Console.WriteLine("Digite o número do tipo de investimento que você ja tenha feito:");
    Console.WriteLine();
    Console.WriteLine("1 - NUNCA fiz nenhum investimento");
    Console.WriteLine("2 - Poupança, CDB");
    Console.WriteLine("3 - Previdencia Privada, Fundos de renda fixa");
    Console.WriteLine("4 - Ações, FIIs, ETFs, Fundos de Ações, Opções");
    int resposta4 = int.Parse(Console.ReadLine());
      if(resposta4 == 1){
        soma = soma;
      }
      if(resposta4 == 2){
        soma = soma+1;
      }
      if(resposta4 == 3){
        soma = soma+2;
      }
      if(resposta4 == 4){
        soma = soma+3;
      }
      Console.WriteLine();
      // Resposta 5
      result = (soma/5);
      if(result< 2){
        Console.WriteLine("SEU PERFIL É: CONSERVADOR");
        Perfil_Risco = "conservador";
      }
      if(result< 3 && result >= 2){
        Console.WriteLine("SEU PERFIL É: MODERADO");
        Perfil_Risco = "moderado";
      }
       if(result< 4 && result >= 3){
        Console.WriteLine("SEU PERFIL É: AGRESSIVO");
        Perfil_Risco = "agressivo";
      }
  }
    

  
}
