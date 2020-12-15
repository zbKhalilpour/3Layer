using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Ref_PhoneBookContext = new PhoneeBookContext();
            Ref_M_PhoneBook = new M_PhoneBook();
        }

        public PhoneeBookContext Ref_PhoneBookContext { get; set; }
        public M_PhoneBook Ref_M_PhoneBook { get; set; }

        public List<M_PhoneBook> GetInfo()
        {
            return Ref_PhoneBookContext.PhoneBookList.ToList();      
        }

        public void Insert(M_PhoneBook m_PhoneBook)
        {
            M_PhoneBook m_Phone = new M_PhoneBook();
            m_Phone.FName = m_PhoneBook.FName;
            m_Phone.LName = m_PhoneBook.LName;
            m_Phone.PhoneNumber = m_PhoneBook.PhoneNumber;
            Ref_PhoneBookContext.PhoneBookList.Add(m_Phone);
        }

        public void UpdatePerson(M_PhoneBook m_PhoneBook)
        {
            M_PhoneBook m_Phone = new M_PhoneBook();
            m_Phone =Ref_PhoneBookContext.PhoneBookList.Find(m_PhoneBook.Id);
            m_Phone.FName = m_PhoneBook.FName;
            m_Phone.LName = m_PhoneBook.LName;
            m_Phone.PhoneNumber = m_PhoneBook.PhoneNumber;
            Ref_PhoneBookContext.Entry(m_Phone).State = EntityState.Modified;
            Ref_PhoneBookContext.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var q= Ref_PhoneBookContext.PhoneBookList.Find(id);
            Ref_PhoneBookContext.PhoneBookList.Remove(q);
            Ref_PhoneBookContext.SaveChanges();

        }


    }
}
