using DAL;
using Models;
using Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BaseBL : INotifyPropertyChanged
    {
        #region Resources (Properties / Default Functions)

        private BaseDaL m_DAL = (BaseDaL)Assembly.GetAssembly(typeof(BaseDaL)).CreateInstance("DAL.BaseDaL");
        public BaseDaL DAL
        {
            set
            {
                if (this.m_DAL != value)
                {
                    this.m_DAL = value;
                    this.OnPropertyChanged("BaseDAL");
                }
            }
            get
            {
                return this.m_DAL;
            }
        }
     
        public FunctionResponse<DataTable> GetProductsCategories()
        {
            FunctionResponse<DataTable> Response = new FunctionResponse<DataTable>();
            try
            {
                var response = DAL.GetProductsCategories();
                if (response.Success)
                {
                    DataSet ds = response.Result;
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        Response.Result = new DataTable();
                        Response.Result = ds.Tables[0];
                        Response.Success = true;
                        return Response;
                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
        }   
        public FunctionResponse<DataTable> GetUnitOfMeasure()
        {
            FunctionResponse<DataTable> Response = new FunctionResponse<DataTable>();
            try
            {
                var response = DAL.GetUnitOfMeasure();
                if (response.Success)
                {
                    DataSet ds = response.Result;
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        Response.Result = new DataTable();
                        Response.Result = ds.Tables[0];
                        Response.Success = true;
                        return Response;
                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
        }

        #endregion

        #region Products
      
        public virtual ObservableCollection<Product> GetAllProducts()
        {
            ObservableCollection<Product> Response = new ObservableCollection<Product>();
            try
            {
                var DalResponse = DAL.GetAllProducts();
                if (!string.IsNullOrWhiteSpace(DalResponse))
                {
                    var ds = General.XMLToDataSet(DalResponse);
                    if (ds != null && ds.Tables[0] != null)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            try
                            {
                                Response.Add(new Product()
                                {
                                    ProductName = row["Name"].ToString(),
                                    ProductCode = row["itemcode"].ToString(),
                                    CastPrice = row["PurchasePrice"].ToString(),
                                    SalePrice = row["SalePrice"].ToString(),
                                    Category = row["Categorys"].ToString(),
                                    UnitOfMeasure = row["Units"].ToString(),
                                    Quantity = int.Parse(row["Quantity"].ToString()),
                                    Vendor = row["vendor"].ToString(),
                                    ImagePath = row["Picture"].ToString()
                                });
                            }
                            catch (Exception ex) { }
                        }  
                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
        }
        
        public virtual string GetProductCodeByCategory(string CategoryID)
        {
            string Response = string.Empty;
            try
            {
                Response =  this.DAL.GetProductCodeByCategory(CategoryID);
                if(!string.IsNullOrWhiteSpace(Response))
                {
                    var ds = General.XMLToDataSet(Response);
                    if(ds != null)
                    {
                        if (ds.Tables != null && ds.Tables.Count > 0)
                            return ds.Tables[0].Rows[0]["Result"].ToString();
                    }
                } 
            }
            catch (Exception ex)
            { }
            return Response;
        }

        public virtual FunctionResponse<string> AddNewProduct(Product product)
        {
            FunctionResponse<string> Response = new FunctionResponse<string>();
            try
            {

                if(!string.IsNullOrWhiteSpace(product.ProductCode))
                {
                    string XmlRequest = General.OBJECTTOXML(product);
                    var XmlResponse = this.DAL.AddNewProduct(XmlRequest);
                    if (!string.IsNullOrWhiteSpace(XmlResponse))
                    {
                        var ds = General.XMLToDataSet(XmlResponse);
                        if (ds != null && ds.Tables[0] != null)
                        {
                            Response.Result = ds.Tables[0].Rows[0]["Result"].ToString();
                            Response.Success = true;
                            return Response;
                        }
                    } 
                }
                else
                {

                } 
            }
            catch (Exception ex)
            { }
            return Response;
        }






        #endregion

        #region Property Changed Event 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}
