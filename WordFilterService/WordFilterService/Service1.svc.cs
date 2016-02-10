using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
namespace WordFilterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string WordFilter(string str)
        {


            string[] functionWords = new string[]                       
        {
              " a ", " aaa", " able ", " about ", " across ", " after ", " all ", " aa "," almost ", " also ", " am ", " among ", " an ", " and ", " any ", " are ", " as ", " at ", " be ", " because ", " been ", " but ", " by ", " can ", " cannot ", " could ", " dear ", " did ", " do ", " does ", " either ", " else ", " ever ", " every ", " for ", " from ", " get ", " got ", " had ", " has ", " have ", " he ", " her ", " hers ", " him ", " his ", " how ", " however ", " i ", " if ", " in ", " into ", " is ", " it ", " its ", " just ", " least ", " let ", " like ", " likely ", " may ", " me ", " might ", " most ", " must ", " my ", " neither ", " no ", " nor ", " not ", " of ", " off ", " often ", " on ", " only ", " or ", " other ", " our ", " own ", " rather ", " said ", " say ", " says ", " she ", " should ", " since ", " so ", " some ", " than ", " that ", " the ", " their ", " them ", " then ", " there ", " these ", " they ", " this ", " tis ", " to ", " too ", " twas ", " us ", " wants ", " was ", " we ", " were ", " what ", " when ", " where ", " which ", " while ", " who ", " whom ", " why ", " will ", " with ", " would ", " yet ", " you ", " your "};   //complete list of functionwords dictionary

            string[] funcWordSet = new string[] { "a", "able", "about", "across", "after", "all", "almost", "also", "an", "and", "any", "are", "as", "at", "be", "became", "been", "between", "because", "but", "by", "can", "could", "do", "during", "each", "either", "en", "for", "from", "had", "has", "have", "he", "how", "however", "i", "if", "in", "about", "actually", "after", "also", "am", " include ", "including", "into", "is", "it", "its", "just", "late", "later", "me", "made", "many", "may", "more", "most", "of", "on", "or", "near", "no", "nor", "not", "several", "she", "so", "some", "such", "that", "the", "their", "these", "thing", "this", "there", "they", "thorugh", "to", "too", "under", "until", "use", "very", "was", "we", "well", "what", "when", "where", "which", "who", "will", "with", "you", "your" };
            String filterString = Regex.Replace(str, "<.*?>", " "); //using reg expressions to filter out Element and attribute Tags
            filterString = filterString.ToLower(); //converting to lowerCase

            int value = 68;
            for (int p = 0; p < value; p++)    //filtering out stopWords
            {
                foreach (string words in functionWords)
                { 
                    filterString = filterString.Replace(words, " ");
                }

            }

            String[] str1 = filterString.Split(' ');
            String prev = str1[0];
            String succ = str1[1];
            foreach (string words in funcWordSet)   //removing duplicate & redundant words 
            {
                if (prev == words)
                    filterString = filterString.Replace(prev, "");               
            }

            foreach (string word in funcWordSet)
            {
                if (succ == word)
                    filterString = filterString.Replace(succ, "");
            }



            foreach (string word in functionWords)
            {
                filterString = filterString.Replace(word, " ");
            }
            for (int j = 0; j < value; j++)    //filtering extra space
            {
                filterString = Regex.Replace(filterString, "  ", " ");                  

            }


            return filterString;
        }
    }
}
