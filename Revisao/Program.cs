using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indeceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }

                        alunos [indeceAluno] = aluno;
                        indeceAluno++;

                        break;

                    case "2":
                        foreach(var i in alunos)
                        {
                            if(!string.IsNullOrEmpty(i.Nome))//negação da string for nul ou vazia
                            {
                                Console.WriteLine($"Aluno: {i.Nome} - Nota: {i.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        int qtdAlunos = 0;

                        for (int i = 0; i < alunos.Length; i ++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                qtdAlunos ++;
                            }
                        }
                            var mediaGeral = notaTotal / qtdAlunos;//dividindo a nota geral

                            EConceito conceitoGeral;

                            if(mediaGeral < 2)
                            {
                                conceitoGeral = EConceito.E;
                            }
                            else if(mediaGeral < 4)
                            {
                                conceitoGeral = EConceito.D;
                            }
                            else if(mediaGeral < 6)
                            {
                                conceitoGeral = EConceito.C;
                            }
                            else if(mediaGeral < 8)
                            {
                                conceitoGeral = EConceito.B;
                            }
                            else
                            {
                                conceitoGeral = EConceito.A;
                            }

                            Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir um novo aluno");
            Console.WriteLine("3 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoDoUsuario = Console.ReadLine();
            return opcaoDoUsuario;
        }
    }
}
