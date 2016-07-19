using Xunit;
using System.Collections.Generic;


namespace AnagramList.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void Test1_SimpleInput_ReturnTrue()
    {
      Anagram myAnagram = new Anagram("a","a");
      Assert.Equal(true,myAnagram.isAnagram());
    }
    [Fact]
    public void Test2_SimpleInput_ReturnFalse()
     {
       Anagram myAnagram = new Anagram("b","c");
       Assert.Equal(false,myAnagram.isAnagram());
     }
     [Fact]
     public void Test3_ComplexInput_ReturnTrue()
     {
       Anagram myAnagram = new Anagram("bread","beard");
       Assert.Equal(true,myAnagram.isAnagram());
     }

  }
}
