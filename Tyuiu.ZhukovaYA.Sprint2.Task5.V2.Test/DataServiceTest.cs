using Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        string res = ds.FindMonthSeason(11);
        Assert.AreEqual(res, "осень");
   } 
} 
