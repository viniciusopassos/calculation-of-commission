<h1 align="center">Projeto Calculation Of Commission</h1>

<h2>Contexto</h2>
Sistema desenvolvido para uma revenda de automóveis que ajuda a calcular o valor a ser pago aos seus colaboradores ao final de cada mês. 

<h3>Desafios</h3>
O programa deve auxiliar e apresentar o valor total a ser pago ao colaborador, fazendo as operações matemáticas com as seguintes variáveis abaixo:

<ul>
  <li>Salário fixo no mês.</li>
  <li>Uma comissão de fixa de R$250,00 para cada carro vendido.</li>
  <li>3% do valor total das vendas realizadas.</li>
</ul>

<h3>Técnologias usadas</h3>

Desenvolvido usando: C#, xUnit (ferramenta de código aberto sob licença da Apache2 para criar testes de unidade), FluentAssertions (biblioteca com métodos e extensões para testes em ambiente .NET, ou seja, ajuda a escrever códigos melhores, legíveis e mais fáceis de entender e modificar)

<h4>clone o repositório:</h4> 

```
git clone git@github.com:viniciusopassos/calculation-of-commission.git
```

```
cd calculation-of-commission/
```

<h4>Instalando Dependências</h4>

```
cd src/	
```

```
dotnet restore
```

<h4>Executando aplicação</h4>
Para rodar a aplicação:

```
cd CommissionCalculation/
```

```
dotnet run
```


<h4>Executando Testes</h4>
Para rodar todos os testes:

```
cd CommissionCalculation.Test/
```

```
dotnet test
```
