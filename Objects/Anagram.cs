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
       if(this.isContainsNum())
       {
          return false;
       }else{
       bool result = false;
       string ourStringWord=this.GetOurWord().ToLower();
       string userStringWord=this.GetUserWord().ToLower();

       char[] ourArray=ourStringWord.ToCharArray();
       char[] userArray=userStringWord.ToCharArray();

       Array.Sort(ourArray);
       Array.Sort(userArray);
       //change to string before comparing
       string ourString = string.Join("",ourArray);
       string userString= string.Join("",userArray);

       if(ourString.Length>=userString.Length)
       {
         for (int i =0; i<userString.Length; i++)
         {
           if(ourString.Contains(userString[i]))
           {
             result= true;
           }
           else
           {
             result=false;
             break;
           }
         }
         //ourWord=Path , userWord=Pat.
       }else if(ourString.Length<userString.Length)
       {
         for (int i =0; i<ourString.Length; i++)
         {
           if(userString.Contains(ourString[i]))
           {
             result= true;
           }
           else
           {
             result=false;
             break;

           }
         }
       }
       return result;
    }
  }

    }
  }
