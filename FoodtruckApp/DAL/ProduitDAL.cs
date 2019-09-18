using FoodtruckApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodtruckApp.DAL
{
    public class ProduitDAL
    {
        // Méthode permettant d'afficher toutes les lignes de la table PRODUIT
        //********************************************************************
        public static List<Produit> FindAll()
        {
            List<Produit> lProduits = new List<Produit>();

            BaseDAL db = new BaseDAL("SELECT * FROM PRODUIT");
            db.Reader = db.Sql.ExecuteReader();

            while (db.Reader.Read())
            {
                Produit p = new Produit(
                    (int)db.Reader["ID_PRODUIT"],
                    (int)db.Reader["ID_FAMILLE_REPAS"],
                    (string)db.Reader["LIBELLE_PRODUIT"],
                    (string)db.Reader["DESCRIPTION"],
                    (int)db.Reader["NOMBRE_DE_VENTE"],
                    float.Parse(db.Reader["PRIX"].ToString()),
                    (string)db.Reader["URL_IMAGE"],
                    (int)db.Reader["STOCK"],
                    (string)db.Reader["LMMJVSD"],
                    float.Parse(db.Reader["MOYENNE_NOTE"].ToString()),
                    (string)db.Reader["UNITE"]
                );
                lProduits.Add(p);
            }
            db.Connection.Close();
            return lProduits;
        }

        // Méthode permettant d'afficher une fiche produit de la table PRODUIT
        //********************************************************************
        public static Produit FindById(int produitId)
        {
            Produit p = new Produit();
            BaseDAL db = new BaseDAL("SELECT * FROM PRODUIT WHERE ID_PRODUIT = @IdProduit");
            db.Sql.Parameters.Add("@IdProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@FIdProduit"].Value = produitId;
            SqlDataReader Reader = db.Sql.ExecuteReader();

            while (Reader.Read())
            {
                p = new Produit(
                    (int)Reader["ID_PRODUIT"],
                    (int)Reader["ID_FAMILLE_REPAS"],
                    (string)Reader["LIBELLE_PRODUIT"],
                    (string)Reader["DESCRIPTION"],
                    (int)Reader["NOMBRE_DE_VENTE"],
                    (int)Reader["PRIX"],
                    (string)Reader["URL_IMAGE"],
                    (int)Reader["STOCK"],
                    (string)Reader["LMMJVSD"],
                    (float)Reader["MOYENNE_NOTE"],
                    (string)Reader["UNITE"]
                );
            }
            db.Connection.Close();
            return p;
        }

        // Méthode permettant de supprimer une ligne de la table PRODUIT
        //**************************************************************
        public static void Delete(int produitID)
        {
            BaseDAL db = new BaseDAL("DELETE FROM PRODUIT WHERE ID_PRODUIT = @idProduit");
            db.Sql.Parameters.Add("@idProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@idProduit"].Value = produitID;
            db.Sql.ExecuteNonQuery();
        }

        // Méthode permettant d'insérer dans la table PRODUIT une fiche produit
        //*********************************************************************
        public static void Insert(Produit p)
        {
            BaseDAL db = new BaseDAL("INSERT INTO PRODUIT VALUES (@IdProduit, " +
                                "@IdFamilleRepas, @LibelleProduit, @DescriptionProduit, " +
                                "@NbVenteProduit, @PrixProduit, @UrlImageProduit, @StockProduit, " +
                                "@LMMJVSD, @MoyNoteProduit, @UniteProduit)");
            db.Sql.Parameters.Add("@IdProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@FIdProduit"].Value = p.IdProduit;
            db.Sql.Parameters.Add("@IdFamilleRepas", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@IdFamilleRepas"].Value = p.IdFamilleRepas;
            db.Sql.Parameters.Add("@LibelleProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@LibelleProduit"].Value = p.LibelleProduit;
            db.Sql.Parameters.Add("@DescriptionProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@DescriptionProduit"].Value = p.Description;
            db.Sql.Parameters.Add("@NbVenteProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@NbVenteProduit"].Value = p.NbVente;
            db.Sql.Parameters.Add("@PrixProduit", System.Data.SqlDbType.Decimal);
            db.Sql.Parameters["@PrixProduit"].Value = p.Prix;
            db.Sql.Parameters.Add("@UrlImageProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@UrlImageProduit"].Value = p.UrlImage;
            db.Sql.Parameters.Add("@StockProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@StockProduit"].Value = p.Stock;
            db.Sql.Parameters.Add("@LMMJVSD", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@LMMJVSD"].Value = p.LMMJVSD;
            db.Sql.Parameters.Add("@MoyNoteProduit", System.Data.SqlDbType.Float);
            db.Sql.Parameters["@MoyNoteProduit"].Value = p.MoyenneNote;
            db.Sql.Parameters.Add("@UniteProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@UniteProduit"].Value = p.Unite;
            db.Connection.Close();
            db.Sql.ExecuteNonQuery();
        }

        // Méthode permettant de mettre à jour une fiche produit existante
        //****************************************************************
        public static void Update(Produit p, int produitId)
        {
            BaseDAL db = new BaseDAL("UPDATE PRODUIT SET " +
                                "ID_FAMILLE_REPAS = @IdFamilleRepas, " +
                                "LIBELLE_PRODUIT = @LibelleProduit, " +
                                "DESCRIPTION = @DescriptionProduit, " +
                                "NOMBRE_DE_VENTE = @NbVenteProduit, " +
                                "PRIX = @PrixProduit, " +
                                "URL_IMAGE = @UrlImageProduit, " +
                                "STOCK = @StockProduit, " +
                                "LMMJVSD = @LMMJVSD, " +
                                "MOYENNE_NOTE = @MoyNoteProduit, " +
                                "UNITE = @UniteProduit " +
                                "WHERE ID_PRODUIT = @IdProduit");
            db.Sql.Parameters.Add("@IdProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@FIdProduit"].Value = produitId;
            db.Sql.Parameters.Add("@IdFamilleRepas", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@IdFamilleRepas"].Value = p.IdFamilleRepas;
            db.Sql.Parameters.Add("@LibelleProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@LibelleProduit"].Value = p.LibelleProduit;
            db.Sql.Parameters.Add("@DescriptionProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@DescriptionProduit"].Value = p.Description;
            db.Sql.Parameters.Add("@NbVenteProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@NbVenteProduit"].Value = p.NbVente;
            db.Sql.Parameters.Add("@PrixProduit", System.Data.SqlDbType.Decimal);
            db.Sql.Parameters["@PrixProduit"].Value = p.Prix;
            db.Sql.Parameters.Add("@UrlImageProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@UrlImageProduit"].Value = p.UrlImage;
            db.Sql.Parameters.Add("@StockProduit", System.Data.SqlDbType.Int);
            db.Sql.Parameters["@StockProduit"].Value = p.Stock;
            db.Sql.Parameters.Add("@LMMJVSD", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@LMMJVSD"].Value = p.LMMJVSD;
            db.Sql.Parameters.Add("@MoyNoteProduit", System.Data.SqlDbType.Float);
            db.Sql.Parameters["@MoyNoteProduit"].Value = p.MoyenneNote;
            db.Sql.Parameters.Add("@UniteProduit", System.Data.SqlDbType.NVarChar);
            db.Sql.Parameters["@UniteProduit"].Value = p.Unite;
            db.Connection.Close();
            db.Sql.ExecuteNonQuery();
        }
    }
}
