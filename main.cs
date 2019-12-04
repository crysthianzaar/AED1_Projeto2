using System.IO;  
using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
  string criar;
  string possui;

  investimentos a = new investimentos();
  carteira b = new carteira ();
  a.SetCarteira(b);
  b.SetInvestimento(a);
  usuario c = new usuario();
  login d = new login();

  Console.WriteLine(" Você já possui uma conta? (s = sim, n = Não)");
    possui = Console.ReadLine();
    if(possui == "s" || possui == "S"){
      Console.WriteLine(" Digite sua senha:");
     string senha = Console.ReadLine();
      if(d.validaSenha(senha) == true){

     Console.WriteLine("Aperte qualquer tecla para continuar");
     Console.ReadKey();
     a.Menu_De_Investimentos();
  }
    }
   if(possui == "n" || possui == "N"){

      Console.WriteLine(" Deseja criar uma conta? (s = sim, n = Não)");
      criar= Console.ReadLine();
      if ( criar =="s"){
      c.criarconta();
      }
      if( criar != "s"){
        Console.WriteLine(" Espero que mude de ideia em breve! :)");
       Environment.Exit(0);
      }
       c.SetAnalise_de_perfil();
    Console.WriteLine();
    Console.WriteLine("AGORA TEMOS TUDO QUE É PRECISO PARA COMEÇAR!");

    Console.WriteLine("Aperte qualquer tecla para continuar");
    Console.ReadKey();
    b.SetSaldo_inicial();
    a.Recomendacao_Inicial(b);
      }
  }
}
