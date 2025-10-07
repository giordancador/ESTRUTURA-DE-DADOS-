using Arvores;


//DECLARACAO DE VARIAVEL TREE DO TIPO TREEE ONDE TREE<INT> AGORA É DE INTEIRO
Tree<int> tree = new Tree<int>();

//Root é o nó raiz da arvore 
//instanciando no seu tipo TreeNode 
//onde TreeNode<int> é do tipo inteiro 
tree.Root = new TreeNode<int>();
tree.Root.data = 100;

tree.Root.children = new List<TreeNode<int>>
{
    new TreeNode<int>() { data = 50, parent = tree.Root } ,
    new TreeNode<int>() { data = 1, parent = tree.Root } ,
    new TreeNode<int>() { data = 150, parent = tree.Root },
};

tree.Root.children[2].children = new List<TreeNode<int>>
{
    new TreeNode<int>() { data = 30, parent = tree.Root.children[2] } ,

};