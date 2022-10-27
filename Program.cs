using System;
using System.Collections.Generic;

namespace project{

    class Program{
        
        static void Main(){
            Editor editor = new Editor();

            Test test1 = new Test();
            test1.NameOfTest = "test1";
            editor.TestArr.Add(test1);

            Test test2 = new Test();
            test2.NameOfTest = "test2";
            editor.TestArr.Add(test2);

            editor.printAllTests();
        }

    }

}
