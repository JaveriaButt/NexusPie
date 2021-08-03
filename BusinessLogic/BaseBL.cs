using DAL;
using Models;
using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BaseBL : INotifyPropertyChanged
    {
        #region Properties

        private BaseDaL m_DAL = null;
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
        #endregion
        public FunctionResponse<DataTable> GetProductsCategories()
        {
            FunctionResponse<DataTable> Response = new FunctionResponse<DataTable>();
            try
            {
                var response = DAL.GetProductsCategories();
                if (response.Success)
                {
                    DataSet ds = General.XMLToDataSet(response.Result);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        Response.Result = new DataTable();
                        Response.Result = ds.Tables[0];
                        return Response;
                    }
                }
            }
            catch (Exception ex)
            { }
            return Response;
        }



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
