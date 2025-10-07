using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvores
{

    // o T -> O tezão é a especificação de um tipo genérico(generics   )
    public class TreeNode<T>
    {
        // o atributo data do tipo generic T armazenara o valor de fato
        public T data { get; set; }
        // o atributo parent será a referencia ao Nó pai da arvore 
        public TreeNode<T> parent { get; set; }
        // o atributo children será a referencia a lista de filhos do nó também do tipo generico T
        public List<TreeNode<T>> children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.parent != null)
            {
                height++;
                current = current.parent;
            }
            return height;
        }
    }

}