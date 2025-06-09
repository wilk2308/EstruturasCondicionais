
# Estruturas Condicionais em C#

Este projeto em C# demonstra o uso de **estruturas condicionais** (if, else if, else e switch) por meio de três pequenos exercícios interativos no console.

## 📋 Funcionalidades

Ao executar o programa, o usuário poderá escolher entre três exercícios:

1. **Verificar o menor número**  
   O usuário informa três números inteiros, e o programa retorna o menor deles ou informa se todos são iguais.

2. **Verificar o maior número**  
   O usuário informa três números inteiros, e o programa retorna o maior deles ou informa se todos são iguais.

3. **Classificação de nível de urgência**  
   O usuário insere um número de 0 a 10 para indicar o nível de urgência de um chamado. O programa classifica o nível como:
   - `0 a 3`: BAIXO  
   - `>3 a 6`: MÉDIO  
   - `>6 a 9`: ALTO  
   - `>9`: GRAVE

## 🧠 Conceitos abordados

- Estruturas condicionais (`if`, `else if`, `else`)
- Conversão de entrada (`Convert.ToInt32`)
- Organização de código em classes e métodos
- Uso de `switch` para navegação entre funcionalidades

## 🚀 Como executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Crie um novo projeto do tipo console ou copie o código para um existente.
3. Compile e execute o projeto:

```bash
dotnet run
```

4. Siga as instruções no console para interagir com os exercícios.

## 🛠 Estrutura do código

- `Program.cs`: contém o menu principal e a lógica de navegação via `switch`.
- `Exercicio1.cs`: identifica o menor número entre três entradas.
- `Exercicio2.cs`: identifica o maior número entre três entradas.
- `Exercicio3.cs`: classifica um nível de urgência com base em um valor numérico.

## 📄 Licença

Este projeto é de uso educacional e livre para estudos e modificações.
