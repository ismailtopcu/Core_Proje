using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
}
