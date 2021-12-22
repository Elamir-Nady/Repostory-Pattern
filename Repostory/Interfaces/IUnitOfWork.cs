using Data;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostory.Interfaces
{
   public interface IUnitOfWork
    {
        // IGenericRepostory<Admin> GetAdminRepo();
        IBaseRepostory<Category> GetCategoryRepo();
        // IGenericRepostory<Contact> GetContactRepo();
        IBaseRepostory<Courier> GetCourierRepo();
        IBaseRepostory<Feedback> GetFeedbackRepo();
        IBaseRepostory<Offer> GetOfferRepo();
        IBaseRepostory<Order> GetOrderRepo();
        IBaseRepostory<Payment> GetPaymentRepo();
        IBaseRepostory<Product> GetProductRepo();
        IBaseRepostory<Store> GetStoreRepo();
        IBaseRepostory<Images> GetImagesRepo();
        IBaseRepostory<ContactUs> GetContactRepo();
        //  IGenericRepostory<Supplier> GetSupplierRepo();
        Task Save();
    }
}
