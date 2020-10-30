using System;
using System.Collections.Generic;
using System.Text;

namespace Ativ13
{
    class Candidato
    {
        public String nome, Partido, Profissao, CargoP;
        public double Patrimonio;

        public readonly String Municipio = "Lagoa Santa";
        public readonly String Ficha = "Limpa";

        public Candidato(String nome, String partido, String profissao, String cargoP, double patrimonio)
        {
            this.nome = nome;
            Partido = partido;
            Profissao = profissao;
            CargoP = cargoP;
            Patrimonio = patrimonio;
        }
        public override string ToString()
        {
            return $"Candidato {nome} cadastrado com sucesso!\n" +
                $"Dados da conferência:\nCandidato a prefeito de {Municipio}\n" +
                $"Nome: {nome}\nPartido: {Partido}\nPatrimônio declarado: {Math.Round(Patrimonio, 2)}\n" +
                $"Profissão: {Profissao}\nFicha limpa: {Ficha} ";
        }
    }
}
