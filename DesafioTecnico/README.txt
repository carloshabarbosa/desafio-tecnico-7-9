Desafio técnico 7-9

Para rodar o projeto é necessário rodar os migrations do entity framework core, ele se encontra dentro do projeto: "DesafioTecnico.Infraestructure.Data"

Junto com o projeto, estou anexando a collection do Postman com os métodos para extrair os resultados das ações. Nele está incluso todos os métodos necessários para fazer todo o fluxo que eu imaginei.
	
	1 - Adicionar a empresa (Company/AddCompany)
	2 - Adicionar as tecnologias possíveis (Tecnology/AddTecnology)
	2 - Adicionar as tecnologias da empresa (Company/AddTecnologyToCompany)
	3 - Adicionar as vagas disponíveis (Company/AddJobOpportunity)
	4 - Adicionar os candidatos à vagas (Candidate/AddCandidate)
	5 - Extrair o resultado Final (Company/ReportByJobOpportunity)

Foi desenvolvida um api utilizando .Net core 2.1, algumas ideias de DDD, IoC, ORM.

Arquitetura do projeto
	- O projeto foi dividio em algumas camadas
		- 1-Services
			- Camada da WebApi, é o ponto de entrada da aplicação, contendo todos os end-points disponíveis. Foi utilizado o padrão Http Rest API com .NET core 2.1

		- 2-Application
			- Camada intermediária antes de acessar o domínio. O objetivo dela é expor somente os métodos necessários para o micro-serviço. Neste caso estou expondo todos os métodos, pois o único micro-serviço que vai acessar o domínio é a WebApi

		- 3-Domain
			- 3.1 Domain
				- Camada onde contém toda a regra de negócio para as ações sobre as entidade

			- 3.2 Domain.Core
				- Possui algumas abstrações que o Domain pode utilizar

		- 4-Infraestructure
			- 4.1 Infraestructure.Data
				- Camada que implementa o acesso aos dados, é onde ficam as implementações dos repositórios e os mapeamentos das entidades

			- 4.2 Infraestructure.CrossCutting.IoC
				- Camada que faz os mapeamentos das interfaces com as classes para a Injeção de dependências


