using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

internal class Avaliacao
{

    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = nota;

        if (nota > 5) nota = 5;
        if (nota < 0) nota = 0;

    }

    public static Avaliacao Parse (string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
