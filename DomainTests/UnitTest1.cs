namespace DomainTests
{
    public class Tests
    { 
    
        [TestCase(-1,"name","position",10,10,10)]
        [TestCase(1, null, "position", 10, 10, 10)]
        [TestCase(1, "name", null, 10, 10, 10)]
        [TestCase(1, "name", "position", -1, 10, 10)]
        [TestCase(1, "name", "position", 10, -1, 10)]
        [TestCase(1, "name", "position", 10, 10, -1)]
        public void ValidateEmplyee(int departmentId,string name, string position, decimal salary, decimal price, int month)
        {
            Assert.Throws<ValidateExcetpin>
        }
    }
}