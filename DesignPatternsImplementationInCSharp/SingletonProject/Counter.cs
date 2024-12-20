﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject
{
    public class Counter
    {
        private static Counter _instance;

        private static readonly Object _lock = new Object();

        private int _count;
        private Counter()
        {
            _count = 0;
        }

        public static Counter Instance
        {
            get
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                    }
                }
                return _instance;
            }
        }

        public void Increment()
        {
            _count++;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
