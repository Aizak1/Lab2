using System;

namespace Task2
{
    class TaskConverter
    {
        private  int _initialDecimalNumber;
        private string _binaryRepresentation;
        public int InitialNumber => _initialDecimalNumber;

        public string BinaryRepresentation => _binaryRepresentation;

       
        public TaskConverter(int initialNumber)
        {
            this._initialDecimalNumber = initialNumber;
            _binaryRepresentation = Convert(initialNumber);
        }
        public string Convert(int number)
        {
            bool isInCorrectFormat = number >= 0;
            if (isInCorrectFormat)
                return System.Convert.ToString(number, 2);
            else
            {
                throw new ArgumentException("Invalid Format Of Number");
                
            }
                
        }
    }
}
