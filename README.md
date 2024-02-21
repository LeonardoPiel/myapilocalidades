# myapilocalidades

Sistema feito em c# .NET 8 para gerar query de insert para todas as cidades do brasil. Utiliza a API do IBGE para fazer o request e transforma na estrutura de banco e dados customizada.

# Funcionamento
Informe a UF de uma das unidades federativas do Brasil.

O sistema irá realizar a requisição para API do IBGE e irá gerar uma query de insert para todas as cidades da UF informada.
Além disso, é necessário inserir o ufId para a montagem correta do relacionamento da query no bancoe de dados.
