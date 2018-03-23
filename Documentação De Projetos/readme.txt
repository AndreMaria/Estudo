# Criando a Máquina virtual

**PARA A PRIMEIRA CRIAÇÃO DA VM** Configure as variáveis de ambiente do Windows

**USER** =SEU\_USUARIO\_DO\_GIT

**HOST\_USER** = SEU\_USUARIO\_DO\_GIT (para colaboradores que estão fora da rede Amil, incluir também essa variável de ambiente)

#### **Máquinas com Windows 8**

  -&gt; Para habilitar virtualização via hardware é necessário desabilitar o Hiper-V, abrir o prompt como Admin e executar:

  -&gt; bcdedit /set {current} hypervisorlaunchtype off

  -&gt; Reiniciar o Windows

https://social.technet.microsoft.com/Forums/en-US/7e8645d6-f6c1-4c8c-9157-e82fb5143926/hyperv-will-not-turn-off-bcdedit-hypervisorlaunchtype?forum=win10itprovirt

1. 1-Delete as pastas no caminho : C:\Users\AndreMaria\.vagrant.d\boxes
2. 2-Abrir Cywgin e digite os comandos abaixo:
3. 3-Rodar o comando **cd $USERPROFILE**
4. 4-ApósRodar o comando **git clone** [**http://github.amil.com.br/andinegri/vm.git**](http://github.amil.com.br/andinegri/vm.git)
5. 5-Entrar na pasta da vm **cd vm**
6. 6-Em seguida rodar **./install.sh**
7. 7-Após a execução dos 5 primeiros itens devemos excluir a **ssh** antiga do git hub
8. 8-Realizado o passo (6) Devemos rodar o comando **vagrant up** para iniciar a vm

** 7.1 –** Caso ocorra erros relacionados a porta configurada altere os ips no arquivo **Vagrantfile**  ** ** contido na pasta C:\Users\AndreMaria\vm somente se  necessário.

**7.** 2 – SE após a alteração ocorra com sucesso , retornar a configuração inicial do arquivo **Vagrantfile**

1. 9-Em seguida rodar **vagrant ssh**
2. 10-Logo após retornar para a pasta credenciado médico pelo comando **cd credenciado-medico**
3. 11-Atualizar projeto digitando o comando **git update**
4. 12- Executar o comando **docker-npm i**

#

# Iniciar o docker (weblogic e apache)

Para iniciar o docker , rode o seguinte comando : **docker start amil-weblogic amil-apache**

**Configurando contexto apache :**

O servidor que será responsável pelo gerenciamento da aplicação está contido na Máquina virtual. Abaixo temos os devidos passos para configuração do apache na VM.

Obs: verificar em qual branch vc está : o correto e estra na máster : e sempre atualizar.

1. 1-\*Rodar o comando : cd /vmspace/workspace/apache
2. 2-\*Rodar o comando: git update
3. 3-\*Rodar o comando: git pull
4. 4-\*Rodar o comando: cd base
5. 5-\*Rodar o comando: docker-ruby apache\_build dev
6. 6-\*Rodar o comando: cd ..
7. 7-Rodar o comando: docker stop amil-apache
8. 8-Rodar o comando para remover: docker rm amil-apache
9. 9-Rodar o comando: docker-build -t amil/apache:1.0 -t amil/apache:latest .
10. 10-Rodar o comando: docker create -v /vmspace/workspace:/app/htdocs -p 80:80 -p 443:443 --name amil-apache amil/apache
11. 11-Rodar o comando: docker start amil-apache



**Adicionar os ips no host da vm:**

No terminalCywgin digite o comando ** **** cd etc/ **para acessar a pasta do host**. **Logo após rode o comando** sudo vim hosts**.

Após executar o comando acima o prompt apresentará o conteúdo do arquivo host. Aqui devemos incluir os ips relacionados a aplicação amil.
# ùltima vez atualizada.

#
# This file is managed by Chef, using the hostsfile cookbook.
# Editing this file by hand is highly discouraged!
#
# Comments containing an @ sign should not be modified or else
# hostsfile will be unable to guarantee relative priority in
# future Chef runs!
#

127.0.0.1       localhost
127.0.1.1       vagrant.vm vagrant
172.17.0.1      amilweb weblogic dev.selenium.amil.com.br dev.amil.com.br devpublic.amil.com.br dev.static.amil.com.br dev.onehealth.com.br devpublic.onehealth.com.br dev.static.onehealth.com.br dev.lincx.com.br devpublic.lincx.com.br dev.amildental.com.br devpublic.amildental.com.br dev.static.amildental.com.br dev.lincxdental.com.br devpublic.lincxdental.com.br dev.dentalcenter.com.br devpublic.dentalcenter.com.br dev.planosamildental.com.br dev.nextsaude.com.br dev.static.nextsaude.com.br dev.galeria.amil.com.br dev.colaborador.amil.com.br dev.credenciado.amildental.com.br dev.vendas.amil.com.br dev.corretor.amil.com.br dev.inbox.amil.com.br dev.fornecedor.amil.com.br dev.credenciado.amil.com.br dev.credenciado.onehealth.com.br dev.credenciado-api.amil.com.br
10.104.45.150   amlapsr1sp0025 weblogic-qa-1    # qa wl machine
10.104.45.151   amlapsr1sp0026 weblogic-qa-2    # qa wl machine
10.104.49.29    amlsp1329       # oracle web HM
10.104.37.221   amlsp2369       # oracle web desenv
10.104.42.25    amlsp485        # qa machine
10.104.43.150   amlwebr1sp0017 apache-qa-1      # qa apache machine
10.104.43.151   amlwebr1sp0018 apache-qa-2      # qa apache machine
10.104.32.166   git.server repository.amil.com.br
10.104.28.209   github.amil.com.br
10.104.41.99    servicos-hom.amil.com.br
10.104.37.134   hdweb-scan.amil.com.br
10.104.37.79    sisamilteste1-db.grupoamil.com.br
10.104.33.60    credenciado-medico.qa.apisisamil.com.br   #    HTTP    80              Conecta QA
192.168.56.1    local.credenciado.amil.com.br topsaude.reembolso.com.br
10.104.33.60       credenciado-medico.qa.apisisamil.com.br
10.104.33.58       beneficiario.qa.apisisamil.com.br
10.104.29.105      api-credenciado-medico.dev.amil.com.br api-beneficiario.dev.amil.com.br api-guia-medica.dev.amil.com.br
10.104.33.58    api-credenciado-medico7.qa.amil.com.br
10.104.33.58    api-beneficiario7.qa.amil.com.br
10.104.33.58    api-credenciado-medico2.qa.amil.com.br
10.104.33.58    api-beneficiario2.qa.amil.com.br
10.104.33.58    api-credenciado-medico5.qa.amil.com.br
10.104.33.58    api-beneficiario5.qa.amil.com.br


172.17.0.1              dev.static.amil.com.br
172.17.0.1              dev.static.onehealth.com.br
172.17.0.1              dev.static.amildental.com.br
172.17.0.1              dev.static.nextsaude.com.br

172.17.0.1              devpublic.amil.com.br
172.17.0.1              devpublic.onehealth.com.br
172.17.0.1              devpublic.lincx.com.br
172.17.0.1              devpublic.amildental.com.br
172.17.0.1              devpublic.lincxdental.com.br
172.17.0.1              devpublic.dentalcenter.com.br

10.104.45.150   amlapsr1sp0025 weblogic-qa-1    # qa wl machine
10.104.45.151   amlapsr1sp0026 weblogic-qa-2    # qa wl machine
10.104.49.29    amlsp1329       # oracle web HM
10.104.37.221   amlsp2369       # oracle web desenv
10.104.42.25    amlsp485        # qa machine
10.104.43.150   amlwebr1sp0017 apache-qa-1      # qa apache machine
10.104.43.151   amlwebr1sp0018 apache-qa-2      # qa apache machine
10.104.32.166   git.server repository.amil.com.br
10.104.28.209   github.amil.com.br

10.104.41.99    servicos-hom.amil.com.br
10.104.53.226   apprelayhomolog.amil.com.br
10.104.33.123   wsbenefserviceh.amil.com.br
10.104.33.122   wssisamilhomolog.amil.com.br
10.104.33.140   wssisodontohomolog.amil.com.br
10.104.33.184   sisamil1.qa.amil.com.br
10.104.33.203   sisamil3.qa.amil.com.br
10.104.32.27    sisamil4.qa.amil.com.br
10.104.32.30    sisamil7.qa.amil.com.br
10.104.32.29    sisamil6.qa.amil.com.br
"hosts" 127L, 5884C

**Obs** : Para adicionar o ip é necessário pressionar a i para habilitar o INSERT e em seguida usar as setas até última linha e pressiona enter em seguinda colar o endereço. Para salvar o arquivo pressione a tecla ESC em seguinda digite :wq







**Refazer o apache :**

cd apache

cat README.md

cd base

docker-ruby apache\_build dev

cd ..

docker stop amil-apache

docker rm amil-apache

docker-build -t amil/apache:1.0 -t amil/apache:latest .

docker create -v /vmspace/workspace:/app/htdocs -p 80:80 -p 443:443 --name amil-apache amil/apache

docker start amil-apache

sudo systemctl restart dnsmasq

cd credenciado-medico

**Integrar backend:**

1 - Acesse o diretório : cd vmspace cd workspace

2 - Clone o repositório do oauth: git clone-repo oauth-server

3 - Entre na pasta do oauth : cd oauth-server sbt clean package

4- acessar o weblogic : **http://192.169.33.10:7100/console/ para configuração do oauth-server**

Passo :

Clique em implantações

Clique em /project/workspace/oauth-server/target

webapp

próximo

Instalar esta implantação como uma aplicação

próximo

5 - Congigurando o Apache : cd apache

6 - Dentro do credenciado médico digite os comandos :cd base docker-run amil/gruntbower:latest ruby apache\_build dev cd .. docker-build -t amil/apache:1.0 -t amil/apache:latest .

**Integrar Credenciado Medico**

**Este caso só se aplica para VM que possui outros projetos.**



1 - acessar o weblogic : http://192.169.33.10:7100/console/ para configuração do

2- Clique em implantações

3- Instalar

4- /project/workspace/credenciado-medico/target

5- próximo

6- Instalar esta implantação como uma aplicação

7- próximo

8- Finalizar.

9 - Congigurando o Apache : cd apache

10 - Dentro do credenciado médico digite os comandos :cd base docker-run amil/gruntbower:latest ruby apache\_build dev cd .. docker-build -t amil/apache:1.0 -t amil/apache:latest .





**Gerar data sources:**

1 - Entre no diretório : cd environment

2 - Vá até a pasta : cd /vmspace/workspace/environment/scripts

3 - Execute o script docker : ./docker-datasources.sh

4 -cd credenciado-medico

5 - sbt clean package

6 - docker restart amil-weblogic amil-apache

7 - cd apache/

8 - grep -rl &#39;10.104.29.105&#39; ./ | xargs sed -i &#39;s/10.104.29.105/10.104.33.60/g&#39;

9 - cd credenciado-medico

10- docker-npm run build-dev



[**http://dev.credenciado.amil.com.br/**](http://dev.credenciado.amil.com.br/)



# Ligar a VM e iniciar o projeto.

cd $USERPROFILE/vm

vagrant up

vagrant ssh

cd credenciado-medico

docker start amil-weblogic amil-apache

docker-npm run build-dev



# Desligar a VM

vagrant halt

# Configurar Serviço Swagger C# na VM.

Para configurar o Serviço Swagger na Vm é preciso seguir os passos:

1. **1-** Configurar o webApi no iis.

Abra a solution Amil.Sisamil.CredenciadoMedicoApi navege até  o projeto Amil.Sisamil.CredenciadoMedico.Api

 

Navege até a opção Web 

(IMAGEM)

Selecione External Host para Servers e inclua [http://local.credenciado.amil.com.br](http://local.credenciado.amil.com.br) no campo Project Url.

Feito isso Abra o gerenciador IIS de sua máquina.

Crie um novo Site

(IMAGEM)

Preencha os campos do popup.

(IMAGEM)

(IMAGEM)

Node do Site: WebApiCredenciadoMedico

Caminho físico: C:\ghr\Credenciado-Medico-Api\Amil.Sisamil.CredenciadoMedico.Api ou o caminho correspondente ao seu projeto.

Endereço IP : 192.169.33.1

Nome do Host: local.credenciado.amil.com.br.

Realizada a configuração do site no IIS devemos incluir o ip do site no arquivo de host de sua máquina.

(IMAGEM)

1. **2-** Configurar Site na VM.

No terminalCywgin digite o comando ** **** cd etc/ **para acessar a pasta do host**. **Logo após rode o comando** sudo vim hosts**.

Inclua o Ip indicado no passo 1

(IMAGEM)

**Obs** : Para adicionar o ip é necessário pressionar a i para habilitar o INSERT e em seguida usar as setas até última linha e pressiona enter em seguinda colar o endereço. Para salvar o arquivo pressione a tecla ESC em seguinda digite :wq

1. **3-** Configurar Apache .

Abra o arquivo Y:\workspace\apache\base\ apache-env.yml e altere o campo sisamil\_credenciado\_api :  como indicado abaixo:

(IMAGEM)

Logo após Salve.

1. **4-** Configurando o Credenciado-Medico.

Abra o arquivo Y:\workspace\credenciado-medico\env\credenciado-medico-env.config

e altere a campo sisamil.server.credenciado.api.url=

(IMAGEM)

1. **5-** Refazer o Apache

cd apache

cat README.md

cd base

docker-ruby apache\_build dev

cd ..

docker stop amil-apache

docker rm amil-apache

docker-build -t amil/apache:1.0 -t amil/apache:latest .

docker create -v /vmspace/workspace:/app/htdocs -p 80:80 -p 443:443 --name amil-apache amil/apache

docker start amil-apache

sudo systemctl restart dnsmasq

cd credenciado-medico

# Teste no front

Realizar os devidos teste para o front.

  ./frontend-test.sh após Salve.

Verificar resultado dos testes

  Y:\workspace\credenciado-medico\report\cucumber\html-report

Teste Individual:

# Teste Debug No chrome

Para executar os teste rodando no navegador temos que seguir os passos abaixo:

1.
1)acessar a pasta
(IMAGEM)
2. 2)git update
3. 3)vim build-images.sh
4. 4)exclui os itens desnecessários (deixar só o &quot;vncviewer&quot;)
5. 5)salvar com o comando :wq
6. 6)./build-images.sh
7. 7)Voltar para a pasta &quot;/vmspace/workspace/credenciado-medico&quot;
8. 8)Start o xming (programa do windows)
9. 9)./frontend-test.sh --debug

