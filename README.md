## Autores
- João Pedro dos Santos: Questões 1 a 4  
- Carlos Eduardo Gonçalves Faria: Questões 5 a 7  
- Mateus Zandona Casagrande: Questões 8 a 10  

---

### Questão 1  
Pede para o usuário inserir um valor (senha) e é feita a verificação com `if`, `if else` para garantir que esteja dentro dos requisitos.

### Questão 2  
Pede para o usuário inserir um número que deseja calcular a tabuada e, em seguida, inicia laço de repetição que multiplica o valor inserido pelo índice do laço.

### Questão 3  
Faz o primeiro `while` verificando se a entrada é válida e, em seguida, executa o segundo `while` que calcula o valor do fatorial.

### Questão 4  
Faz um `while` para imprimir as opções do menu para o usuário; em seguida, um `if` para verificar se a entrada é válida e, se for válida, executa um `switch` com a opção selecionada.

### Questão 5  
Pede uma palavra para o usuário e, em seguida, passa essa palavra em uma função que inverte a palavra. Depois chama outra função passando a palavra digitada e a palavra ao contrário que verifica se é um palíndromo.

### Questão 6  
Inicia uma nova instância da classe `Produto` que possui as variáveis `Nome`, `Preco`, `Quantidade` e os métodos `CadastrarProduto`, `ValorEmEstoque` e `ToString`. Em seguida, utiliza o método `CadastrarProduto` para cadastrar e o `ToString` para mostrar o valor em estoque.

### Questão 7  
Inicia uma nova instância da classe `Numeros`, que possui um array `numeros` com tamanho 10 e uma variável `int totalNumerosPares`. Também possui os métodos:
- `PedeDezNumeros`: faz um laço de repetição onde imprime o índice do número que o usuário está informando e adiciona no array;
- `CalculaNumerosPares`: percorre todos os números da lista e verifica se o resto da divisão do número por 2 é 0. Se for, soma na variável `totalNumerosPares`;
- `ToString`: imprime o total de números pares.  
Após iniciar a instância da classe, chama os métodos `PedeDezNumeros`, depois `CalculaNumerosPares` e `ToString` para imprimir.

### Questão 8  
Inicia uma nova instância da classe `Imc`, pede o peso e altura para o usuário, depois chama os métodos `CalculaIMC` (que faz `peso / (altura * altura)`) e `VerificaClassificacao`, que verifica o resultado do IMC para informar se está abaixo, acima ou dentro do peso.

### Questão 9  
Jogo de adivinhação:  
- Define o valor máximo do número aleatório com `int valorMaximo = 100;`
- Define o número de tentativas do usuário com `int numeroTentativas = 0;`
- Cria uma variável de controle `bool acertou = false;`
- Cria uma nova instância da classe `Random` com `Random random = new Random();`
- Gera um número aleatório com `int numeroPensado = random.Next(1, valorMaximo + 1);`  
O `+ 1` garante que o valor possa ir até 100.  
Em seguida, imprime mensagens com `Console.WriteLine` e entra em um `while (!acertou)` que continua até o usuário acertar.  
Dentro do `while`:
- Pede uma tentativa ao usuário: `int tentativa = Int32.Parse(Console.ReadLine());`
- Verifica com `if`:  
  - Se acertou, `acertou = true;`  
  - Se é maior ou menor que o número pensado, usa `else if` com mensagens apropriadas  
  - Caso contrário, imprime mensagem de entrada inválida.  
Incrementa `numeroTentativas++` a cada tentativa.

### Questão 10  
Cria uma lista do tipo `string` para armazenar as tarefas: `List<string> tarefas = new List<string>();`  
Cria uma lista tipo `bool` para armazenar o status da tarefa: `List<bool> concluida = new List<bool>();`  
Cria uma variável booleana de controle: `bool executando = true;`  
Entra em `while (executando)` que imprime o menu:
- Case 1: pede ao usuário uma tarefa com Console.Write("Digite a nova tarefa: "); string tarefa = Console.ReadLine();.
Adiciona essa tarefa na lista de tarefas com tarefas.Add(tarefa); e adiciona false na lista concluida com concluida.Add(false);, mantendo o mesmo índice.
Finaliza com break para sair do switch.
- Case 2: imprime a lista de tarefas com um for que percorre os elementos da lista com for (int i = 0; i < tarefas.Count; i++).
Dentro do for, é criada uma variável status que recebe o valor [X] se a tarefa estiver concluída (concluida[i] == true) ou [ ] se estiver pendente, usando a operação ternária string status = concluida[i] ? "[X]" : "[ ]";.
Em seguida, imprime o número da tarefa (i + 1), o status e o nome da tarefa: Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");.
- Case 3: pede ao usuário o número da tarefa a ser marcada como concluída.
Tenta converter a entrada para número com int.TryParse(Console.ReadLine(), out int indice) e verifica se o número está no intervalo válido (maior ou igual a 1 e menor ou igual à quantidade de tarefas).
Se for válido, marca a tarefa como concluída com concluida[indice - 1] = true; e exibe uma mensagem confirmando.
Se o número for inválido, exibe uma mensagem de erro.
- Case 4: reatribui o valor false para a variável executando, encerrando o laço while e finalizando o programa.
- Default: se a opção informada pelo usuário não corresponder a nenhum dos cases, exibe uma mensagem dizendo que a opção é inválida.
