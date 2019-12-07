using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestureRecognitionClient
{
    class RecognitionClient
    {
        private readonly Recognition.RecognitionServer.RecognitionServerClient client;
        public RecognitionClient(Recognition.RecognitionServer.RecognitionServerClient client)
        {
            this.client = client;
        }


        public async Task GestureRecognition()
        {
            
        }
    }
}
