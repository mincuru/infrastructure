using Amazon.CDK.AWS.EC2;
using Constructs;

namespace Infrastructure
{
    public class MincuruVpc : Construct
    {
        public Vpc Vpc { get; set; }

        public MincuruVpc(Construct scope, string id) : base(scope, id)
        {
            var vpcProps = new VpcProps
            {
                SubnetConfiguration = new SubnetConfiguration[]
                {
                        new SubnetConfiguration
                        {
                            Name = "private",
                            CidrMask = 24,
                            SubnetType = SubnetType.PRIVATE_ISOLATED,
                        }
                },
                MaxAzs = 2
            };
            var vpc = new Vpc(this, id, vpcProps);

            // Expose
            Vpc = vpc;
        }
    }
}
