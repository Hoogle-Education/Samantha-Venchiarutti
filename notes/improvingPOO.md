# Improving POO

## keyword `readonly`

a variavel nao pode ser alterada apos sua declaracao.

## keyword `static`

indica que o propriedade, metodo ou variavel associado nao depende de um objeto para a chamar.

```cs
public class Contraints {
  public readonly static double Constraint1 = 2.131682;
}
```

```cs
int result = Contraints.Constraint1 * factor;
```

```cs
public class RectangleService {
  public static double CalculateArea(double width, double height) {
    return width*height;
  }
}
```

```cs
int result = RectangleService.CalculateArea(2.0, 3.0);
int twoRaiseFive = Math.Pow(2.0, 5.0); // chamada estatica = sem objeto
```

## Herança

```java
public class Pessoa {
  public string Nome {get; set;}
  public string Cpf {get; set;}
  public int Idade {get; set;}
}

public class Aluno : Pessoa {
  public double Nota {get; set;}
}

public class Funcionario : Pessoa {
  public int CargaHoraria {get; set;}
  public double Salario {get; set;}
}
```

## Problema do diamante

No C# nao podemos fazer heranca multipla para evitar conflitos na soma de metodos e atributos das classes maes.
