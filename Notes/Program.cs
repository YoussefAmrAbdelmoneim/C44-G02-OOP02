namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //A struct is a value type in C#.
            //It is used to encapsulate small groups of related variables
            //Doesnt support inheritance
            //3 Access Modifier Allowed Inside It [Public , Internal ,Private]
            /*Compiler Will always Generate Parameterless Constructor That
            Initialize Struct attributes with Default value unless you Defined a Parameterless Constructor */
            #endregion
            #region Encapsulation
            /*
             * It refers to the bundling of data (fields) and the methods (functions) that operate on
             * that data into a single unit or class. It provide restricting access to some of an object's internal state (Data)
             * and requiring all interaction to be performed through well-defined methods (Getter and Setter). 
             */
            //This protects the internal data and ensures that it can only be modified in a controlled way.
            #endregion
            #region Properties
            //Full Property
            /*
             * Property where you can define the get and set accessors with custom business logic, 
             * make you have more control over how values are retrieved or assigned
             */

            //Automatic Property
            /*
             * The C# compiler generates private backing fields for these properties behind the scenes
             */

            //Indexer
            /*
             * Is a Special Property [Named With Keyword This and Can Take Parameters]
               that allows instances of a class or struct to be indexed like arrays.
             */
            #endregion
        }
    }
}
