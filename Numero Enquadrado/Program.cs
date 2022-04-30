/**********************************************
              Números enquadrados

     Autor: Lohan Batista Moreira
     Data: 30/04/2022
 
************************************************/

static int Inverter(int numero)
{

    string valor = numero.ToString();
    string resultado = "";
    for (int i = valor.Length; i > 0; i--)
    {
        resultado += valor[i - 1];
    }

    return int.Parse(resultado);
}

static void NumQuadrado()
{
    for (int i = 10; i < 99; i++)
    {
        int resultado = i + Inverter(i);
        int raiz = Convert.ToInt16(Math.Sqrt(resultado));
        if (Math.Sqrt(resultado) == raiz)
            Console.WriteLine(i);
    }
}

NumQuadrado();
