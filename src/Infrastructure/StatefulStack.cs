using Amazon.CDK;
using Amazon.CDK.AWS.EC2;
using Constructs;

namespace Infrastructure
{
    public class StatefulStack : Stack
    {
        internal StatefulStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var vpc = new MincuruVpc(this, "mincuru-vpc");
            // new MincuruDb(this, "mincuru-rds", new MincuruDb.MincuruDbProps
            // {
            //     Vpc = vpc.Vpc,
            // });
        }
    }
}
