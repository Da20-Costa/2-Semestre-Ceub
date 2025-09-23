using AppExemplo1POO.Model;

//Criando vários objetos: pessoa1
Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "José das Couves";
pessoa1.dataNascimento = Convert.ToDateTime("22/04/1975");
pessoa1.cpf = "555.555.555-91";
pessoa1.nomeMae = "Maria José";
pessoa1.nomePai = "João das Couves";
pessoa1.sexo = "Masculino";
Console.WriteLine(pessoa1.ImprimirPessoa());
Console.WriteLine("");
//Criando vários objetos: pessoa2
Pessoa pessoa2 = new Pessoa();
pessoa2.nome = "Lara das Couves";
pessoa2.dataNascimento = Convert.ToDateTime("20/10/1999");
pessoa2.cpf = "555.555.555-01";
pessoa2.nomeMae = "Liris José";
pessoa2.nomePai = "Murilo das Couves";
pessoa2.sexo = "Feminino";
Console.WriteLine(pessoa2.ImprimirPessoa());

