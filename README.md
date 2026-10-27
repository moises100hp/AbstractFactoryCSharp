# Abstract Factory

Projeto de estudo em C# que demonstra o padrão de projeto **Abstract Factory** por meio da criação de componentes de interface gráfica para duas plataformas: Windows e Mac.

## O que é Abstract Factory?

Abstract Factory é um padrão criacional que fornece uma interface para criar **famílias de objetos relacionados** sem que o código cliente precise conhecer as classes concretas desses objetos.

Neste exemplo, cada família contém um botão e uma caixa de seleção. A fábrica escolhida determina a plataforma dos dois componentes, mantendo-os compatíveis entre si.

## Como o padrão aparece neste projeto

| Papel no padrão | Implementação |
| --- | --- |
| Fábrica abstrata | `IGUIFactory` declara os métodos `createButton()` e `createCheckbox()`. |
| Fábricas concretas | `WindowsFactory` e `MacFactory` criam os componentes de suas respectivas plataformas. |
| Produtos abstratos | `IButton` e `ICheckbox` definem as operações disponíveis para cada tipo de componente. |
| Produtos concretos | `WindowsButton`, `WindowsCheckbox`, `MacButton` e `MacCheckbox` implementam essas interfaces. |
| Código cliente | `Program.cs` seleciona uma fábrica e chama os métodos dos produtos sem precisar criá-los diretamente. |

O fluxo é:

1. O cliente escolhe uma implementação de `IGUIFactory`.
2. A fábrica cria um botão e uma caixa de seleção da mesma família.
3. O cliente chama `Paint()` usando as interfaces dos produtos, sem depender de suas classes concretas.
4. Para trocar a família, basta usar outra fábrica.

## Estrutura

```text
AbstractFactory/
├── Factory/
│   ├── IGUIFactory.cs
│   ├── MacFactory.cs
│   └── WindowsFactory.cs
├── Product/
│   ├── IButton.cs
│   ├── ICheckbox.cs
│   ├── MacButton.cs
│   ├── MacCheckbox.cs
│   ├── WindowsButton.cs
│   └── WindowsCheckbox.cs
├── AbstractFactory.csproj
└── Program.cs
```

## Executar

É necessário ter o SDK do .NET 8 instalado. Na raiz do repositório, execute:

```bash
dotnet run --project AbstractFactory/AbstractFactory.csproj
```

Saída atual do exemplo:

```text
Drawing Button in Windows O.S
Drawing checkbox in Windowss O.S
Drawing Button in Max O.S
Drawing Checkbox in Mac O.S
```

As mensagens são mantidas como estão no código de estudo, inclusive seus textos e grafias.
