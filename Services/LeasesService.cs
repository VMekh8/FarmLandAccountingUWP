using FarmLandAccountingUWP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace FarmLandAccountingUWP.Services
{
    public class LeasesService : IRepository<LeasesModel>
    {
        public async Task Create(LeasesModel entity)
        {
            DataBase db = new DataBase();

            try
            {

                string query = @"INSERT INTO Leases (ContractName, StartDate, EndDate, FarmID, LandPlotID)
                                    VALUES (@ContractName, @StartDate, @EndDate, @FarmID, @LandPlotID)";

                using (SqlCommand cmd = new SqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ContractName", entity.ContractName);
                    cmd.Parameters.AddWithValue("@StartDate", entity.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", entity.EndDate);
                    cmd.Parameters.AddWithValue("@FarmID", entity.FarmID);
                    cmd.Parameters.AddWithValue("@LandPlotId", entity.LandPlotID);

                    await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (Exception e)
            {
;               Console.WriteLine(e.Message);
                var dialog = new MessageDialog(e.Message);
                await dialog.ShowAsync();
            }
        }

        public Task Delete()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<LeasesModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(LeasesModel entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

