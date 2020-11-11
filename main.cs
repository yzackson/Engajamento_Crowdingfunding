using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    string name, email;
    string title, type, description;
    int choice, run = 1;
    int vote, totalVotes = 0;

    List<Idea> ideas = new List<Idea>();

    Result result = new Result();

    Console.Clear();

    Console.WriteLine("Bem vind@ ao UCL BrainStorming\n");

    while (run == 1) {
      Console.Write("Nome: ");
      name = Console.ReadLine();
      /*
      if(name == "") {
        throw new ArgumentException();
      }
      */
      User user = new User(name);

      Console.Clear();

      Console.WriteLine("{0}, você deseja votar ou cadastrar uma ideia? \n[1] votar\n[2] cadastrar ideia\n", name);
      choice = int.Parse(Console.ReadLine());

      if (choice == 1) {
        /*
        if (ideas.Count == 0) {
          Console.WriteLine("Ainda não temos nehuma ideia a ser votada");
        }
        */

        for(int i = 0; i < ideas.Count; i++) {
          ideas[i].id = i + 1;
          Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideas[i].id);
          Console.Write("Título: {0}\nArea: {1}\nDescrição: {2}", ideas[i].title, ideas[i].type, ideas[i].description);
          /*Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideas[i].id);*/
        }

        Console.Write("Digite o número da ideia escolhida: ");
        vote = int.Parse(Console.ReadLine());
        vote -= 1;
        ideas[vote].votes += 1;

        for (int i = 0; i < ideas.Count; i++) {
          result.rank(ideas[i]);
        }

        totalVotes += 1;

      } else if (choice == 2) {
        Console.Clear();
        Console.WriteLine("Preencha os dados da sua ideia");
        Console.Write("Título: ");
        title = Console.ReadLine();
        Console.Write("Tipo (área de abrangência): ");
        type = Console.ReadLine();
        Console.Write("Descrição: ");
        description = Console.ReadLine();

        Idea newIdea = new Idea(title, type, description, user.name);

        ideas.Add(newIdea);

        Console.WriteLine("\nIdeia cadastrada com sucesso!\n\n");
      } else {
        Console.WriteLine("Entrada errada");
      }

      Console.WriteLine("Deseja continuar? [1] sim [2] não");
      run = int.Parse(Console.ReadLine());

      Console.Clear();

    }

  }
}