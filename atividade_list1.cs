/*
-Implemente os TADs Fila e Pilha utilizando a estrutura de dados concreta lista simplesmente encadeada.
-Implemente o TAD Fila usando duas pilhas. Avalie o tempo de execução dos algoritmos enqueue deenqueue
-Implemente o TAD Pilha usando duas filas para armazenar seus elementos. Qual o tempo de execução das
operações push e pop neste caso?
- IMPLEMENTE EM JAVA/C# o TAD Pilha utilizando uma Lista Simplesmente Encadeada
*/

using System;

public class No<T>
{
    public T Valor { get; set; }
    public No<T> Proximo { get; set; }
}

public class PilhaEncadeada<T>
{
    private No<T> topo;

    public void Push(T item)
    {
        var novoNo = new No<T> { Valor = item };
        novoNo.Proximo = topo;
        topo = novoNo;
    }

    public T Pop()
    {
        if (topo == null)
        {
            throw new InvalidOperationException("A pilha está vazia");
        }

        var valor = topo.Valor;
        topo = topo.Proximo;
        return valor;
    }

    public T Peek()
    {
        if (topo == null)
        {
            throw new InvalidOperationException("A pilha está vazia");
        }

        return topo.Valor;
    }

    public bool IsEmpty()
    {
        return topo == null;
    }
}

public class FilaEncadeada<T>
{
    private No<T> inicio, fim;

    public void Enqueue(T item)
    {
        var novoNo = new No<T> { Valor = item };
        if (inicio == null)
        {
            inicio = fim = novoNo;
        }
        else
        {
            fim.Proximo = novoNo;
            fim = novoNo;
        }
    }

    public T Dequeue()
    {
        if (inicio == null)
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        var valor = inicio.Valor;
        inicio = inicio.Proximo;
        if (inicio == null)
        {
            fim = null;
        }
        return valor;
    }

    public T Peek()
    {
        if (inicio == null)
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        return inicio.Valor;
    }

    public bool IsEmpty()
    {
        return inicio == null;
    }
}

public class FilaComDuasPilhas<T>
{
    ...
}