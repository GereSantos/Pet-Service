using System;

namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa de registro de pessoas e priorização de atendimento V.1
            Random randNumber = new Random();

            Console.WriteLine("PET ANIMAL");
            Console.WriteLine("Crie o registro do seu Pet, para ter um melhor atendimento!");
            Console.Write("Deseja realizar o Cadastro? Y/N ");
            char choice = char.Parse(Console.ReadLine());
            Console.Clear();

            if(choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Seja bem vindo ao sistema de cadastro do PET ANIMAL");
                Console.WriteLine();
                Console.WriteLine("Pedimos que preencha os dados solicitados para prosseguirmos com o atendimento");
                Console.WriteLine();
                Console.Write("Dados do Dono do Animal: ");
                string Nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Data de Nascimento: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Estado de Nascimento: (Apenas Abreviação) ");
                string STD =Console.ReadLine();
                Console.Write("Insira seu CPF: ");
                string cpf = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Certo, " + Nome + ", precisamos agora saber que tipo de animal você quer tratar..");
                string chAnimal = Console.ReadLine();
                if(chAnimal == "Cachorro" || chAnimal == "cachorro")
                {
                    Console.WriteLine($"Vejo que selecionou {chAnimal}");
                    Console.Write("Nome do animal: ");
                    string animalName = Console.ReadLine();
                    Console.WriteLine("Idade do animal: ");
                    int idadeAnimal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Data da última vacina do Animal: ");
                    DateTime vacina = DateTime.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Qual tipo de tratamento o animal necessita? ");
                    Console.WriteLine("1 - Parvovirose");
                    Console.WriteLine("2 - Otite");
                    Console.WriteLine("3 - Cinomose canina");
                    Console.WriteLine("4 - Outro(Qual?)");
                    int tratAnimal = int.Parse(Console.ReadLine());
                    if(tratAnimal == 1)
                    {
                        Console.WriteLine("Tratamento selecionado Parvovirose");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }else if(tratAnimal == 2)
                    {
                        Console.WriteLine("Tratamento selecionado Otite");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 3)
                    {
                        Console.WriteLine("Tratamento selecionado Cinomose canina");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 4)
                    {
                        Console.WriteLine("Qual tratamento pretende realizar?");
                        string trat = Console.ReadLine();
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado " + "de " + trat +", para dia e horário " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco ," + Nome + ", Estamos a diposição!");
                    }

                }
                else if(chAnimal == "Gato" || chAnimal == "gato")
                {

                    Console.WriteLine($"Vejo que selecionou {chAnimal}");
                    Console.Write("Nome do animal: ");
                    string animalName = Console.ReadLine();
                    Console.WriteLine("Idade do animal: ");
                    int idadeAnimal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Data da última vacina do Animal: ");
                    DateTime vacina = DateTime.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Qual tipo de tratamento o animal necessita? ");
                    Console.WriteLine("1 - FIV (Imunodeficiência Viral Felina) ");
                    Console.WriteLine("2 - FELV (Leucemia Viral Felina)");
                    Console.WriteLine("3 - Insuficiência renal");
                    Console.WriteLine("4 - Outro(Qual?)");
                    int tratAnimal = int.Parse(Console.ReadLine());
                    if (tratAnimal == 1)
                    {
                        Console.WriteLine("Tratamento selecionado FIV (Imunodeficiência Viral Felina) ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }else if(tratAnimal == 2)
                    {
                        Console.WriteLine("Tratamento selecionado FELV (Leucemia Viral Felina) ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 3)
                    {
                        Console.WriteLine("Tratamento selecionado Insuficiência renal ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + Nome + ", Estamos a diposição!");
                    }else if(tratAnimal == 4)
                    {
                        Console.WriteLine("Qual tratamento pretende realizar?");
                        string trat = Console.ReadLine();
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado " + "de " + trat + ", para dia e horário " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco ," + Nome + ", Estamos a diposição!");
                    }
                }


            }
            else if(choice == 'N' || choice == 'n')
            {
                Console.WriteLine("Certo, iremos criar gerar um número e essa será a sua senha..");
                int password = randNumber.Next();
                Console.WriteLine("Sua senha de atendimento é: "  +  password);
                Console.WriteLine("Aguarde alguns instantes que iremos te redirecionar para o agendamento do atendimento");
                int time = 20;
                for(int i = 20; i >0; i--)
                {
                    time = time - 1;
                    Console.WriteLine($"Aguarde um momento: {i}" ) ;
                }
                Console.WriteLine("Tempo restante: " + time);
                
                Console.WriteLine("Devo te chamar de..? ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Certo, " + name + ", precisamos agora saber que tipo de animal você quer tratar..");
                string chAnimal = Console.ReadLine();
                if (chAnimal == "Cachorro" || chAnimal == "cachorro")
                {
                    Console.WriteLine($"Vejo que selecionou {chAnimal}");
                    Console.Write("Nome do animal: ");
                    string animalName = Console.ReadLine();
                    Console.Write("Idade do animal: (apenas número) ");
                    int idadeAnimal = int.Parse(Console.ReadLine());
                    Console.Write("Data da última vacina do Animal: ");
                    DateTime vacina = DateTime.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Qual tipo de tratamento o animal necessita? ");
                    Console.WriteLine("1 - Parvovirose");
                    Console.WriteLine("2 - Otite");
                    Console.WriteLine("3 - Cinomose canina");
                    Console.WriteLine("4 - Outro(Qual?)");
                    int tratAnimal = int.Parse(Console.ReadLine());
                    if (tratAnimal == 1)
                    {
                        Console.WriteLine("Tratamento selecionado Parvovirose");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 2)
                    {
                        Console.WriteLine("Tratamento selecionado Otite");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 3)
                    {
                        Console.WriteLine("Tratamento selecionado Cinomose canina");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 4)
                    {
                        Console.WriteLine("Qual tratamento pretende realizar?");
                        string trat = Console.ReadLine();
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado " + "de " + trat + ", para dia e horário " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco ," + name + ", Estamos a diposição!");
                    }

                }
                else if (chAnimal == "Gato" || chAnimal == "gato")
                {

                    Console.WriteLine($"Vejo que selecionou {chAnimal}");
                    Console.Write("Nome do animal: ");
                    string animalName = Console.ReadLine();
                    Console.Write("Idade do animal: (apenas número) ");
                    int idadeAnimal = int.Parse(Console.ReadLine());
                    Console.Write("Data da última vacina do Animal: ");
                    DateTime vacina = DateTime.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Qual tipo de tratamento o animal necessita? ");
                    Console.WriteLine("1 - FIV (Imunodeficiência Viral Felina) ");
                    Console.WriteLine("2 - FELV (Leucemia Viral Felina)");
                    Console.WriteLine("3 - Insuficiência renal");
                    Console.WriteLine("4 - Outro(Qual?)");
                    int tratAnimal = int.Parse(Console.ReadLine());
                    if (tratAnimal == 1)
                    {
                        Console.WriteLine("Tratamento selecionado FIV (Imunodeficiência Viral Felina) ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 2)
                    {
                        Console.WriteLine("Tratamento selecionado FELV (Leucemia Viral Felina) ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 3)
                    {
                        Console.WriteLine("Tratamento selecionado Insuficiência renal ");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado para " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco " + name + ", Estamos a diposição!");
                    }
                    else if (tratAnimal == 4)
                    {
                        Console.WriteLine("Qual tratamento pretende realizar?");
                        string trat = Console.ReadLine();
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.WriteLine("Gerando data...");
                        Console.Clear();
                        Console.WriteLine("Atendimento marcado " + "de " + trat + ", para dia e horário " + DateTime.UtcNow);
                        Console.WriteLine("Obrigado por contar conosco ," + name + ", Estamos a diposição!");
                    }
                }

            }
            else
            {
                Console.WriteLine("Fora de escopo!");
            }
        }
    }
}

