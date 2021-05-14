Este projeto está dividido em 2 repositórios:

Repositório Back (este): https://github.com/FernandoGonsales/BACK-CRUD-API-Angular-ASP.NET

Repositório Front: https://github.com/FernandoGonsales/FRONT-CRUD-API-Angular-ASP.NET

Instruções:

<h4>1-Importar projeto</h4>
-Crie uma pasta e clone os 2 repositórios na mesma pasta, comandos:

git clone https://github.com/FernandoGonsales/BACK-CRUD-API-Angular-ASP.NET.git

git clone https://github.com/FernandoGonsales/FRONT-CRUD-API-Angular-ASP.NET.git

<h4>2-Iniciar o back </h4>

-Inicie o visual studio code (VSCode).

-Abra uma nova janela (ctrl + shift + N).

-Selecione no canto superior esquerdo: File > Open Folder, e abra a pasta onde está localizado o back.

(Atenção, abra a pasta CRUD-WebAPI).

(exemplo: BACK-CRUD-API-Angular-ASP.NET >>> CRUD-WebAPI).

-Abra um terminal dentro do VSCode (ctrl + shift + ').

-Digite o comando abaixo no terminal para iniciar a API.


dotnet run


(exemplo: C:\Users\user-name\Desktop\Nova pasta\BACK-CRUD-API-Angular-ASP.NET\CRUD-WebAPI> dotnet run)

-Aguarde alguns segundos e você verá uma mensagem no terminal semelhante a esta:


info: Microsoft.Hosting.Lifetime[0]
      Application started.
      
      
-Com isso sua API já estará rodando.

-Você poderá acessar a url abaixo e visualizar os end-points através do swagger (opcional).

https://localhost:5001/swagger/index.html


<h4>3- Iniciar o front </h4>

-Abra uma nova janela no VSCode (ctrl + shift + N). 

Em seguida, selecione File > Open Folder e abra a pasta onde está o front.

(FRONT-CRUD-API-Angular-ASP.NET).

-Abra um terminal dentro do VSCode (ctrl + shift + ').

-Digite o comando abaixo no terminal para baixar o Angular Kit.


npm install @angular-devkit/build-angular


(exemplo: C:\Users\user-name\Desktop\Nova pasta\FRONT-CRUD-API-Angular-ASP.NET> npm install @angular-devkit/build-angular)

-Aguarde alguns segundos até a instalação finalizar.

-Após finalizar, digite o comando abaixo no terminal para iniciar o Angular Cli.


ng serve


(exemplo: C:\Users\user-name\Desktop\Nova pasta\FRONT-CRUD-API-Angular-ASP.NET> ng serve).

-Aguarde alguns segundos, até aparecer no terminal "Compiled successfully.".

-Com isso feito, você já podera acessar o site através da url: http://localhost:4200/dashboard.
