/*4.1.2 메서드*/

using System;

namespace ConsoleApp1
{
    public void WriteIf(bool output, string txt)
    {
        if (output == false)
        {
            return;
        }

        Console.WriteLine(txt);
    }
}