using System;

namespace GestaoTestes.Dominio.ModuloQuestao
{
    [Serializable]
    public class Alternativa
    {   
        public string Descricao { get; set; }

        public bool AlternativaCorreta { get; private set; }
        public char Letra { get; set; }
        
        public void MarcarAlternativaCorreta()
        {
            AlternativaCorreta = true;
        }
        public string VisualizarAlternativa 
        { 
            get 
            { 
                return Letra + ") " + Descricao + "- " + (AlternativaCorreta ? "Verdadeira" : "Falsa"); 
            }
        }
    }
}