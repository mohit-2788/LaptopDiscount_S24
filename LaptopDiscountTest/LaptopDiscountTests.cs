using LaptopDiscount;
namespace LaptopDiscountTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void PartTimeEmployeePriceCheck()
        {
            EmployeeType var = EmployeeType.PartTime;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000.56m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.Price, Is.EqualTo(1000.56m));
        }

        [Test]
        public void FullTimeEmployeePriceCheck()
        {
            EmployeeType var = EmployeeType.FullTime;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.Price, Is.EqualTo(1000m));
        }

        [Test]
        public void PartTimeEmployeePrice()
        {
            EmployeeType var = EmployeeType.PartTime;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.CalculateDiscountedPrice, Is.EqualTo(1000m));
        }

        [Test]
        public void PartialLoadEmployeePrice()
        {
            EmployeeType var = EmployeeType.PartialLoad;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.CalculateDiscountedPrice, Is.EqualTo(950m));
        }

        [Test]
        public void FullTimeEmployeePrice()
        {
            EmployeeType var = EmployeeType.FullTime;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.CalculateDiscountedPrice, Is.EqualTo(900m));
        }

        [Test]
        public void CompanyPurchasingEmployeePrice()
        {
            EmployeeType var = EmployeeType.CompanyPurchasing;
            EmployeeDiscount employeeDiscount = new EmployeeDiscount();
            employeeDiscount.Price = 1000m;
            employeeDiscount.EmployeeType = var;
            Assert.That(employeeDiscount.CalculateDiscountedPrice, Is.EqualTo(800m));
        }

    }
}