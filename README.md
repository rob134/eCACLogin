
# Sistema de Login no e-CAC

Este projeto implementa login no sistema e-CAC utilizando duas opções:
1. Login via **Gov.br** com usuário e senha.
2. Login via **Certificado Digital A1**.

## Como executar o projeto

### Pré-requisitos
1. Instalar o .NET 6 ou superior.
2. Configurar o caminho para o certificado digital no arquivo `CertificateLoginService.cs`.

### Execução
1. Clone o repositório.
2. Execute o seguinte comando no terminal:
   ```bash
   dotnet run
   ```
3. Siga as instruções exibidas no console.

## Observações
- A URL para autenticação Gov.br deve ser substituída por uma real.
- Certifique-se de que o certificado digital A1 esteja disponível no formato `.pfx`.
