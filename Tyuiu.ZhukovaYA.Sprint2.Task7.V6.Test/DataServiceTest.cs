using Tyuiu.ZhukovaYA.Sprint2.Task7.V6.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task7.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(ds.CheckDotInShadedArea(0, 1.5), true);
    } 
} 
