using System;
using System.Collections.Generic;
using System.Threading;
namespace Mindfulness
{
    private class ListeningActivity : Activity
    {
        private List<string> prompts = new List<string>()
        {
            "blah blah",
            "blah blah",
            "blah blah",
            "blah blah"
        };

        public ListeningActivity()
        : base ("ListeningActivity","This Activity will help you slow down and listen.", 5 )
        {}

        

    }









}

