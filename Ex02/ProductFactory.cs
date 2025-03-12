using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class ProductFactory
    {


        public static Produto CriadorProdutos (int type)
        {

            switch (type)
            {
                case 1:
                    return new Alimentacao();
                case 2:
                    return new Higiene();
                default:
                    throw new ArgumentException("Erro");
            }

        }
    }
}
