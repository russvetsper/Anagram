using Xunit;
using System.Collections.Generic;


namespace AnagramList.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void Test1_SimpleInput_True()
    {
      Anagram myAnagram = new Anagram("a","a");
      Assert.Equal(true,myAnagram.isAnagram());
    }
    [Fact]
    public void Test2_SimpleInput_False()
     {
       Anagram myAnagram = new Anagram("b","c");
       Assert.Equal(false,myAnagram.isAnagram());
     }
     [Fact]
     public void Test3_ComplexInput_True()
     {
       Anagram myAnagram = new Anagram("bread","beard");
       Assert.Equal(true,myAnagram.isAnagram());
     }
     [Fact]
     public void Test4_ComplexInput_False()
     {
       Anagram myAnagram = new Anagram("bread","orange");
       Assert.Equal(false,myAnagram.isAnagram());
     }
     [Fact]
     public void test5_PartialMatch_True()
     {
       Anagram myAnagram =new Anagram("Pat","Path");
       Assert.Equal(true,myAnagram.isAnagram());
      }
      [Fact]
      public void Test6_SingleNumber_False()
      {
        Anagram myAnagram = new Anagram("0","0");
        Assert.Equal(false,myAnagram.isAnagram());
      }
      [Fact]
      public void Test7_IfWordIncludeNumber_False()
      {
        Anagram myAnagram = new Anagram("p0g","p0g");
        Assert.Equal(false,myAnagram.isAnagram());
      }
      [Fact]
      public void Test8_CaseInSentive_True()
      {
        Anagram myAnagram = new Anagram("PIG","GIP");
        Assert.Equal(true,myAnagram.isAnagram());
      }


   }
}
