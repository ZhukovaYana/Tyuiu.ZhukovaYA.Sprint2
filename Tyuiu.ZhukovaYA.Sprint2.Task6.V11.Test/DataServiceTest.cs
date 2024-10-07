using Tyuiu.ZhukovaYA.Sprint2.Task6.V11.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task6.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        string res = ds.FindDateOfNextDay(2024,12,31);
        Assert.AreEqual(res, "2025.1.1");
   } 
} 
