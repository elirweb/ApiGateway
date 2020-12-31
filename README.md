# ApiGateway: Api de Integração de meio de Pagamento
# O que é:
ApiGateway é uma projeto que simula em ambiente real um MarketPlace com ApiGateway, como uma forma descomplicada de se comunicar.

# A quem se destina / Objetivo
Se destina a todos Devs curiosos a apreender e pode fazer o Fork. 

# Instalação Local
Com pouco conhecimento do Git, uso os comandos do Git clone e mergulhe nos codigos sem medo de ser feliz. Tenha certeza que vai apreender. Há e precisa ter uma internet e claro um PC.

# Arquitetura do Projeto
Falou de um ponto muito importante onde eu gosto muito. 
<br />Vamos lá: 
Camada Domain: Fica todas as minhas Entitys do projeto e ValuesObjects
Camada Infra / Data: Fica responsável por se comunica com banco de dados, é ela que vai persistir os dados no banco de dados. Temos Repository, configuração de banco de dados.
Camada Aplication: Responsável por fazer a orquestração, ela se comunica com a infra e domain, tem seus mapper,interfaces,repository e viewmodel,Specification etc. resumindo ela faz acontecer.
Camada Util: tem algumas validações, encriptação e decriptação, variáveis de configuração.
Camada Api / Presentation: está camada esta responsavel por ser responsável ou seja se comunicar com o cliente, mas com mudança de apreendizado mudou esta parte para Node (não está neste repositório), mas em breve vou colocar aqui.
Camada Service: Serviço WCF que foi transformado para um REST api se comunicando com outras Tecnologias emergentes.

# Tecnologias utilizadas
C#,WCF,Mongo DB (Banco de dados NoSQL)

# Arquitetura utilizadas
DDD,Design Parthen, Solid, Clean Code.






