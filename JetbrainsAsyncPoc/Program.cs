using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetbrainsAsyncPoc
{
    class Program
    {
        // static void Main(string[] args) // <--- breakpoint is working fine
        static async Task Main(string[] args) // <--- breakpoint is broken in Rider since its running async
        {
            var listOfModels = new List<MyModel>
            {
                new MyModel
                {
                    Name = "model1"
                },
                new MyModel
                {
                    Name = "model2"
                }
            };

            var distinct = listOfModels.Distinct(new MyModelComparer());
            Console.WriteLine($"{distinct.Count()} items in list");
        }
    }
}