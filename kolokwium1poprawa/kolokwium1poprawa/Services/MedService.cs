using kolokwium1poprawa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Services
{
    public class MedService : IMedService
    {
        private readonly IConfiguration _configuration;

        public MedService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ActionResult<Patient> DeletePatient(int idPatient)
        {
            using ( var con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = $"SELECT IdPrescription FROM Prescription WHERE IdPatient = @idPatient";
                command.Parameters.AddWithValue("@idPatient", idPatient);
                command.CommandText = $"DELETE FROM Prescription WHERE IdPatient = {idPatient}";
                command.ExecuteScalar();

                command.CommandText = $"DELETE FROM Patient WHERE IdPatient = {idPatient}";
                command.ExecuteScalar();
                return null;
            }
        }

        public IEnumerable<Medicament> GetMedicament(int IdMedicament)
        {
            var res = new List<Medicament>();
            using ( var con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                var com =
                    new SqlCommand($"SELECT Medicamen, Name, Description, Type, Prescription.Date FROM Medicament"
                                       + "INNER JOIN PrescriptionMedicament ON Medicament.IdMedicament = PrescriptionMedicament.IdMedicament"
                                       + "INNER JOIN Prescription ON PrescriptionMedicament.IdPrescription = Prescription.IdPrescription "
                                       + "ORDER BY [Date] DESC", con);
                con.Open();
                var dr = com.ExecuteReader();
                while (dr.Read())
                {
                    res
                        .Add(new Medicament()
                        {
                            IdMedicament = int.Parse(dr["IdMedicament"].ToString()),
                            Name = dr["[Name]"].ToString(),
                            Description = dr["[Description]"].ToString(),
                            Type = dr["Type"].ToString(),
                            PrescriptionMedicament = dr["PrescriptionMedicament.IdPrescription"].ToString()
                        });
                }
            }
            return res;
        }

        public IEnumerable<Patient> GetPatient(int IdPatient)
        {
            throw new NotImplementedException();
        }
    }
}
