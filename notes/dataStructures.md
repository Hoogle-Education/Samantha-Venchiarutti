# Estruturas de Dados

## Lista

- A Lista nao possui tamanho definido, mas podemos definir uma capacidade maxima.
- A lista eh homogenea
- Listas sao Wrapper Class que envolvem uma estrutura simples e acrescenta funcionalidades em cima dela.

```cs
List<int> meusNumeros = new List<int>();
List<int> meusNumeros = new(); // short declaration
```

## Metodos

- Add

```cs
meusNumeros.Add(1);
meusNumeros.Add(2);
meusNumeros.Add(3); // {1, 2, 3}
```

- Contains
- IndexOf
- Remove

> CRUD e listas sao muito proximos
> Listas sao usadas em composicoes

## Relacionamentos

### Heranca

Herança é um tipo de relacionamento feito para compartilhar atributos, métodos ou properties.

### Agregacao

Pessoa tem uma Conta

1. Um pra Um

```
Pessoa {
  Conta conta;
}

Conta {
  Pessoa pessoa;
}
```

Usuario do Linkedin e Postagens

Um pra muitos

```
Usuario {
  List<Postagem> postagens
}

Postagem {
  Usuario usuario
}
```

Usuario do Linkedin e Skills

Muitos pra Muitos

```
Usuario {
  List<Skill> skills
}

Skill {
  List<Usuario> usuarios
}
```

## Compostion over Inheritance

com heranca:

```cs
public class Person {
  public string Name {get; set;}
}

public class Student : Person {
  public string Id {get; set;}
}
```

com agregacao:

```cs
public class PersonalData {
  public string Name {get; set;}
}

public class Student {
  public string Id {get; set;}
  public PersonalData Data {get; set;}
}
```

## Wrapper

```cs
public class MinhaLista : List {
  public void Add(int elemento) {
    super.Add(0, elemento)
  }
}
```
