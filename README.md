# Padrão Strategy — Exemplo dos Patos (C#)

Trabalho que implementa as classes `Pato`, `PatoDeBorracha` e `PatoDeFerro`
aplicando o **padrão de projeto Strategy** ao comportamento de **voar**.

## Como rodar

```bash
dotnet run
```

## Estrutura do projeto

| Arquivo | Papel no padrão |
|---|---|
| `IEstrategiaVoo.cs` | **Strategy** — a interface (o contrato do comportamento) |
| `VoarComAsas.cs` | **Estratégia concreta** — voa batendo as asas |
| `NaoVoar.cs` | **Estratégia concreta** — não voa |
| `VoarComPropulsao.cs` | **Estratégia concreta** — voa com propulsão a jato |
| `Pato.cs` | **Contexto** — tem uma estratégia e delega o `Voar()` a ela |
| `PatoDeBorracha.cs` | Herda de `Pato`, usa a estratégia `NaoVoar` |
| `PatoDeFerro.cs` | Herda de `Pato`, usa a estratégia `VoarComPropulsao` |
| `Program.cs` | Demonstração de uso |

## A ideia central

Em vez de cada pato **implementar** como voa (o que geraria código duplicado
e forçaria o pato de borracha a herdar um `voar()` que não faz sentido),
o `Pato` apenas **guarda uma estratégia de voo e delega** a ela. O *como*
voar fica isolado em classes pequenas e intercambiáveis.

```
Pato ──tem uma──> IEstrategiaVoo
                     ├── VoarComAsas
                     ├── NaoVoar
                     └── VoarComPropulsao
```

## Vantagens do Strategy neste cenário

1. **Encapsula o que varia.** O único comportamento que muda de pato para pato
   é a forma de voar. O Strategy isola exatamente essa parte, deixando o resto
   (`andar`, `mergulhar`) intacto e compartilhado.

2. **Composição em vez de herança.** O pato *tem um* comportamento de voo em vez
   de *herdar* um voo fixo. Isso evita o problema clássico da herança, em que o
   `PatoDeBorracha` herdaria um `voar()` que não deveria existir para ele.

3. **Elimina duplicação.** Dois patos que voam igual reaproveitam a mesma
   estratégia, sem copiar e colar o método `voar()`.

4. **Troca em tempo de execução.** Dá para mudar o comportamento de voo de um
   objeto já criado, com `DefinirEstrategiaVoo(...)`. Um pato de borracha pode
   "ganhar" a capacidade de voar durante a execução.

5. **Aberto para extensão, fechado para modificação (Open/Closed).** Para
   adicionar uma nova forma de voar (ex.: `VoarPlanando`), basta criar uma nova
   classe que implementa `IEstrategiaVoo`. Nenhuma classe existente precisa ser
   alterada.

6. **Facilita testes.** Cada estratégia é uma classe pequena e independente, que
   pode ser testada isoladamente. Também é fácil injetar uma estratégia "fake"
   para testar o `Pato`.

7. **Código mais legível e organizado.** Sem cadeias de `if/else` ou `switch`
   decidindo como cada tipo de pato voa — cada comportamento vive na sua própria
   classe, com nome autoexplicativo.
