# POO

## Por que fazemos?

```c#
public class Application {
  public static void Main(string[] args) {
    string[] nomes = new string[10];
    int[] idades = new int[10];
    double[] alturas = new double[10];
  }
}
```

```c#
struct Pessoa {
  string Nome;
  int Idade;
  double Altura;
}
```

## Classe e Objeto

- classe = classificacao, molde
- objeto = fruto do molde

- Classes sao tipos de variavel como qualquer outro tipo

```c#
public class Pessoa {
  public string Nome;
  public int Idade;
  public double Altura;
}

public class Application {

  public static void dizerOi(Pessoa pessoa) {
    // ...
  }

  public static void Main(string[] args) {
    Pessoa joao;

    Pessoa[] amigos = new Pessoa[10];
  }
}
```

## Criando classes

- atributos (tem)
- metodos (faz)

```c#
public class Pessoa {
  // tem - atributos
  public string Nome;
  public int Idade;
  public double Altura;

  // faz - comportamentos - metodos
  public void fazerAniversario() {
    Idade++;
  }

  public double somar(double a, double b) {
    return a + b;
  }
}
```
