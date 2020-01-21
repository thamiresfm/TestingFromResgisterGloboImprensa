#language: pt-BR

Funcionalidade: Cadastra no site Globo Imprensa


Narrativa:
			Eu como usuário 
			Quero Cadastra no site Globo Imprensa
			Para acessar a home




Cenário:  Cadastra no Globo Imprensa 


		Dado que eu navegue para tela de cadastro
		Quando preencho  os campos de <FirstName>, <LastName>, <Nickname>, <Sex>, <Email>, <Office> ,<PublishingCompany>, <Carrier>, <Country>, <State>, <City>, <DDDTelephone>, <Telephone>, <DDDCellPhone>, <CellPhone>, <Instagram>, <Twitter>, <Password> e <RepeatPassword>
		E Clico em SOLICITAR CADASTRO
		Então aguarda a <Message>

		
		Exemplos: 

		| FirstName | LastName  | Nickname | Sex      | Email              | Office | PublishingCompany        | Carrier | Country | State               | City   | DDDTelephone | Telephone | DDDCellPhone | CellPhone | Instagram | Twitter | Password    | RepeatPassword | Message                                                                 |
		#Positivo
		| Thamires  | Fernandes | Mendes   | Feminino | T4ert8@gmail.com  | Editor | Cultura / Entretenimento | Teste   | Brasil  | RJ - Rio de Janeiro | Tanguá | 21           | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897@ | Thatha9897@    | Seu cadastro foi realizado. Aguarde a revisão e aprovação da sua conta. |
		#Negativo
		| Thamires  | Fernandes | Mendes   | Feminino | Tyyhw@gmail.com    | Editor | Cultura / Entretenimento | Teste   | Brasil  | RJ - Rio de Janeiro | Tanguá | 21           | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897@ | Thatha9897@    | Já existe um cadastro com este e-mail.                                  |
		|           |           |          |          |                    |        |                          |         |         |                     |        |              |           |              |           |           |         |             |                | Solicitação de cadastro                                                 |
		| Carlar    |           | Caca     | Feminino | T2r43w@gmail.com   | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ | Thatha9897$    | Solicitação de cadastro                                                 |
		| Carlar    | Costa     | Caca     | Feminino |                    | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ | Thatha9897$    | Solicitação de cadastro                                                 |
		| Carlar    | Costa     | Caca     | Feminino | 45tgh@gmail.com    | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   | Thatha9897$ |                | Solicitação de cadastro                                                 |
		| Carlar    | Costa     | Caca     | Feminino | io322k67@gmail.com | Editor | Cultura / Entretenimento | Teste   | 21      | 21897656            | 21     | 23467809     | 21897656  | 21           | 23467809  | thayn     | theuu   |             | Thatha9897$    | Solicitação de cadastro                                                 |