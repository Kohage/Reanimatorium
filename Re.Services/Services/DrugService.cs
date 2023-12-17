﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces;

namespace Re.Services.Services
{
    public class DrugService : IDrugService
    {
        private readonly IRepo<Patient> _PatinetRepo = null!;
        private readonly IRepo<PrescribedMedication> _MedicationRepo = null!;
        private readonly IRepo<Syndrom> _SyndromRepo = null!;
        public DrugService(IRepo<Patient> PatientRepo,IRepo<PrescribedMedication> MeicationtRepo, IRepo<Syndrom> SyndromRepo)
        {
            _PatinetRepo = PatientRepo;
            _MedicationRepo = MeicationtRepo;
            _SyndromRepo = SyndromRepo;
        }  
        public async Task<Patient> SavePatientAsync(Patient patient)
        {
            return await _PatinetRepo.SaveAsync(patient);
        }

        public async Task<PrescribedMedication> SaveMedicationAsync(PrescribedMedication medication)
        {
            return await _MedicationRepo.SaveAsync(medication);
        }

        public async Task<Syndrom> SaveSyndromAsync(Syndrom syndrom)
        {
            return await _SyndromRepo.SaveAsync(syndrom);
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            return await _PatinetRepo.GetAsync();
        }
        public async Task<List<Syndrom>> GetAllSyndromAsync()
        {
            return await _SyndromRepo.GetAsync();
        }
        public async Task<List<PrescribedMedication>> GetAllMedicationAsync()
        {
            return await _MedicationRepo.GetAsync();
        }
        public IEnumerable<string> GetPropertyPatientNames()
        {
            var type = typeof(Patient).GetProperties();
            return type.Select(prop => prop.Name).ToList();
        }
        public IEnumerable<string> GetPropertyMedicationNames()
        {
            var type = typeof(PrescribedMedication).GetProperties();
            return type.Select(prop => prop.Name).ToList();
        }
        public IEnumerable<string> GetPropertySyndromNames()
        {
            var type = typeof(Syndrom).GetProperties();
            return type.Select(prop => prop.Name).ToList();
        }
    }
}