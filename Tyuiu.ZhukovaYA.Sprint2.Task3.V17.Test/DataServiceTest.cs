using Tyuiu.ZhukovaYA.Sprint2.Task3.V17.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task3.V17.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double res = ds.Calculate(2);
        Assert.AreEqual(res, 6565);
   } 
} 
