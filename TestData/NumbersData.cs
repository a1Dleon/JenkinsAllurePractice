using System.Collections;

namespace practice05.TestData
{
    public class NumbersData
    {
        public static IEnumerable Sum_Data
        {
            get
            {
                yield return new TestCaseData(2,3,2);
                yield return new TestCaseData(6,3,6);
                yield return new TestCaseData(200,3,200);
                yield return new TestCaseData(12,3597,12);
            }
        }
    }
}