(IMAGEM)

(IMAGEM)

Depois rodar o comando sbt clean package

# Correção de testes no front

export RUN\_ARGS=&#39;-p 3000:3000 -p 4000:4000&#39; ; docker-npm run serve-mock

Usuário Mock: [http://dev.credenciado.amil.com.br:3000](http://dev.credenciado.amil.com.br:3000/)

[conecta@amil.com.br](mailto:conecta@amil.com.br) 1234

00563719001

(IMAGEM)

(IMAGEM)

(IMAGEM)

#

# Compilar teste Visual Studio Code

1. 1)Instalar node versão 6.11.1
2. 2)Abrir cmd do windows
3. 3)npm install [protractor@5.1.1](mailto:protractor@5.1.1) –g
4. 4)cd %USERPROFILE%\\AppData\\Roaming\\npm\\node\_modules\\protractor\\node\_modules
5. 5)npm install selenium-webdriver
6. 6)npm install webdriver-manager
7. 7)npm install chromedriver -g
8. 8)webdriver-manager update
9. 9)webdriver-manager start (permitir acesso e depois dar ctrl + c pra sair)
10. 10)export RUN\_ARGS=&#39;-p 3000:3000 -p 4000:4000&#39; ; docker-npm run serve-mock
11.
11)com o arquivo &lt;config.js&gt; (configuração do protractor personalizada) vamos incluir no projeto ![](data:image/*;base64,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)
12. 12)Configurar tag: no arquivo config.js incluir no atributo tags o valor indicado no cenário que deseja rodar : Exemplo tags @andre
13. 13)Fechar cmd e abrir um novo cmd
14. 14)Rodar no cmd do Windows :  node %USERPROFILE%\\AppData\\Roaming\\npm\\node\_modules\\protractor\\bin\\protractor --baseUrl http://dev.credenciado.amil.com.br:3000 Y:\\workspace\\credenciado-medico\\config\\test\\config.js

# Debug teste Visual Studio Code

1. 1)export RUN\_ARGS=&#39;-p 3000:3000 -p 4000:4000&#39; ; docker-npm run serve-mock
2. 2)com o arquivo &lt;config.js&gt; (configuração do protractor personalizada) vamos incluir no projeto
3. 3)Configurar tag: no arquivo config.js incluir no atributo tags o valor indicado no cenário que deseja rodar : Exemplo tags @andre
4. 4)Adicionar a configuração do Debug no Visual Studio Code

(IMAGEM)

1. 5)Start debug Visual Studio Code

#

#

# Verificar logs de acesso na VM

#

sudo tail -f -n 1000 /vmspace/docker-data/weblogic/logs/std.out.credenciado-medico/credenciado-medico-integrations.log

ou

sudo tail -f -n 1000 /vmspace/docker-data/weblogic/logs/std.out.portal/portal.log

dar permissão de acesso.

sudo chmod -R 777 std.out.corretor/

# Trocar senha usuário

Incluir o ip baixo no arquido de host do windows

10.104.37.134                   hdweb-scan.amil.com.br

Incluir o comando abaixo no arquivo tnsnames.ora

**AMIL\_CREDMEDICO\_DESENV =**

**  (DESCRIPTION =**

**   **** (ADDRESS = (PROTOCOL = TCP)(HOST = hdweb-scan.amil.com.br)(PORT = 1521))**

**    (CONNECT\_DATA =**

**      (SERVER = DEDICATED)**

**      (SERVICE\_NAME = srvdweb)**

**   ** **)**

**  )**

Logos após você deve logar com o usuário

(IMAGEM)

Clicar em Esqueci minha senha

(IMAGEM)

Para preencher o campo cpf você deve buscar esse valor no banco

(IMAGEM)

O Password é Am1l#

(IMAGEM)

(IMAGEM)

Logo após clique em enviar.

(IMAGEM)

Logo após execute a query abaixo no banco

(IMAGEM)

[https://dev.credenciado.amil.com.br/recuperacao-senha](https://dev.credenciado.amil.com.br/recuperacao-senha/%7bCampo_Token%7d) [/{Campo\_Token}](https://dev.credenciado.amil.com.br/recuperacao-senha/%7bCampo_Token%7d)

(IMAGEM)

Aqui já podemos redefinir uma nova senha

Habilitando ambiente Portal

(IMAGEM)

(IMAGEM)

alias compila\_portal=&#39;cd middleware &amp;&amp; mvn clean install -Dmaven.test.skip=true &amp;&amp; cd portal &amp;&amp; sbt clean package

  7

cd middleware &amp;&amp; mvn clean install -Dmaven.test.skip=true &amp;&amp; cd portal &amp;&amp; sbt clean package

Importando os projetos para o Intellij

(IMAGEM)

docker-grunt build:dev



Likes para estudar.

Vagrant :

[https://nandovieira.com.br/usando-o-vagrant-como-ambiente-de-desenvolvimento-no-windows](https://nandovieira.com.br/usando-o-vagrant-como-ambiente-de-desenvolvimento-no-windows)

Docker :

https://woliveiras.com.br/posts/uma-rapida-introducao-ao-docker-e-instalacao-no-ubuntu/

Dicas para o Projeto

http://github.amil.com.br/multicanal-prd/vm/wiki

[https://imasters.com.br/infra/migrando-de-vms-para-containers/?trace=1519021197&amp;source=single](https://imasters.com.br/infra/migrando-de-vms-para-containers/?trace=1519021197&amp;source=single)

[https://www.howtoforge.com/tutorial/linux-grep-command/](https://www.howtoforge.com/tutorial/linux-grep-command/)

[https://www.linode.com/docs/tools-reference/How-to-grep-for-text-in-files](https://www.linode.com/docs/tools-reference/How-to-grep-for-text-in-files)

Criar pasta de anexo no weblogic

(IMAGEM)
