using Amazon.CDK;

namespace Infrastructure
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new StatefulStack(app, "mincuru-statuful-stack");

            app.Synth();
        }
    }
}
