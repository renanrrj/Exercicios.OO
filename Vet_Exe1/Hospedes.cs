﻿namespace Vet_Exe1
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Hospede(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}