using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public abstract class Produto
    {
        public string Descricao;
        private double _Preco;

        public double CalcDesconto(double percentagem)
        {
            double desconto = _Preco * percentagem / 100;
            return desconto;
        }
    }


    public class  Alimentacao : Produto
    {
        public DateTime prazo;
        public int kCalorias;


        public Alimentacao()
        {
            prazo = DateTime.Now.AddDays(30);
            kCalorias = kCalorias * 100;
        }


        public double ConverteParaEnergia(int kcalorias)
        {
            const double KJ_TO_KCAL = 0.238846;
            double result = kcalorias * KJ_TO_KCAL;
            return result;
        }

        public override string ToString() {
            return $"Descrição: {Descricao}\nPrazo: {prazo}\nKcalorias: {kCalorias}";
        }
    }


    public class Higiene : Produto
    {
        private int _ph;

        public Higiene() { 
            _ph = 7;
        
        }

        public int Ph
        {

            get { return _ph; }
            set
            {
                if (value > 0 && value <= 14)
                {
                    _ph = value;
                }
                else
                {
                    throw new ArgumentException("Valor invalido");
                }
            }
        }
        public string PHporExtenso()
        {
            if (_ph < 7)
            {
                return "Acido";
            }
            else if (_ph == 7)
            {
                return "Neutro";
            }
            else
            {
                return "Alcalino";
            }
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao}\nPh: {Ph}";
        }

    }

}

