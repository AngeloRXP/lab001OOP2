using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //2. Create a class called Relation that has one attribute:
    public class Relation
    {
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }
        //In this part I used W3Schools to understand
        public static string ShowRelationShip(RelationshipType relationship)
        {
            switch (relationship)
            {
                case RelationshipType.Sister:
                    return "Sisterhood";
                case RelationshipType.Brother:
                    return "Brotherhood";
                case RelationshipType.Mother:
                    return "Motherhood";
                case RelationshipType.Father:
                    return "fatherhood";
                default:
                    return "Unknown";
            }
        }
    }
}
