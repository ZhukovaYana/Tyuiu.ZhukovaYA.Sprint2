using Tyuiu.ZhukovaYA.Sprint2.Task4.V30.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task4.V30.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double res = ds.Calculate(2,3);
        Assert.AreEqual(res,343);
   } 
} 
