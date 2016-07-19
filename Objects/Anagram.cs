using System;
using  System.Linq;
namespace AnagramList.Objects
{
  public class Anagram
  {
    private string _ourWord;
    private string _userWord;

    public Anagram(string ourWord, string userWord)
    {
      _ourWord = ourWord;
      _userWord = userWord;
    }

    public string GetOurWord()
     {
       return  _ourWord;
     }
     public string GetUserWord()
     {
       return _userWord;
     }
     public void SetOurWord(string neword)
     {
       _ourWord = neword;
     }
     public void SetUserWord(string neword)
     {
       _userWord = neword;
     }
     public bool isContainsNum(){
       if(this.GetOurWord().Any(c => char.IsDigit(c))||this.GetUserWord().Any(c => char.IsDigit(c)))
       {
         return true;
       }
       else
       {
         return false;
       }
     }
     public bool isAnagram()
     {

       char[] ourArray=this.GetOurWord().ToCharArray();
       char[] userArray=this.GetUserWord().ToCharArray();

       Array.Sort(ourArray);
       Array.Sort(userArray);
       //change to string before comparing
       string ourString = string.Join("",ourArray);
       string userString= string.Join("",userArray);
       if(ourString==userString)
       {
         return true;
       }else
       {
       return false;
      }
    }
    }
  }
