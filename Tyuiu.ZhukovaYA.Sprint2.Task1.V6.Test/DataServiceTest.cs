using Tyuiu.ZhukovaYA.Sprint2.Task1.V6.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task1.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        bool[] res = ds.GetLogicOperations(915, 169, 174, 133);
        bool[] wait = { false, false, true, false, true, false };
        CollectionAssert.AreEqual(res, wait);
   } 
} 
