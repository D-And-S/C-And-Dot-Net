namespace Generic
{
    public class Calculator {
        public static bool AreEqual(object value1, object value2){
            return value1 == value2;
        }

        //make method generic
        /*
           -- <T> means some type but i don't know about the type
           -- T value1 means jodi T string kore tahole value1 and value 2 string hobe 
        */
        public static bool AreEqual<T>(T value1, T value2) {

            return value1.Equals(value2);
        }
    }
}