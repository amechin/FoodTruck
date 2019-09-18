using FoodtruckApp.DAL;
using FoodtruckApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodtruckApp.ViewModels
{
    public class IndexViewModel : BindableBase
    {
        private const string _ErrorMessage = "Veuillez vérifier les données saisies dans les champs";

        #region Les listes
        private ObservableCollection<Produit> _listProduit;
        public ObservableCollection<Produit> ListProduit { get { return _listProduit; } set { SetProperty(ref _listProduit, value); } }
        #endregion

        #region Les propriétés
        private string _createUserErrorMessage;
        public string CreateUserErrorMessage
        {
            get { return _createUserErrorMessage; }
            set { _createUserErrorMessage = value; }
        }


        private int _countUser;
        public int CountProduit
        {
            get { return _countUser; }
            set { _countUser = value; }
        }

        private Produit _produit;
        public Produit LocalProduit { get => _produit; set => SetProperty(ref _produit, value); }

        private Produit _selectedProduit;
        public Produit SelectedProduit
        { get => _selectedProduit; set => SetProperty(ref _selectedProduit, value); }

        private bool _enableErrorMessage;
        public bool EnableErrorMessage
        {
            get { return _enableErrorMessage; }
            set { SetProperty(ref _enableErrorMessage, value); }
        }

        private bool _enableEditMode;
        public bool EnableEditMode
        {
            get { return _enableEditMode; }
            set { SetProperty(ref _enableEditMode, value); }
        }

        #endregion

        #region Command

        private DelegateCommand _commandSelectAllProducts;
        
        private DelegateCommand<Produit> _commandAddProduit;
        public DelegateCommand<Produit> AddProduit
        {
            get { return _commandAddProduit; }
        }

        private DelegateCommand _commandCancel;
        public DelegateCommand CancelProduit
        {
            get { return _commandCancel; }
        }

        private DelegateCommand _commandEdit;
        public DelegateCommand EditProduit
        {
            get { return _commandEdit; }
        }

        private DelegateCommand _commandSaveEdit;

        public DelegateCommand SaveEditProduit
        {
            get { return _commandSaveEdit; }
        }

        #endregion

        #region Constructeur
        public IndexViewModel()
        {
            // Bloc commande
            ListProduit = new ObservableCollection<Produit>();
            DoSelectAllProducts();
            //_commandSelectAllProducts = new DelegateCommand(DoSelectAllProducts);
            
        }
        #endregion

        protected void DoSelectAllProducts()
        {
            foreach(Produit pdt in ProduitDAL.FindAll())
            {
                ListProduit.Add(pdt);
            }
        }
    }
}
