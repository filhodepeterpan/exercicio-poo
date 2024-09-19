using System;

class Aluno
{
    public string nome = "";
    public double nota1 = 0;
    public double nota2 = 0;

    public double calculaMedia()
    {
        return (nota1+nota2)/2;
    }

    public string classificaAluno(double media)
    {
        return media >= 7 ? "APROVADO":"REPROVADO";
    }

    public void exibeMensagem()
    {
        double obterMedia = calculaMedia();
        string obterClassificacao = classificaAluno(obterMedia);

        Console.WriteLine($"{nome} está {obterClassificacao} com média {obterMedia}");
    }

}