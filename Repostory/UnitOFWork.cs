using Data;
using Models;
using Models.Models;
using Repostory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostory
{
   public class UnitOFWork:IUnitOfWork
    {

        private readonly Project_Context _Context;


        //   IGenericRepostory<User> UserRepo;
        IBaseRepostory<Category> _CategoryRepo;
        //  IGenericRepostory<Contact> ContactRepo;
        IBaseRepostory<Courier> _CourierRepo;
        IBaseRepostory<Feedback> _FeedbackRepo;
        IBaseRepostory<Offer> _OfferRepo;
        IBaseRepostory<Order> _OrderRepo;
        IBaseRepostory<Payment> _PaymentRepo;
        IBaseRepostory<Product>_ProductRepo;
        IBaseRepostory<Store> _StoreRepo;
        IBaseRepostory<Images> _ImagesRepo;
        IBaseRepostory<ContactUs> _ContactRepo;

        public UnitOFWork(Project_Context context,
                            IBaseRepostory<Category> categoryRepo,// IGenericRepostory<Contact> contactRepo,
                            IBaseRepostory<Courier> courierRepo, IBaseRepostory<Feedback> feedbackRepo,
                            IBaseRepostory<Offer> offerRepo, IBaseRepostory<Order> orderRepo,
                            IBaseRepostory<Payment> paymentRepo, IBaseRepostory<Product> productRepo,
                            IBaseRepostory<Store> storeRepo, IBaseRepostory<Images> imagesRepo,
                            IBaseRepostory<ContactUs> contactRepo
)
        {
            _Context = context;
            _CategoryRepo = categoryRepo;
            // ContactRepo = contactRepo;
            _CourierRepo = courierRepo;
            _FeedbackRepo = feedbackRepo;
            _OfferRepo = offerRepo;
            _OrderRepo = orderRepo;
            _PaymentRepo = paymentRepo;
            _ProductRepo = productRepo;
            _StoreRepo = storeRepo;
            _ImagesRepo = imagesRepo;
            //UserRepo = userRepo;
            _ContactRepo = contactRepo;
        }

        public IBaseRepostory<Category> GetCategoryRepo()
        {
            return _CategoryRepo;

        }

        public IBaseRepostory<Courier> GetCourierRepo()
        {
            return _CourierRepo;

        }
        public IBaseRepostory<Feedback> GetFeedbackRepo()
        {
            return _FeedbackRepo;

        }



        public IBaseRepostory<Offer> GetOfferRepo()
        {
            return _OfferRepo;

        }
        public IBaseRepostory<Order> GetOrderRepo()
        {
            return _OrderRepo;

        }
        public IBaseRepostory<Payment> GetPaymentRepo()
        {
            return _PaymentRepo;

        }
        public IBaseRepostory<Product> GetProductRepo()
        {
            return _ProductRepo;

        }
        public IBaseRepostory<Images> GetImagesRepo()
        {
            return _ImagesRepo;
        }
        public IBaseRepostory<Store> GetStoreRepo()
        {
            return _StoreRepo;

        }

      
        public IBaseRepostory<ContactUs> GetContactRepo()
        {
            return _ContactRepo;
        }
        public async Task Save()
        {
            await _Context.SaveChangesAsync();
        }

    }
}
