# IMC
[console: IMC] Calcule o Índice de Massa Corporal (IMC) do usuário.

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/4db320ff2cde68cebea226fb921247d7ebbfad33)

Exemplo:

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/1a06f59b0dcbb140bbe47fe3307752bc3dbdce49)

Exiba a situação, conforme tabela.

Resultado | Situação
--- | ---
Abaixo de 17 | Muito abaixo do peso
Entre 17 e 18,49 | Abaixo do peso
Entre 18,5 e 24,99 | Peso normal
Entre 25 e 29,99 | Acima do peso
Entre 30 e 34,99 | Obesidade I
Entre 35 e 39,99 | Obesidade II (severa)
Acima de 40 | Obesidade III (mórbida)

Ex.:
```
-- Calculadora de IMC --

Digite seu peso em kg...: 90
Digite sua altura em m..: 1,75

Seu IMC é 29,39 kg/m².
Diagnóstico: Acima do peso
```
