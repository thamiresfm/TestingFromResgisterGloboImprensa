#language: pt-BR

Funcionalidade: Cadastrar no site Globo Imprensa

Narrativa:
			Eu como usuário 
			Quero Cadastrar no site Globo Imprensa
			Para acessar a home
					   			 
Cenário:  Cadastrar no Globo Imprensa com sucesso

		Dado que eu navegue para tela de cadastro
		Quando preencho  os campos de <FirstName>, <LastName>, <Nickname>, <Sex>, <Email>, <Office> ,<PublishingCompany>, <Carrier>, <Country>, <State>, <City>, <DDDTelephone>, <Telephone>, <DDDCellPhone>, <CellPhone>, <Instagram>, <Twitter>, <Password> e <RepeatPassword>
		E Clico em SOLICITAR CADASTRO
		Então aguarda a <Message> com sucesso

		Exemplos: 
		
			#Positivo
		| FirstName | LastName  | Nickname | Sex      | Email                 | Office | PublishingCompany        | Carrier | Country | State               | City   | DDDTelephone | Telephone | DDDCellPhone | CellPhone | Instagram | Twitter | Password    | RepeatPassword | Message                                                                 |
		| Thamires  | Fernandes | Mendes   | Feminino | Tet898ty@gmail.com | Editor | Cultura / Entretenimento | Teste   | Brasil  | RJ - Rio de Janeiro | Tanguá | 21           | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897@ | Thatha9897@    | Seu cadastro foi realizado. Aguarde a revisão e aprovação da sua conta. |
		
		
Cenário:  Cadastrar no Globo Imprensa sem sucesso

		Dado que eu navegue para tela de cadastro
		Quando preencho  os campos de <FirstName>, <LastName>, <Nickname>, <Sex>, <Email>, <Office> ,<PublishingCompany>, <Carrier>, <Country>, <State>, <City>, <DDDTelephone>, <Telephone>, <DDDCellPhone>, <CellPhone>, <Instagram>, <Twitter>, <Password> e <RepeatPassword>
		E Clico em SOLICITAR CADASTRO
		Então aguarda a <Message> sem sucesso

		Exemplos: 
	
		
		#Negativo
		| FirstName | LastName  | Nickname | Sex      | Email                 | Office | PublishingCompany        | Carrier | Country | State               | City   | DDDTelephone | Telephone | DDDCellPhone | CellPhone | Instagram | Twitter | Password    | RepeatPassword | Message                                |
		| Thamires  | Fernandes | Mendes   | Feminino | T4tywe89338@gmail.com | Editor | Cultura / Entretenimento | Teste   | Brasil  | RJ - Rio de Janeiro | Tanguá | 21           | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897@ | Thatha9897@    | Já existe um cadastro com este e-mail. |
		|           |           |          |          |                       |        |                          |         |         |                     |        |              |           |              |           |           |         |             |                | Solicitação de cadastro                |
		| Carlar    |           | Caca     | Feminino | T8ryy3w@gmail.com     | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ | Thatha9897$    | Solicitação de cadastro                |
		| Carlar    | Costa     | Caca     | Feminino |                       | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ | Thatha9897$    | Solicitação de cadastro                |
		| Carlar    | Costa     | Caca     | Feminino | 4576ut76@gmail.com    | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ |                | Solicitação de cadastro                |
		| Carlar    | Costa     | Caca     | Feminino | i87uiy5667@gmail.com  | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   |             | Thatha9897$    | Solicitação de cadastro                |


	

