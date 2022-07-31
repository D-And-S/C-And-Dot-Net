namespace Generic
{
    // I want all of the method of this class will be integer 
    // To Do that we can make class generic
    public class Math<T>{
        public static bool AreEqual(T value1, T value2){
            
            return value1.Equals(value2);
        } 
    }
}