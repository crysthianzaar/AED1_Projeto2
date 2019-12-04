using System;
using System.IO;
using System.Collections.Generic;

class login
{
  public bool validaSenha(string senha){
    StreamReader arquivo;
    arquivo = File.OpenText("senha.txt");
    string original = arquivo.ReadLine();
    if (senha==original){
      return true;
    }
     else{
     return false;
    }
  }
}
