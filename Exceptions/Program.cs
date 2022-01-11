namespace Exceptions{
    public class Program{
        static void Main(string[] args){
           var arr = new int[3]{1,2,3};

            try
            {
                // for(var i =0 ; i <=10 ; i++){
                //     Console.WriteLine(arr[i]);
                // }

                Salvar("");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista");
            }
            catch(ArgumentNullException ex)
            {
                 Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao carregar texto");
            }
            catch(MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção Customizada");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo deu errado");
            }
            finally{
                Console.WriteLine("Chegou ao fim!");
            }

        }

        static void Salvar(string texto){
            if(string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException: Exception{
        public DateTime QuandoAconteceu {get;set;}

        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
    }
}