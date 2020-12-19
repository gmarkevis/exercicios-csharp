namespace Mod4_Estatico {
    class ConversorDeMoeda {

        public static double dolarParaReal(double quantidade, double cotacao) {
            double total = quantidade * cotacao;
            return total + total * 0.06;
        }

        

    }
}
