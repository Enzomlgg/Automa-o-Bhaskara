<h1>⚙️ Automação Bhaskara - Enzo Losi</h1>

<p>
  Aqui terá um breve resumo de todo processo realizado a fins de corrigir erros pertencentes a classe de aplicação do método de Bhaskara.
</p>

<hr>

<h2>• Erro Analisados</h2>

<p>
  Durante a análise e realização de testes no projeto disponibilizado, foi possível identificar erros no cálculo de raízes que deveriam retornar valores reais e simples (como 1, 2, 3, etc.). Ao revisar o código, observou-se que, em certas partes, o cálculo do delta, bem como as operações de multiplicação e divisão envolvendo os coeficientes A, B e C, estavam com valores ou expoentes trocados ou aplicados de forma incorreta, comprometendo a correta aplicação da fórmula de Bhaskara.
</p>

<img src="Imgs/OldDelta.png" alt="Código antigo do cálculo do delta com erro" width="30%" />
<img src="Imgs/OldCalcular.png" alt="Código antigo do cálculo das raízes com erro" width="30%" /> 

<hr>

<h2>📃 Correções Aplicadas</h2>

<p>
  Diante dos erros presentes e analisados no projeto, realizei uma breve observação nas linhas do código e efetuei correções simples, porém necessárias para o funcionamento correto do sistema, realizadas nas partes de cálculo do delta da fórmula, na verificação se as raízes são reais, além do cálculo geral final. Assim, após a manutenção e correção das fórmulas matemáticas, iniciei novos testes com diversos números e valores para verificar se a aplicação da fórmula de Bhaskara estava, enfim, sendo realizada corretamente.
</p>

<img src="Imgs/NewDelta.png" alt="Código corrigido do cálculo do delta" width="30%" /> 
<img src="Imgs/NewRaizesReal.png" alt="Código corrigido da verificação de raízes reais" width="30%" /> 
<img src="Imgs/NewCalcular.png" alt="Código corrigido do cálculo das raízes" width="30%" />

<hr>

<h2>• Modificação e Testes</h2>

<p>
  Durante a etapa de testes, percebeu-se que o entendimento da conta e de seu resultado pelo operador do sistema estava dificultado. Por isso, foi realizada uma modificação no arquivo Program.cs para possibilitar a realização de múltiplas contas, retornando a fórmula escrita matematicamente, juntamente com seus respectivos resultados. Essa alteração visa proporcionar maior clareza no entendimento das operações realizadas pelo sistema, evidenciando de forma nítida a expressão matemática e as raízes calculadas.
</p>

<h2>• 1º Versão</h2>
<img src="Imgs/OldProgram.png" alt="Código antigo do arquivo Program.cs" width="30%" /> 
<img src="Imgs/OldProgramConsole.png" alt="Saída antiga do console do programa" width="30%" /> 

<h2>• 2º Versão</h2>
<img src="Imgs/NewProgram.png" alt="Código atualizado do arquivo Program.cs" width="30%" />
<img src="Imgs/NewProgramConsole.png" alt="Saída atualizada do console do programa" width="30%" />

<h2>→ Formula de Bhaskara</h2>
<img src="Imgs/baskara.png" alt="Formula de bhaskara" width="30%" />
