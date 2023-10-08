using System.Data.SqlClient;
using Npgsql;
using itvaika.Co;


namespace itvaika.Departement
{
    public class Departement
    {
        public int idDepartement { get; set; }
        public string secteur { get; set; }

        public Departement(int idDepartement, string secteur)
        {
            this.idDepartement = idDepartement;
            this.secteur = secteur;
        }

        public Departement(string secteur)
        {
            this.secteur = secteur;
        }

        public Departement()
        {
        }

        // public List<Departement> GetDepartements(Connexion connexion){
        //     List<Departement> ld = new List<Departement>();
        //     string query = "SELECT * FROM departement";
        //     SqlCommand sql = new SqlCommand(query,connexion.seConnecter());
        //     SqlDataReader reader = sql.ExecuteReader();

        //     try
        //     {
        //         while (reader.Read())
        //         {
        //             Departement d = new Departement();
        //             d.idDepartement = (int)reader["idDepartement"];
        //             d.secteur = (String)reader["secteur"];

        //             ld.Add(d);
        //             Console.WriteLine(ld.Count);
        //         }
        //         reader.Close();
        //     }
        //     catch (Exception ex)
        //     {
            
        //     }
        //     return ld;
        // }
    }
}
