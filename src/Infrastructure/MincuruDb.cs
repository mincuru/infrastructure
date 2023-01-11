using Amazon.CDK;
using Amazon.CDK.AWS.EC2;
using Amazon.CDK.AWS.RDS;
using Constructs;

namespace Infrastructure
{
    public class MincuruDb : Construct
    {
        public class MincuruDbProps
        {
            public Amazon.CDK.AWS.EC2.Vpc Vpc { get; set; }
        }

        public MincuruDb(Construct scope, string id, MincuruDbProps props = null) : base(scope, id)
        {
            // DatabaseCluster cluster = new DatabaseCluster(this, "Database", new DatabaseClusterProps
            // {
            //     Engine = DatabaseClusterEngine.AuroraMysql(new AuroraMysqlClusterEngineProps { Version = AuroraMysqlEngineVersion.VER_2_08_1 }),
            //     Credentials = Credentials.FromGeneratedSecret("clusteradmin"),  // Optional - will default to 'admin' username and generated password
            //     InstanceProps = new InstanceProps
            //     {
            //         // optional , defaults to t3.medium
            //         InstanceType = InstanceType.Of(InstanceClass.BURSTABLE2, InstanceSize.SMALL),
            //         VpcSubnets = new SubnetSelection
            //         {
            //             SubnetType = SubnetType.PRIVATE_WITH_EGRESS
            //         },
            //         Vpc = vpc
            //     }
            // });

            // aurora-serverless v1 を作れるが、v2 はまだ作れない
            // var rds = new ServerlessCluster(this, id, new ServerlessClusterProps
            // {
            //     Engine = DatabaseClusterEngine.AURORA_POSTGRESQL,
            //     Vpc = props.Vpc,
            //     Credentials = Credentials.FromGeneratedSecret("postgres"),
            //     ClusterIdentifier = "mincuru-db-cluster",
            //     DefaultDatabaseName = "mincuru",
            //     ParameterGroup = ParameterGroup.FromParameterGroupName(this, "aurora-serverless-param-group", "default.aurora-postgresql10"),
            //     VpcSubnets = new SubnetSelection
            //     {
            //         SubnetType = SubnetType.PRIVATE_ISOLATED,
            //     },
            //     RemovalPolicy = RemovalPolicy.DESTROY,  // DESTROYは開発中のみ使用すること
            //     Scaling = new ServerlessScalingOptions
            //     {
            //         AutoPause = Duration.Minutes(5),
            //         MinCapacity = AuroraCapacityUnit.ACU_2,
            //         MaxCapacity = AuroraCapacityUnit.ACU_2,
            //     },
            //     EnableDataApi = false,
            // });


            // rds.Connections.AllowDefaultPortFrom(sgEc2, "allow ec2 to rds");
            // var cluster = new DatabaseCluster(scope, id, new DatabaseClusterProps
            // {
            //     Engine = DatabaseClusterEngine.AURORA_POSTGRESQL,
            //     Instances = 1,
            //     InstanceProps = new Amazon.CDK.AWS.RDS.InstanceProps
            //     {
            //         InstanceType = new InstanceType("serverless"),
            //         Vpc = props.Vpc,
            //         VpcSubnets = new SubnetSelection
            //         {
            //             SubnetType = SubnetType.PRIVATE_ISOLATED,
            //         },
            //     },
            //     // RemovalPolicy = RemovalPolicy.DESTROY,  // DESTROYは開発中のみ使用すること
            // });
            // var node = cluster.Node.FindChild("Resource");
            // ((CfnDBCluster)node).ServerlessV2ScalingConfiguration = new CfnDBCluster.ServerlessV2ScalingConfigurationProperty
            // {
            //     MinCapacity = 0.5,
            //     MaxCapacity = 1,
            // };

            // Aspects.Of(cluster).Add(new Aspects. .Tag("Name", "mincuru-db-cluster"));

            //             new Aspect({
            // visit(node) {
            //     if (node instanceof  CfnDBCluster) {
            //             node.serverlessV2ScalingConfiguration = {
            //             minCapacity: 0.5,
            //         maxCapacity: 1
            //                             }
            //         }
            //     }
            // }),

        }

        // RDS
        // new DatabaseInstance(this, id, new DatabaseInstanceProps
        // {
        //     Engine = DatabaseInstanceEngine.POSTGRES,
        //     // InstanceType = InstanceType.Of(InstanceClass.BURSTABLE2, InstanceSize.SMALL),
        //     AllocatedStorage = 8,
        //     StorageType = StorageType.STANDARD,
        //     Vpc = props.Vpc,
        //     VpcSubnets = new SubnetSelection
        //     {
        //         SubnetType = SubnetType.PRIVATE_ISOLATED,
        //     },
        //     MultiAz = false,
        //     // MasterUsername = "hoge",
        //     // MasterUserPassword = SecretValue.PlainText("hoge"),
        //     RemovalPolicy = RemovalPolicy.DESTROY,  // DESTROYは開発中のみ使用すること
        // });
    }
}
