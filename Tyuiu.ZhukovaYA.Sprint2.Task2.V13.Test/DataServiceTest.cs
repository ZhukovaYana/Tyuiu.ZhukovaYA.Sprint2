using Tyuiu.ZhukovaYA.Sprint2.Task2.V13.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task2.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(5,6);
        Assert.AreEqual(res, true);
   } 
} 
