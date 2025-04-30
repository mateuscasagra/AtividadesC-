João Pedro dos Santos 1 a 4
Carlos Eduardo Gonçalves Faria 5 a 7
Mateus Zandona Casagrnade 8 a 10

Questão 1
Pede para o usuario inserir um valor (senha) e feito a verificacao com if, if else para garantir que esteja dentro dos requisitos  
Questão 2
Pede para o usuario inserir um numero que deseja calcular a tabuada em seguida inica laco de repeticao que multiplica o valor inserido pelo indice do laco 
Questão 3
Faz o primeiro while verficando se a entrada e valida e em seguida executa o segundo while que calcula o valor do Fatorial
Questão 4
Faz um while para imprimir as opces do menu para o usuario em seguida um if para verificar se a entrada e valida e se for valida executa um switch que executa a opcao selecionada 
Questão 5
Pede uma palavra para o usuario e em seguida passa essa palavra em um funcao que inverte a palavra e em seguida chama outra funcao passando a palavra digitada e a palavra ao contrario que verifica se e um palindromo
Questão 6
Inicia uma nova instancia da classe Produto que possui as variaveis Nome Preco Quantidade e os metodos CadastrarProduto, ValorEmEstoque e ToString, em seguida Utiliza o metodo CadastrarProduto para cadastrar e o ToString
para mostrar o valor em estoque
Questão 7
Inicia uma nova instancia da classe Numeros que possui um array numeros com tamanho de 10 e uma variavel int totalNumerosPares, tambem possui os metodos PedeDezNumeros que faz um faco de repeticao onde imprime o indice do numero 
que o usuario esta informando e adiciona no array este numero, CalculaNumerosPares que faz um laco de repeticao para passar por todos os numeros da lista e verifica se a sobra da divisao do numero por 2 é 0 se for soma a variavel 
totalNumerosPares e ToString que imprime o Total de numeros pares, apos iniciar a instancia da classe chama o metodo PedeDezNumeros depois o CalculaNumerosPares e o ToString para imprimir 
Questão 8
Inicia uma nova instancia da classe Imc pede o peso e altura para o usuario depois chama os metodos CalculaIMC que faz peso / (altura * altura) e depois o metodo VerificaClassificacao que verifica o resultado do imc para informar se
esta abaixo, acima ou dentro do peso 
Questão 9
jogo de adivinhacao primeiro setamos o valor maximo do numero aleatorio gerado com a variavel int valorMaximo = 100; depois setamos o numero de tentativas do usuario int numeroTentativas = 0; depois uma variavel de controle booleana 
para saber se o usuario acertou ou nao bool acertou = false; depois criamos uma nova instacia da classe Ramdom classe que vai gerar nosso numero aleatorio Random random = new Random(); em seguida criamos uma variavel que recebe 
o valor aleatorio gerado pelo metodo Next da classe Ramdom int numeroPensado = random.Next(1, valorMaximo + 1); o valor incial 1, valorMaximo + 1 o mais 1 serve para que ele gere valores de 1 a 100 sem ele seria 1 a 99
em seguida imprimo no console mensagens para o usuario Console.WriteLine("Jogo de adivinhacao!"); Console.WriteLine("Qual numero estou pensando?"); depois executo um while(!acertou) a negacao do acertou e para que ele fique executando
enquanto a variavel de controle é false dentro do while peco a tentativa do usuario Console.WriteLine("Faca sua tentativa"); e armazeno dentro de uma variavel int com ReadLine int tentativa = Int32.Parse(Console.ReadLine()); é necessário 
usar o Int32.Parse para converter a entrada do usuario em numero enfim faco as verificacoes com if if (tentativa == numeroPensado) se a tentativa for igual ao numero pensado a variavel acertou vira true encerrando o laco while acertou = true;
numero de tentativas recebe +1 numeroTentativas++; utilizo 2 else if para verificar se a tentativa e maior ou menor que o numero pensado else if (tentativa > numeroPensado) else if (tentativa < numeroPensado) nas duas eu imprimo para o usuario 
se é maior ou menor e adiciono +1 ao numero de tentativas utilizo tambem um else para caso a entrada do usuario for invalida 
Questão 10
crio uma lista do tipo string para armazenar as tarefas List<string> tarefas = new List<string>(); depois uma lista tipo bool para armazenar o status da tarefa List<bool> concluida = new List<bool>(); e uma variavel de controle booleana 
para controlar o laco while bool executando = true; em seguida um while(executando) vai executar porque a variavel e verdadeira imprime as opcoes do menu Console.WriteLine("1. Adicionar tarefa"); Console.WriteLine("2. Listar tarefas");
Console.WriteLine("3. Marcar tarefa como concluída"); Console.WriteLine("4. Sair"); em seguida armazeno o valor digitado pelo usuario string opcao = Console.ReadLine(); faco um switch com o valor digitado pelo usuario switch(opcao)
com um case para cada opcao do menu case "1" case "2" case "3" no case 1 ele pede ao usuario uma tarefa e depois armazena em uma variavel Console.Write("Digite a nova tarefa: "); string tarefa = Console.ReadLine(); em seguida adiciona essa 
tarefa na lista de tarefas e na lista de concluidas adiciona false ao mesmo indice da tarefa tarefas.Add(tarefa); concluida.Add(false); break; para encerrar o switch case 2 imprime a lista de tarefas com um for que conta quantos itens tem 
na lista tarefas e faz uma verificacao "enquanto o indice i for menor que a quantidade de tarefas soma mais 1 ao i" for (int i = 0; i < tarefas.Count; i++) dentro do for ele executa os seguintes comandos 
string status = concluida[i] ? "[X]" : "[ ]"; cria uma variavel que e atribuida com o resultado de uma operacao ternaria se verdadeiro status recebe "[X]" se falso recebe "[ ]" em seguida imprime o indice + 1 porqueo 
o i comeca em zero o status e a tarefa referente ao indice atual Console.WriteLine($"{i + 1}. {status} {tarefas[i]}"); no case 3 ele pede o indice da tarefa que sera marcada como finalizada entao ele faz um if para transformar o valor inserido
em int int.TryParse(Console.ReadLine(), out int indice) e verifica se o valor e maior ou igual a 1 e se é menor ou igual a quantidade de tarefas && indice >= 1 && indice <= tarefas.Count se sim ele pega a lista de tarefas no indice informado
menos 1 porque na lista o indice comeca em 0 e reatribui com true concluida[indice - 1] = true; depois imprime que a tarefa foi concluida tem um else para caso seja informado um valor invalido no case 4 ele apenas reatribui do valor da 
variavel executando como false e da um break para que o while seja interrompido para finalizar um default que executa uma mensagem para valores que nao batem com as opcoes dos cases em seguida imprime uma mensagem de agradecimento quando
o usuario deseja finalizar o programa (case 4)
