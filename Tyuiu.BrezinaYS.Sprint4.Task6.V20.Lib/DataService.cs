﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrezinaYS.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length < 10);
            return res;
        }
    }
}
