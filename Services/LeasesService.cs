using FarmLandAccountingUWP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace FarmLandAccountingUWP.Services
{
    public sealed class LeasesService : IRepository<LeasesModel>
    {
        private DataBase db = new DataBase();

        public async Task Create(LeasesModel entity)
        {

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

        public async Task Delete(int id)
        {
            try
            {
                string query = @"DELETE FROM Leases WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var dialog = new MessageDialog(e.Message);
                await dialog.ShowAsync();
            }
        }

        public Task<List<LeasesModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(LeasesModel entity)
        {
            throw new NotImplementedException();
        }
    }
}

