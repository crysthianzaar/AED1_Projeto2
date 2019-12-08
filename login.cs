using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class login
{
  public bool validaSenha(string senha){
    StreamReader arquivo;
    arquivo = File.OpenText("Database/Usuarios/senha.txt");
    string original = "";// arquivo.ReadLine();
    string s;
    var Usuarios = new List<usuario>();

    while ((s = arquivo.ReadLine()) != null) 
    {
      var array = s.Split(';');
      var usuario = new usuario();
      usuario.Set_cpf(array[0]);
      usuario.SetNome(array[1]);
      usuario.SetNome(array[2]);
      usuario.SetIdade(int.Parse(array[3]));
      Usuarios.Add(usuario);
    }
    return Usuarios.Any(x => x.Get_cpf()==original);
  }
}
