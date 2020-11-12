using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    string name, email;
    string title, type, description;
    int choice, runProgram = 1;
    int vote, totalVotes = 0;

    Idea newIdea = new Idea(); // registra ideias

    List<Idea> ideasList = new List<Idea>(); // armazena as várias ideias

    Result result = new Result(); // inicia a classe de resultado

    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Listas que contém as ideias default para voto

    List<string> titleList = new List<string>{"Caseiro", "Babá", "Serviços de Limpeza de Janelas", "Anfitrião do Airbnb", "Livros Eletrônicos", "Revisor e Editor de Textos Freelancer", "Dublador / Narrador", "Ghostwriter"};

    List<string> typeList = new List<string>{"negócios domésticos", "negócios domésticos", "negócios domésticos", "negócios domésticos", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer"};

    List<string> descriptionList = new List<string>{"Não é exatamente uma maneira de ganhar dinheiro consistentemente, mas ser caseiro, ou seja, cuidar da propriedade de outra pessoa, é uma maneira fantástica de viver em locais exóticos de todo o mundo sem pagar um centavo de aluguel.", "Ser babá não é algo apenas para adolescentes e estudantes universitários. Muito pelo contrário, se você for fazer um Au Pair, por exemplo, você pode ganhar bastante dinheiro trabalhando durante as noites e fins de semana – se você não se importar com o horário.", "Quando estou do lado de dentro de uma casa ou prédio, o que eu espero é poder ver o mundo lá fora da maneira mais clara possível. E é isso que muitos outros proprietários de casas e gerentes de escritórios também desejam. Isso cria uma demanda muito boa para empresas de limpadores de janelas, especialmente, para quem pode limpar janelas de edifícios comerciais. Isso se você gosta de adrenalina.", "O Airbnb é apenas uma ótima maneira de ganhar dinheiro alugando o seu quarto de hóspedes ou a sua sala de estar, mas além disso, é uma ótima maneira de conhecer novas pessoas e fazer novos amigos se você gostar deste tipo de coisa. Você pode até alugar um apartamento só para receber hóspedes do Airbnb e receber uma grana extra, contudo, não pense que esta será apenas uma fonte de renda passiva – você precisará estar de plantão sempre que você receber um convidado e você vai sempre precisa manter o lugar limpo para quando os hóspedes chegarem.", "Empregar as suas habilidades e o seu conhecimento em um eBook para download que oferece valor para aqueles que procuram aprender algo, avançar em suas carreiras ou começar os seus próprios negócios, é uma forte proposta de valor se você segmentar o público certo. Seja dedicado ao seu eBook, crie uma audiência e você terá uma base para apresentar o seu livro às editoras tradicionais e fechar um acordo de lançamento – então você pode escrever um dos melhores livros de negócios e realmente criar sua marca pessoal.", "Enquanto ainda houver a palavra escrita, sempre haverá necessidade de editores e revisores. A edição e a revisão independente não só pagam um salário decente por hora, mas também lhe dão a oportunidade de ler sobre temas potencialmente interessantes. Além disso, escrever e editar textos como freelancer podem proporcionar-lhe um estilo de vida que permita a você viajar pelo mundo como um nômade digital. Você pode encontrar muitas oportunidades de trabalho de empresas e indivíduos que precisam de serviços de redação, revisão e edição no Upwork.", "Se você fala como James Earl Jones ou Scarlett Johansson, uma série de editores digitais (incluindo desenvolvedores de jogos, cineastas de animação e produtores de vídeo de treinamento) pagam muito dinheiro para terem a sua voz talentosa dublando ou narrando seus materiais. O seu investimento para esse fim não é muito intensivo. Ou seja, uma grande ideia de negócio. Você pode encontrar esses editores à procura de sua voz em sites como o PeoplePerHour, Freelancer e Upwork.", "O Ghostwriting paga muito bem e se você é talentoso em pesquisar e criar conteúdo excelente sobre um determinado assunto, você pode construir rapidamente uma lista de clientes que remuneram muito bem. Escritores como Jeff Haden criaram carreiras muito lucrativas para si mesmos, escrevendo para executivos de empresas e CEOs – e Jeff também começou a sua carreira de ghostwriting como um trabalho paralelo enquanto trabalhava de gerente de uma fábrica em tempo integral."};

    List<string> authorList = new List<string>{"Alexandre", "André", "Antônio", "Eduardo", "Agatha", "Camila", "Esther", "Isis"};

    // registra as ideias pré-definidas na lista de ideias
    for (int i = 0; i<titleList.Count; i++) {
      newIdea = new Idea(titleList[i], typeList[i], descriptionList[i], authorList[i], ideasList.Count+1);
      ideasList.Add(newIdea);
    }

    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    Console.Clear();

    Console.WriteLine("Bem vind@ ao UCL BrainStorming\n");

    // O código vai rodar enquanto o usuário não selecionar algo diferente de 1, que faz o código rodar
    
    while (runProgram == 1) {
      try{
        Console.Write("Nome: ");
        name = Console.ReadLine();

        if (name == "") {
          throw new ArgumentException();
        }

        User user = new User(name); // cria usuário

        Console.Clear();

        Console.WriteLine("{0}, você deseja votar ou cadastrar uma ideia? \n[1] votar\n[2] cadastrar ideia\n", name);
        choice = int.Parse(Console.ReadLine());

        if ((choice!=1) && (choice!=2)){
          throw new IndexOutOfRangeException();
        }

        if (choice == 1) {
          string runVote;
          int x = 0; // para mostrar as ideias

          while (true) {
            Console.Clear();
            Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideasList[x].id);
            Console.WriteLine("Título: {0}\nArea: {1}\nDescrição: {2}", ideasList[x].title, ideasList[x].type, ideasList[x].description);
            /*Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideasList[x].id);*/
            Console.WriteLine("\n\nDigite \"q\" para a ideia anterior, \"p\" para próxima ou qualquer outra tecla para sair e votar.");
            runVote = Console.ReadLine();
            if (runVote == "p") { // próxima ideia
              x+=1;
            } else if (runVote == "q") { // ideia anterior
              x-=1;
            } else {
              break;
            }
          }

          Console.Clear();

          // pega voto
          Console.Write("Digite o número da ideia escolhida: ");
          vote = int.Parse(Console.ReadLine());

          if (vote > ideasList.Count) {
            throw new IndexOutOfRangeException();
          }

          if (vote <= ideasList.Count) { // adiciona o voto a ideia
            for (int i = 0; i < ideasList.Count; i++){
              if (ideasList[i].id == vote) {
                ideasList[i].votes += 1;
              }
            }
          }
          
          // classifica a ideia
          for (int i = 0; i < ideasList.Count; i++) {
            result.rank(ideasList[i]);
          }

          totalVotes += 1;

        } else if (choice == 2) {
          Console.Clear();
          Console.WriteLine("Qual a sua ideia?");
          Console.Write("Título: ");
          title = Console.ReadLine();
          Console.Write("Tipo (área de abrangência): ");
          type = Console.ReadLine();
          Console.Write("Descrição: ");
          description = Console.ReadLine();

          newIdea = new Idea(title, type, description, user.name, ideasList.Count); // cria nova ideia

          ideasList.Add(newIdea); // adiciona na lista de ideias

          Console.WriteLine("\nIdeia cadastrada com sucesso!\n\n");

        } else {
          Console.WriteLine("Opa! Escolha errada.\n\nTente de novo.");
        }

        Console.WriteLine("\n\nDeseja continuar? [1] sim [2] não");
        runProgram = int.Parse(Console.ReadLine());

        Console.Clear();
      }
      //catch (ThrowOverflowOrFormatException) {
        //Console.WriteLine("Dígito errado!");
      //}
      catch (IndexOutOfRangeException) {
        Console.WriteLine("\nOpção inválida");
      }
      catch (ArgumentException) {
        Console.WriteLine("\nDesculpe, mas este campo não pode estar vazio");
      }
      catch (FormatException) {
        Console.WriteLine("\nOpção inválida");
      }
      finally {
        Console.WriteLine("\nDigite uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Bem vind@ ao UCL BrainStorming\n");
      }
    }
    
    try {
      Console.Write("A ideia ganhadora é . . . .\n\n{0}\n{1}\n{2}\n\nby {3}", result.winner.title, result.winner.type, result.winner.description, result.winner.author);
      Console.WriteLine("\n\nO autor dessa ideia receberá o total de R${0}", result.donation(totalVotes));

      Console.WriteLine(totalVotes);
      Console.WriteLine(result.winner.votes);
    }
    catch (DivideByZeroException) {
      Console.WriteLine("Sem votos, sem ganhador!");
    }

    Console.Read();

  }
}