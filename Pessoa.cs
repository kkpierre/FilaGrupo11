using System;

class Pessoa
{
    public string nome;
    public string telefone;
    public bool preferencial;

    public void Cadastrar()
    {
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Telefone: ");
        telefone = Console.ReadLine();

        Console.Write("Preferencial? (s/n): ");
        string resp = Console.ReadLine();
        resp = resp.ToLower();

        if (resp == "s")
        {
            preferencial = true;
        }
        else
        {
            preferencial = false;
        }
    }
}