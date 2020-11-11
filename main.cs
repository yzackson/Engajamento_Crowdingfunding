using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    string name, email;
    string title, type, description;
    int choice, run = 1;
    int vote, totalVotes = 0;

    Idea newIdea = new Idea();

    List<Idea> ideas = new List<Idea>();

    List<string> titleList = new List<string>{"Caseiro", "Babá", "Serviços de Limpeza de Janelas", "Anfitrião do Airbnb", "Livros Eletrônicos", "Revisor e Editor de Textos Freelancer", "Dublador / Narrador", "Ghostwriter"};

    List<string> typeList = new List<string>{"negócios domésticos", "negócios domésticos", "negócios domésticos", "negócios domésticos", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer", "Ideias de negócios para freelancer"};

    List<string> descriptionList = new List<string>{"Não é exatamente uma maneira de ganhar dinheiro consistentemente, mas ser caseiro, ou seja, cuidar da propriedade de outra pessoa, é uma maneira fantástica de viver em locais exóticos de todo o mundo sem pagar um centavo de aluguel.", "Ser babá não é algo apenas para adolescentes e estudantes universitários. Muito pelo contrário, se você for fazer um Au Pair, por exemplo, você pode ganhar bastante dinheiro trabalhando durante as noites e fins de semana – se você não se importar com o horário.", "Quando estou do lado de dentro de uma casa ou prédio, o que eu espero é poder ver o mundo lá fora da maneira mais clara possível. E é isso que muitos outros proprietários de casas e gerentes de escritórios também desejam. Isso cria uma demanda muito boa para empresas de limpadores de janelas, especialmente, para quem pode limpar janelas de edifícios comerciais. Isso se você gosta de adrenalina.", "O Airbnb é apenas uma ótima maneira de ganhar dinheiro alugando o seu quarto de hóspedes ou a sua sala de estar, mas além disso, é uma ótima maneira de conhecer novas pessoas e fazer novos amigos se você gostar deste tipo de coisa. Você pode até alugar um apartamento só para receber hóspedes do Airbnb e receber uma grana extra, contudo, não pense que esta será apenas uma fonte de renda passiva – você precisará estar de plantão sempre que você receber um convidado e você vai sempre precisa manter o lugar limpo para quando os hóspedes chegarem.", "Empregar as suas habilidades e o seu conhecimento em um eBook para download que oferece valor para aqueles que procuram aprender algo, avançar em suas carreiras ou começar os seus próprios negócios, é uma forte proposta de valor se você segmentar o público certo. Seja dedicado ao seu eBook, crie uma audiência e você terá uma base para apresentar o seu livro às editoras tradicionais e fechar um acordo de lançamento – então você pode escrever um dos melhores livros de negócios e realmente criar sua marca pessoal.", "Enquanto ainda houver a palavra escrita, sempre haverá necessidade de editores e revisores. A edição e a revisão independente não só pagam um salário decente por hora, mas também lhe dão a oportunidade de ler sobre temas potencialmente interessantes. Além disso, escrever e editar textos como freelancer podem proporcionar-lhe um estilo de vida que permita a você viajar pelo mundo como um nômade digital. Você pode encontrar muitas oportunidades de trabalho de empresas e indivíduos que precisam de serviços de redação, revisão e edição no Upwork.", "Se você fala como James Earl Jones ou Scarlett Johansson, uma série de editores digitais (incluindo desenvolvedores de jogos, cineastas de animação e produtores de vídeo de treinamento) pagam muito dinheiro para terem a sua voz talentosa dublando ou narrando seus materiais. O seu investimento para esse fim não é muito intensivo. Ou seja, uma grande ideia de negócio. Você pode encontrar esses editores à procura de sua voz em sites como o PeoplePerHour, Freelancer e Upwork.", "O Ghostwriting paga muito bem e se você é talentoso em pesquisar e criar conteúdo excelente sobre um determinado assunto, você pode construir rapidamente uma lista de clientes que remuneram muito bem. Escritores como Jeff Haden criaram carreiras muito lucrativas para si mesmos, escrevendo para executivos de empresas e CEOs – e Jeff também começou a sua carreira de ghostwriting como um trabalho paralelo enquanto trabalhava de gerente de uma fábrica em tempo integral."};

    List<string> nameList = new List<string>{"Alexandre", "André", "Antônio", "Eduardo", "Agatha", "Camila", "Esther", "Isis"};

    for (int i = 0; i<titleList.Count; i++) {
      newIdea = new Idea(titleList[i], typeList[i], descriptionList[i], nameList[i]);
      ideas.Add(newIdea);
    }

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

        while  {
          ideas[i].id = i + 1;
          Console.Clear();
          Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideas[i].id);
          Console.WriteLine("Título: {0}\nArea: {1}\nDescrição: {2}", ideas[i].title, ideas[i].type, ideas[i].description);
          /*Console.Write("\n\n---------- <<<<<<<<<< Ideia {0} >>>>>>>>>> ----------\n\n", ideas[i].id);*/
        }

        Console.Write("\nDigite o número da ideia escolhida: ");
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

        newIdea = new Idea(title, type, description, user.name);

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