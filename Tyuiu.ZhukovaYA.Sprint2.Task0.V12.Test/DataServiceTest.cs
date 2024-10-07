using Tyuiu.ZhukovaYA.Sprint2.Task0.V12.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task0.V12.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(1095, 475);
        bool[] wait = new bool[6]{ true, false, true, false, true, false };
        CollectionAssert.AreEqual(res, wait);
   } 
} 
