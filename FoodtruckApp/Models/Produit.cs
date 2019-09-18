using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodtruckApp.Models
{
    public class Produit
    {
        private int _idProduit;

        public int IdProduit
        {
            get { return _idProduit; }
            set { _idProduit = value; }
        }

        private int _idFamilleRepas;

        public int IdFamilleRepas
        {
            get { return _idFamilleRepas; }
            set { _idFamilleRepas = value; }
        }

        private string _libelleProduit;

        public string LibelleProduit
        {
            get { return _libelleProduit; }
            set { _libelleProduit = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _nbVente;

        public int NbVente
        {
            get { return _nbVente; }
            set { _nbVente = value; }
        }

        private float _prix;

        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private string _urlImage;

        public string UrlImage
        {
            get { return _urlImage; }
            set { _urlImage = value; }
        }

        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        private string _lmmjvsd;

        public string LMMJVSD
        {
            get { return _lmmjvsd; }
            set { _lmmjvsd = value; }
        }

        private float _moyenneNote;

        public float MoyenneNote
        {
            get { return _moyenneNote; }
            set { _moyenneNote = value; }
        }

        private string _unite;

        public string Unite
        {
            get { return _unite; }
            set { _unite = value; }
        }


        //Constructeurs
        public Produit()
        {
                
        }

        public Produit(int idProduit, int idFamilleRepas, string libelleProduit, int nbVente, float prix, string urlImage, int stock)
        {
            IdProduit = idProduit;
            IdFamilleRepas = idFamilleRepas;
            LibelleProduit = libelleProduit;
            NbVente = nbVente;
            Prix = prix;
            UrlImage = urlImage;
            Stock = stock;
        }

        public Produit(int idProduit, int idFamilleRepas, string libelleProduit, string description, int nbVente,float prix, string urlImage, int stock, string lMMJVSD, float moyenneNote, string unite)
        {
            IdProduit = idProduit;
            IdFamilleRepas = idFamilleRepas;
            LibelleProduit = libelleProduit;
            Description = description;
            NbVente = nbVente;
            Prix = prix;
            UrlImage = urlImage;
            Stock = stock;
            LMMJVSD = lMMJVSD;
            MoyenneNote = moyenneNote;
            Unite = unite;
        }

        //Méthode ToString
        public override string ToString()
        {
            return ($"Produit #{this.IdProduit.ToString()}, \nId Famille Repas :\t{this.IdFamilleRepas.ToString()} \nLibellé Produit :\t{this.LibelleProduit} \nDescription :\t{this.Description} \nNombre de vente :\t {this.NbVente.ToString()} \nPrix :\t {this.Prix.ToString()} \nUrl image :\t {this.UrlImage} \nStock :\t {this.Stock.ToString()} \nPrix :\t {this.Prix.ToString()}");
        }
    }
}
