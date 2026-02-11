using bookshopsystem.Models;
using bookshopsystem.Repositories;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace bookshopsystem.Services
{
    public class StaffService
    {
        private readonly StaffRepository _repo;

        public StaffService()
        {
            _repo = new StaffRepository();
        }

        public List<Staff> GetAllStaffs()
        {
            return _repo.GetAll();
        }

        public Staff GetByUsername(string username)
        {
            return _repo.GetByUsername(username);
        }

        public Staff GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Staff> GetPagedStaffs(int page, int pageSize)
        {
            return _repo.GetPaged(page, pageSize);
        }

        public int GetTotalStaffs()
        {
            return _repo.GetTotalCount();
        }

        public List<Staff> SearchStaffs(string keyword)
        {
            return _repo.Search(keyword);
        }

        public void AddStaff(Staff staff)
        {
            _repo.Add(staff);
        }

        public void UpdateStaff(Staff staff)
        {
            _repo.Update(staff);
        }

        public void UpdateStaffWithPassword(Staff staff)
        {
            _repo.UpdateWithPassword(staff);
        }

        public void DeleteStaff(int staffId)
        {
            _repo.Delete(staffId);
        }


        // ===================== Hash Password Function =====================
        public string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }


    }
}
