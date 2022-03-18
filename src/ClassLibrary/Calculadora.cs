namespace ClassesLibrary
{
    public class Calculadora
    {
        public float Memoria1 { get; set; }
        public float Memoria2 { get; set; }
        public string Operacao { get; set; }

        public float Somar()
        {
            var res = Memoria1 + Memoria2;
            if (res > 100)
                throw new Exception("overflow");
            return Memoria1 + Memoria2;
        }
        public float Subtrair()
        {
            var res = Memoria1 - Memoria2;
            if (res < -100)
                throw new Exception("underflow");
            return Memoria1 - Memoria2;
        }
        public float Multiplicar()
        {
            var res = Memoria1 * Memoria2;
            if (res > 100)
                throw new Exception("overflow");
            return Memoria1 * Memoria2;
        }
        public float Dividir()
        {
            if (Memoria2 ==0)
                throw new Exception("Divisão por zero");
           return Memoria1 / Memoria2;
 
        }
        public string Resultado(string operacao)
        {
            switch (operacao)
            {
                case "+":
                    try
                    {
                        return Somar().ToString();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                case "-":
                    try
                    {
                        return Subtrair().ToString();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                    
                case "*":
                    try
                    {
                        return Multiplicar().ToString(); ;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                    
                case "/":
                    try
                    {
                        return Dividir().ToString(); ;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                default:
                    return "OP NOT SUP";
 
            }

        }
 
    }
}