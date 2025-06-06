using ConsoleAppPOO.Model;
using ConsoleAppPOO.Controller;
using System.ComponentModel;
/*

Produto produto = new Produto();

List<Produto> listaProduto = new List<Produto>();

produto.Id = 1;
produto.Descricao = "bola";

listaProduto.Add(produto);


//Apresentar apenas 1 produto
//produto.Apresentar()


produto = new Produto();    
produto.Id = 2;
produto.Descricao = "Chuteira";

listaProduto.Add(produto);

//Construtor com parâmetros
Produto produto2 = new Produto(3, "Luva");


listaProduto.Add(produto2);

produto.ApresentarLista(listaProduto);
*/

BolaController controller = new BolaController();
List<Bola> lista = new List<Bola>();


Bola bola = new Bola(1, "Topper", 150m);
lista = controller.Adicionar(bola);

bola = new Bola(2, "Adidas", 300m);
lista = controller.Adicionar(bola);

bola = new Bola(3, "Nike", 330m);
lista = controller.Adicionar(bola);

controller.Listar(lista);