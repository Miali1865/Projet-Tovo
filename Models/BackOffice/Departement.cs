using System;
using System.Collections.Generic;
using Npgsql;
using Dapper;
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

        public static List<Departement> listeDepartements(Connexion co)
        {
            List<Departement> lp = new List<Departement>();
            
            try
            {
                using (NpgsqlConnection connection = co.seConnecter())
                {
                    string query = "SELECT * FROM departement";
                    lp = connection.Query<Departement>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des départements : {ex.Message}");
            }
            
            return lp;
        }
    }
}
