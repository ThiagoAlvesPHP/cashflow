using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess
{
    public class DatabaseTester
    {
        public static void TestConnection()
        {
            try
            {
                using (var context = new CashFlowDBContext())
                {
                    context.Database.OpenConnection();
                    Console.WriteLine("Conexão com o banco de dados foi bem-sucedida.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }
    }    
}
