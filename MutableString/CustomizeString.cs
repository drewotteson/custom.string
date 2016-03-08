using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableString
{
    class CustomizeString : IEnumerable
    {
        private char[] _Input;
        private char[] _anotherInput;

        public CustomizeString()
        {
            _Input = new char[0];
            _anotherInput = new char[0];
        }

        public void ToUpper(string input)
        {
            _Input = input.ToCharArray();
            string output = "";
            for (int i = 0; i < _Input.Length; i++)
            {
                if (_Input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(_Input[i] - 'a' + 'A');
                }
                else
                {
                    output += _Input[i];
                }
            }
            Console.Write(output);
        }

        public void ToLower(string input)
        {
            _Input = input.ToCharArray();
            string output = "";
            for (int i = 0; i < _Input.Length; i++)
            {
                if (_Input[i] >= 'A' && _Input[i] <= 'Z')
                {
                    output += (char)(_Input[i] - 'A' + 'a');
                }
                else
                {
                    output += _Input[i];
                }
            }
            Console.Write(output);
        }

        public void Split(string input)
        {
            _Input = input.ToCharArray();
            string result;
            foreach (char c in _Input)
            {
                result = (c + ",");
                Console.Write(result);
            }
        }

        public void Count(string input)
        {
            _Input = input.ToCharArray();
            int count = 0;
            foreach(char item in _Input)
            {
                count += 1;
                Console.Write(count);
            }
        }

        public bool Contains(string input, string anotherinput)
        {

            _Input = input.ToCharArray();
            _anotherInput = anotherinput.ToCharArray();
            _anotherInput = _Input;
            bool isFound = false;
            for (int i = 0; i < _Input.Length; i++)
            {
                for (int j = 0; i < _anotherInput.Length; i++)
                {
                    if (_Input[i].Equals(_anotherInput[j]))
                    {
                        isFound = true;
                    }
                }
            }
            return isFound;
        }

        public void Replace(string input, string find, string replace)
        {
            _Input = input.ToCharArray();
            if (find != replace)
            {
                if (find.Length == replace.Length)
                {
                    int fLength = find.Length;
                    int result = 0;
                    int startIndex = 0;
                    for (int i = 0; i < input.Length - find.Length - 1; i++)
                    {
                        int count = 0;
                        int j = 0;
                        startIndex = i;
                        while (j < find.Length - 1)
                        {
                            if (input[i] == find[j])
                            {
                                count++;
                            }
                            i++;
                            j++;
                        }
                        if (count == find.Length - 1)
                        {
                            result = 1;
                            break;
                        }
                    }
                    if (result == 1)
                    {
                        int j = 0;
                        for (int i = startIndex; i < startIndex + fLength; i++)
                        {
                            _Input[i] = replace[j];
                            j++;
                        }
                    }
                }
            }
            for (int i = 0; i <_Input.Length; i++)
            {
                Console.Write(_Input[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_Input).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_Input).GetEnumerator();
        }
    }
}

//List<string> stringList;

//public string getString()
//{
//    Console.WriteLine("type something");
//    stringToChange = Console.ReadLine();
//    return stringToChange;
//}
//public void wayToChange()
//{
//    Console.WriteLine("choose: ToUpper, ToLower, Contains, Count, Replace");
//    howToChange = Console.ReadLine();

//    switch (howToChange)
//    {
//        case "ToUpper":
//            changeToUpper();
//            break;
//        case "ToLower":
//            changeToLower();
//            break;
//        case "Contains":
//            Contains();
//            break;
//        case "Count":
//            Count();
//            break;
//        case "Replace":
//            Replace();
//            break;
//        default:
//            break;
//    }
//}
//public void changeToUpper()
//{
//    for (int i = 0; i < stringToChange.Length; i++)
//    {
//        
//    }
//}

