using Npgsql;
namespace itvaika.Co;
public class Connexion
{
    private readonly NpgsqlConnection connection;

    public Connexion()
    {
        string connectionString = "Host=localhost;Port=5432;Database=itvaika;Username=postgres;Password=loann;";
        connection = new NpgsqlConnection(connectionString);
        connection.Open();
    }

    public NpgsqlConnection seConnecter()
    {
        return connection;
    }

    public void seDeconnecter()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}