
# gRPC: Comunicação Eficiente entre Serviços

O **gRPC** é um framework moderno para comunicação entre serviços, ideal para sistemas distribuídos que precisam ser rápidos e escaláveis. Ele funciona de forma mais eficiente que APIs REST tradicionais, utilizando o **Protobuf** (Protocol Buffers) para serializar dados de maneira compacta e performática.

## Como funciona o gRPC?

1. **Definição de Contratos**  
   No gRPC, você define um contrato (arquivo `.proto`) que especifica os métodos e as mensagens aceitas pelo serviço.  
   Exemplo: “Eu aceito pedidos de criação de produtos e respondo com um status.”

2. **Geração de Código Automática**  
   A partir do contrato, o gRPC gera código para o cliente e o servidor, garantindo que ambos falem a mesma língua.

3. **Comunicação**  
   O cliente chama métodos remotamente como se fossem locais, enquanto o servidor processa as solicitações e responde, tudo isso com alta performance graças ao **Protobuf**.

---

## Comparação: REST (JSON) vs. gRPC (Protobuf)

| Aspecto                     | REST (JSON)                         | gRPC (Protobuf)                  |
|-----------------------------|--------------------------------------|----------------------------------|
| **Formato de Dados**        | JSON (texto, mais verboso)          | Protobuf (binário, compacto)    |
| **Comunicação**             | HTTP 1.1                            | HTTP/2                          |
| **Performance**             | Menor (mais dados, mais latência)   | Maior (dados menores, mais rápido) |
| **Streaming**               | Limitado (via workarounds)          | Suporte nativo                  |
| **Definição de Contratos**  | Não obrigatório (menos rígido)      | Necessário (.proto)             |

---

## Vantagens do gRPC

1. **Alta Performance:** Dados compactos com Protobuf tornam a comunicação mais rápida.  
2. **Streaming Nativo:** Suporta comunicação bidirecional (cliente e servidor trocam mensagens em tempo real).  
3. **Contrato Forte:** O `.proto` garante que cliente e servidor tenham a mesma definição, evitando erros de comunicação.  
4. **Escalabilidade:** Ideal para sistemas distribuídos e microservices.

---

## Desvantagens do gRPC

1. **Leitura Humana:** Protobuf não é legível como JSON, dificultando debug sem ferramentas.  
2. **Curva de Aprendizado:** Requer entendimento do `.proto` e ferramentas específicas.  
3. **Integração com Browsers:** Não funciona diretamente no navegador sem adaptadores.

---

## Quando Usar?

- **Cenários Ideais:**  
  - Comunicação entre microservices.  
  - Sistemas que precisam de alta performance e baixa latência.  
  - Streaming de dados em tempo real.

- **Evitar:**  
  - Integração direta com navegadores (REST pode ser mais simples).  
  - Casos em que a legibilidade dos dados seja prioritária.

---

Explore um exemplo prático de gRPC no repositório:  
[**communication-with-grpc**](https://github.com/matteusmachhado/communication-with-grpc.git)

## 📋 Pré-requisitos

- Fundamentos de microsserviços

## 🛠️ Instalação

1. Clone este repositório:

   git clone [https://github.com/matteusmachhado/webapi-with-redis.git](https://github.com/matteusmachhado/webapi-with-redis.git)

2. Navegue até o diretório do projeto:

```
   cd [diretorio]\webapi-with-redis\docker
```

3. Execute os serviços com o Docker Compose:

```
   docker-compose up -d --build
```

 ✔ Network docker_local                       Created                                                                                                                     
 ✔ Container authentication-provider-web-api  Started                                                                                                                     
 ✔ Container product-web-api                  Started                                                                                                                     
 ✔ Container order-web-api                    Started                                                                                                                     
 ✔ Container api-gateway                      Started                                                                              

4. Acesse o swagger da WebAPI (BFF)

   Abra seu navegador e vá para http://localhost:5001/swagger/index.html

## Colaboradores

- Mateus Machado - Criador e Mantenedor

